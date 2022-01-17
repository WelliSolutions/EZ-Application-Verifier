
namespace ThomasWeller.EasyAppVerif
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.lblDirectory = new System.Windows.Forms.Label();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnFindApps = new System.Windows.Forms.Button();
            this.chkExes = new System.Windows.Forms.CheckedListBox();
            this.btnAppVerif = new System.Windows.Forms.Button();
            this.tmrMultiCheck = new System.Windows.Forms.Timer(this.components);
            this.picEverything = new System.Windows.Forms.PictureBox();
            this.dirSelect = new System.Windows.Forms.OpenFileDialog();
            this.chkCrashDumps = new System.Windows.Forms.CheckBox();
            this.txtCrashDumps = new System.Windows.Forms.TextBox();
            this.btnBrowseCrashDump = new System.Windows.Forms.Button();
            this.lblCrashDumpInfo = new System.Windows.Forms.Label();
            this.lblAppVerifDefaultsInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picEverything)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDirectory
            // 
            this.lblDirectory.AutoSize = true;
            this.lblDirectory.Location = new System.Drawing.Point(9, 9);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(260, 13);
            this.lblDirectory.TabIndex = 0;
            this.lblDirectory.Text = "&Directory to enable Application Verifier default settings";
            // 
            // txtDirectory
            // 
            this.txtDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDirectory.Location = new System.Drawing.Point(12, 25);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(323, 20);
            this.txtDirectory.TabIndex = 1;
            this.txtDirectory.Text = "C:\\Program Files (x86)\\Adobe\\Acrobat Reader DC";
            this.txtDirectory.TextChanged += new System.EventHandler(this.txtDirectory_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(341, 23);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "&Browse ...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnFindApps
            // 
            this.btnFindApps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindApps.Location = new System.Drawing.Point(12, 52);
            this.btnFindApps.Name = "btnFindApps";
            this.btnFindApps.Size = new System.Drawing.Size(404, 23);
            this.btnFindApps.TabIndex = 3;
            this.btnFindApps.Text = "&Find executables";
            this.btnFindApps.UseVisualStyleBackColor = true;
            this.btnFindApps.Click += new System.EventHandler(this.btnFindApps_Click);
            // 
            // chkExes
            // 
            this.chkExes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkExes.CheckOnClick = true;
            this.chkExes.FormattingEnabled = true;
            this.chkExes.Location = new System.Drawing.Point(12, 81);
            this.chkExes.Name = "chkExes";
            this.chkExes.Size = new System.Drawing.Size(404, 259);
            this.chkExes.TabIndex = 4;
            this.chkExes.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkExes_ItemCheck);
            // 
            // btnAppVerif
            // 
            this.btnAppVerif.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppVerif.Location = new System.Drawing.Point(12, 376);
            this.btnAppVerif.Name = "btnAppVerif";
            this.btnAppVerif.Size = new System.Drawing.Size(404, 62);
            this.btnAppVerif.TabIndex = 8;
            this.btnAppVerif.Text = "&Enable ApplicationVerifier for selected executables,\r\ndisable for deselected exe" +
    "cutables,\r\ndo nothing for indeterminate executables";
            this.btnAppVerif.UseVisualStyleBackColor = true;
            this.btnAppVerif.Click += new System.EventHandler(this.btnAppVerif_Click);
            // 
            // tmrMultiCheck
            // 
            this.tmrMultiCheck.Enabled = true;
            this.tmrMultiCheck.Interval = 1500;
            this.tmrMultiCheck.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picEverything
            // 
            this.picEverything.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picEverything.Image = ((System.Drawing.Image)(resources.GetObject("picEverything.Image")));
            this.picEverything.Location = new System.Drawing.Point(53, 246);
            this.picEverything.Name = "picEverything";
            this.picEverything.Size = new System.Drawing.Size(309, 64);
            this.picEverything.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picEverything.TabIndex = 6;
            this.picEverything.TabStop = false;
            this.picEverything.Visible = false;
            this.picEverything.Click += new System.EventHandler(this.picEverything_Click);
            // 
            // dirSelect
            // 
            this.dirSelect.AddExtension = false;
            this.dirSelect.CheckFileExists = false;
            this.dirSelect.FileName = "No file name needed";
            this.dirSelect.RestoreDirectory = true;
            this.dirSelect.Title = "Select directory";
            this.dirSelect.ValidateNames = false;
            // 
            // chkCrashDumps
            // 
            this.chkCrashDumps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkCrashDumps.AutoSize = true;
            this.chkCrashDumps.Checked = true;
            this.chkCrashDumps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCrashDumps.Location = new System.Drawing.Point(12, 350);
            this.chkCrashDumps.Name = "chkCrashDumps";
            this.chkCrashDumps.Size = new System.Drawing.Size(140, 17);
            this.chkCrashDumps.TabIndex = 5;
            this.chkCrashDumps.Text = "Apply local &crash dumps";
            this.chkCrashDumps.UseVisualStyleBackColor = true;
            // 
            // txtCrashDumps
            // 
            this.txtCrashDumps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCrashDumps.Location = new System.Drawing.Point(178, 348);
            this.txtCrashDumps.Name = "txtCrashDumps";
            this.txtCrashDumps.Size = new System.Drawing.Size(157, 20);
            this.txtCrashDumps.TabIndex = 6;
            this.txtCrashDumps.Text = "d:\\debug\\dumps";
            this.txtCrashDumps.TextChanged += new System.EventHandler(this.txtCrashDumps_TextChanged);
            // 
            // btnBrowseCrashDump
            // 
            this.btnBrowseCrashDump.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseCrashDump.Location = new System.Drawing.Point(341, 346);
            this.btnBrowseCrashDump.Name = "btnBrowseCrashDump";
            this.btnBrowseCrashDump.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseCrashDump.TabIndex = 7;
            this.btnBrowseCrashDump.Text = "&Browse ...";
            this.btnBrowseCrashDump.UseVisualStyleBackColor = true;
            this.btnBrowseCrashDump.Click += new System.EventHandler(this.btnBrowseCrashDump_Click);
            // 
            // lblCrashDumpInfo
            // 
            this.lblCrashDumpInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCrashDumpInfo.AutoSize = true;
            this.lblCrashDumpInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrashDumpInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCrashDumpInfo.Location = new System.Drawing.Point(152, 351);
            this.lblCrashDumpInfo.Name = "lblCrashDumpInfo";
            this.lblCrashDumpInfo.Size = new System.Drawing.Size(13, 13);
            this.lblCrashDumpInfo.TabIndex = 9;
            this.lblCrashDumpInfo.Text = "?";
            this.lblCrashDumpInfo.Click += new System.EventHandler(this.lblCrashDumpInfo_Click);
            // 
            // lblAppVerifDefaultsInfo
            // 
            this.lblAppVerifDefaultsInfo.AutoSize = true;
            this.lblAppVerifDefaultsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppVerifDefaultsInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAppVerifDefaultsInfo.Location = new System.Drawing.Point(275, 9);
            this.lblAppVerifDefaultsInfo.Name = "lblAppVerifDefaultsInfo";
            this.lblAppVerifDefaultsInfo.Size = new System.Drawing.Size(13, 13);
            this.lblAppVerifDefaultsInfo.TabIndex = 10;
            this.lblAppVerifDefaultsInfo.Text = "?";
            this.lblAppVerifDefaultsInfo.Click += new System.EventHandler(this.lblAppVerifDefaultsInfo_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 450);
            this.Controls.Add(this.lblAppVerifDefaultsInfo);
            this.Controls.Add(this.lblCrashDumpInfo);
            this.Controls.Add(this.btnBrowseCrashDump);
            this.Controls.Add(this.txtCrashDumps);
            this.Controls.Add(this.chkCrashDumps);
            this.Controls.Add(this.picEverything);
            this.Controls.Add(this.btnAppVerif);
            this.Controls.Add(this.chkExes);
            this.Controls.Add(this.btnFindApps);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.lblDirectory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(444, 489);
            this.Name = "GUI";
            this.Text = "EZ Application Verifier";
            this.Load += new System.EventHandler(this.GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picEverything)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDirectory;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnFindApps;
        private System.Windows.Forms.CheckedListBox chkExes;
        private System.Windows.Forms.Button btnAppVerif;
        private System.Windows.Forms.Timer tmrMultiCheck;
        private System.Windows.Forms.PictureBox picEverything;
        private System.Windows.Forms.OpenFileDialog dirSelect;
        private System.Windows.Forms.CheckBox chkCrashDumps;
        private System.Windows.Forms.TextBox txtCrashDumps;
        private System.Windows.Forms.Button btnBrowseCrashDump;
        private System.Windows.Forms.Label lblCrashDumpInfo;
        private System.Windows.Forms.Label lblAppVerifDefaultsInfo;
    }
}

