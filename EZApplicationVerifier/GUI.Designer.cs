
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
            ((System.ComponentModel.ISupportInitialize)(this.picEverything)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDirectory
            // 
            this.lblDirectory.AutoSize = true;
            this.lblDirectory.Location = new System.Drawing.Point(12, 9);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(201, 13);
            this.lblDirectory.TabIndex = 0;
            this.lblDirectory.Text = "&Directory to enable Application Verifier for";
            // 
            // txtDirectory
            // 
            this.txtDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDirectory.Location = new System.Drawing.Point(15, 25);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(320, 20);
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
            this.btnFindApps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.chkExes.Size = new System.Drawing.Size(404, 289);
            this.chkExes.TabIndex = 4;
            this.chkExes.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkExes_ItemCheck);
            // 
            // btnAppVerif
            // 
            this.btnAppVerif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppVerif.Location = new System.Drawing.Point(12, 376);
            this.btnAppVerif.Name = "btnAppVerif";
            this.btnAppVerif.Size = new System.Drawing.Size(404, 62);
            this.btnAppVerif.TabIndex = 5;
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
            this.picEverything.Location = new System.Drawing.Point(52, 286);
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
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 450);
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
    }
}

