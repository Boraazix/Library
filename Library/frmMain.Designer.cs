namespace Library
{
    partial class frmMain
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAuthorRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBookRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPublisherRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAuthorReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBookReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPublisherReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuRegistration,
            this.mnuReports});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(800, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(93, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuRegistration
            // 
            this.mnuRegistration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAuthorRegistration,
            this.mnuBookRegistration,
            this.mnuPublisherRegistration});
            this.mnuRegistration.Name = "mnuRegistration";
            this.mnuRegistration.Size = new System.Drawing.Size(82, 20);
            this.mnuRegistration.Text = "Registration";
            // 
            // mnuAuthorRegistration
            // 
            this.mnuAuthorRegistration.Name = "mnuAuthorRegistration";
            this.mnuAuthorRegistration.Size = new System.Drawing.Size(123, 22);
            this.mnuAuthorRegistration.Text = "Author";
            this.mnuAuthorRegistration.Click += new System.EventHandler(this.mnuAuthorRegistration_Click);
            // 
            // mnuBookRegistration
            // 
            this.mnuBookRegistration.Name = "mnuBookRegistration";
            this.mnuBookRegistration.Size = new System.Drawing.Size(123, 22);
            this.mnuBookRegistration.Text = "Book";
            this.mnuBookRegistration.Click += new System.EventHandler(this.mnuBookRegistration_Click);
            // 
            // mnuPublisherRegistration
            // 
            this.mnuPublisherRegistration.Name = "mnuPublisherRegistration";
            this.mnuPublisherRegistration.Size = new System.Drawing.Size(123, 22);
            this.mnuPublisherRegistration.Text = "Publisher";
            this.mnuPublisherRegistration.Click += new System.EventHandler(this.mnuPublisherRegistration_Click);
            // 
            // mnuReports
            // 
            this.mnuReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAuthorReport,
            this.mnuBookReport,
            this.mnuPublisherReport});
            this.mnuReports.Name = "mnuReports";
            this.mnuReports.Size = new System.Drawing.Size(59, 20);
            this.mnuReports.Text = "Reports";
            // 
            // mnuAuthorReport
            // 
            this.mnuAuthorReport.Name = "mnuAuthorReport";
            this.mnuAuthorReport.Size = new System.Drawing.Size(180, 22);
            this.mnuAuthorReport.Text = "Author";
            this.mnuAuthorReport.Click += new System.EventHandler(this.mnuAuthorReport_Click);
            // 
            // mnuBookReport
            // 
            this.mnuBookReport.Name = "mnuBookReport";
            this.mnuBookReport.Size = new System.Drawing.Size(180, 22);
            this.mnuBookReport.Text = "Book";
            this.mnuBookReport.Click += new System.EventHandler(this.mnuBookReport_Click);
            // 
            // mnuPublisherReport
            // 
            this.mnuPublisherReport.Name = "mnuPublisherReport";
            this.mnuPublisherReport.Size = new System.Drawing.Size(180, 22);
            this.mnuPublisherReport.Text = "Publisher";
            this.mnuPublisherReport.Click += new System.EventHandler(this.mnuPublisherReport_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.Text = "Library";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuRegistration;
        private ToolStripMenuItem mnuAuthorRegistration;
        private ToolStripMenuItem mnuBookRegistration;
        private ToolStripMenuItem mnuPublisherRegistration;
        private ToolStripMenuItem mnuReports;
        private ToolStripMenuItem mnuAuthorReport;
        private ToolStripMenuItem mnuBookReport;
        private ToolStripMenuItem mnuPublisherReport;
    }
}