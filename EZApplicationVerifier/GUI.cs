using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ThomasWeller.EasyAppVerif.Properties;

namespace ThomasWeller.EasyAppVerif
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private void btnFindApps_Click(object sender, EventArgs e)
        {
            FindExecutables();
        }

        private void FindExecutables()
        {
            chkExes.Items.Clear();
            var exes = GetExecutables();
            foreach (var file in exes)
            {
                int index = chkExes.Items.Add(file.Name);
                chkExes.SetItemCheckState(index, CheckState.Indeterminate);
            }
        }

        private IEnumerable<FileInfo> GetExecutables()
        {
            var dir = new DirectoryInfo(txtDirectory.Text);
            try
            {
                var exes = dir.GetFiles("*.exe", SearchOption.AllDirectories);
                var distinctBy = exes.DistinctBy(n => n.Name).ToList();
                distinctBy.Sort((n, m) => string.Compare(n.Name, m.Name, StringComparison.OrdinalIgnoreCase));
                return distinctBy;
            }
            catch (DirectoryNotFoundException)
            {
                txtDirectory.ForeColor = Color.Red;
                return new List<FileInfo>();
            }
        }

        private void chkExes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Fix the order
            if (e.CurrentValue == CheckState.Indeterminate)
                e.NewValue = CheckState.Checked;
            else if (e.CurrentValue == CheckState.Unchecked)
                e.NewValue = CheckState.Indeterminate;
            else if (e.CurrentValue == CheckState.Checked)
                e.NewValue = CheckState.Unchecked;

            if (e.NewValue == CheckState.Checked)
            {
                _itemsCheckedSinceLastTick++;
            }
            if (_itemsCheckedSinceLastTick >= 3)
            {
                AskMultiCheck();
            }
        }

        private int _itemsCheckedSinceLastTick;

        private void timer1_Tick(object sender, EventArgs e)
        {
            _itemsCheckedSinceLastTick = 0;
        }

        private void AskMultiCheck()
        {
            var uncheckedCount = 0;
            for (var index = 0; index < chkExes.Items.Count; index++)
            {
                var state = chkExes.GetItemCheckState(index);
                if (state == CheckState.Unchecked || state == CheckState.Indeterminate)
                {
                    uncheckedCount++;
                }
            }
            if (uncheckedCount <= 1) return;

            tmrMultiCheck.Enabled = false;
            chkExes.ItemCheck -= chkExes_ItemCheck;
            var result = MessageBox.Show(Resources.MultiCheckQuestion,
                Resources.MultiCheckTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                picEverything.Visible = true;
                for (int index = 0; index < chkExes.Items.Count; index++)
                {
                    chkExes.SetItemChecked(index, true);
                }
            }

            chkExes.ItemCheck += chkExes_ItemCheck;
            tmrMultiCheck.Enabled = true;
        }

        private void picEverything_Click(object sender, EventArgs e)
        {
            picEverything.Visible = false;
        }

        private void btnAppVerif_Click(object sender, EventArgs e)
        {
            ProcessCheckedList(item => new ApplicationVerifierDefault(item).Enable(), item => new ApplicationVerifierDefault(item).Disable());
            ProcessCheckedList(item => new LocalDumps(item, txtCrashDumps.Text).Enable(), item => new LocalDumps(item, txtCrashDumps.Text).Disable());
        }


        private void ProcessCheckedList(Action<string> enable, Action<string> disable)
        {
            for (var index = 0; index < chkExes.Items.Count; index++)
            {
                string item = (string)chkExes.Items[index];
                if (chkExes.GetItemCheckState(index) == CheckState.Checked)
                {
                    enable(item);
                }

                if (chkExes.GetItemCheckState(index) == CheckState.Unchecked)
                {
                    disable(item);
                }
            }
        }

        private void txtDirectory_TextChanged(object sender, EventArgs e)
        {
            txtDirectory.ForeColor = SystemColors.WindowText;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            SelectDirectory(txtDirectory);
        }

        private void SelectDirectory(TextBox textBox)
        {
            dirSelect.InitialDirectory = textBox.Text;
            var answer = dirSelect.ShowDialog(this);
            if (answer == DialogResult.OK)
            {
                textBox.Text = new FileInfo(dirSelect.FileName).DirectoryName;
            }
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            MakeSameSize(picEverything, chkExes);
        }

        private static void MakeSameSize(Control target, Control source)
        {
            target.Location = source.Location;
            target.Size = source.Size;
        }

        private void btnBrowseCrashDump_Click(object sender, EventArgs e)
        {
            SelectDirectory(txtCrashDumps);
        }

        private void lblCrashDumpInfo_Click(object sender, EventArgs e)
        {
            Process.Start("https://docs.microsoft.com/en-us/windows/win32/wer/collecting-user-mode-dumps");
        }
    }
}
