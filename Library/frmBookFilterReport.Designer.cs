namespace Library
{
    partial class frmBookFilterReport
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
            pnlMain = new Panel();
            btnFilter = new Button();
            grpPublisher = new GroupBox();
            txtPublisher = new TextBox();
            lstPublishers = new ListBox();
            chkAllPublishers = new CheckBox();
            grpAuthor = new GroupBox();
            lstAuthors = new ListBox();
            chkAllAuthors = new CheckBox();
            txtAuthor = new TextBox();
            pnlMain.SuspendLayout();
            grpPublisher.SuspendLayout();
            grpAuthor.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(btnFilter);
            pnlMain.Controls.Add(grpPublisher);
            pnlMain.Controls.Add(grpAuthor);
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(478, 318);
            pnlMain.TabIndex = 0;
            // 
            // btnFilter
            // 
            btnFilter.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnFilter.Location = new Point(12, 262);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(452, 47);
            btnFilter.TabIndex = 2;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // grpPublisher
            // 
            grpPublisher.Controls.Add(txtPublisher);
            grpPublisher.Controls.Add(lstPublishers);
            grpPublisher.Controls.Add(chkAllPublishers);
            grpPublisher.Location = new Point(242, 12);
            grpPublisher.Name = "grpPublisher";
            grpPublisher.Size = new Size(222, 244);
            grpPublisher.TabIndex = 1;
            grpPublisher.TabStop = false;
            grpPublisher.Text = "Filter by publisher";
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(15, 22);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.PlaceholderText = "Search by publisher's name";
            txtPublisher.Size = new Size(189, 23);
            txtPublisher.TabIndex = 0;
            txtPublisher.KeyUp += txtPublisher_KeyUp;
            // 
            // lstPublishers
            // 
            lstPublishers.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lstPublishers.FormattingEnabled = true;
            lstPublishers.ItemHeight = 17;
            lstPublishers.Location = new Point(15, 51);
            lstPublishers.Name = "lstPublishers";
            lstPublishers.Size = new Size(189, 157);
            lstPublishers.TabIndex = 1;
            // 
            // chkAllPublishers
            // 
            chkAllPublishers.AutoSize = true;
            chkAllPublishers.Location = new Point(15, 214);
            chkAllPublishers.Name = "chkAllPublishers";
            chkAllPublishers.Size = new Size(97, 19);
            chkAllPublishers.TabIndex = 2;
            chkAllPublishers.Text = "All publishers";
            chkAllPublishers.UseVisualStyleBackColor = true;
            chkAllPublishers.CheckedChanged += chkAllPublishers_CheckedChanged;
            // 
            // grpAuthor
            // 
            grpAuthor.Controls.Add(lstAuthors);
            grpAuthor.Controls.Add(chkAllAuthors);
            grpAuthor.Controls.Add(txtAuthor);
            grpAuthor.Location = new Point(12, 12);
            grpAuthor.Name = "grpAuthor";
            grpAuthor.Size = new Size(222, 244);
            grpAuthor.TabIndex = 0;
            grpAuthor.TabStop = false;
            grpAuthor.Text = "Filter by author";
            // 
            // lstAuthors
            // 
            lstAuthors.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lstAuthors.FormattingEnabled = true;
            lstAuthors.ItemHeight = 17;
            lstAuthors.Location = new Point(15, 52);
            lstAuthors.Name = "lstAuthors";
            lstAuthors.Size = new Size(189, 157);
            lstAuthors.TabIndex = 1;
            // 
            // chkAllAuthors
            // 
            chkAllAuthors.AutoSize = true;
            chkAllAuthors.Location = new Point(15, 214);
            chkAllAuthors.Name = "chkAllAuthors";
            chkAllAuthors.Size = new Size(83, 19);
            chkAllAuthors.TabIndex = 2;
            chkAllAuthors.Text = "All authors";
            chkAllAuthors.UseVisualStyleBackColor = true;
            chkAllAuthors.CheckedChanged += chkAllAuthors_CheckedChanged;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(15, 22);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.PlaceholderText = "Search by author's name";
            txtAuthor.Size = new Size(189, 23);
            txtAuthor.TabIndex = 0;
            txtAuthor.KeyUp += txtAuthor_KeyUp;
            // 
            // frmBookFilterReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 318);
            Controls.Add(pnlMain);
            MaximizeBox = false;
            MaximumSize = new Size(494, 357);
            MinimumSize = new Size(494, 357);
            Name = "frmBookFilterReport";
            Text = "frmBookFilterReport";
            pnlMain.ResumeLayout(false);
            grpPublisher.ResumeLayout(false);
            grpPublisher.PerformLayout();
            grpAuthor.ResumeLayout(false);
            grpAuthor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private TextBox txtPublisher;
        private TextBox txtAuthor;
        private ListBox lstPublishers;
        private ListBox lstAuthors;
        private GroupBox grpAuthor;
        private CheckBox chkAllAuthors;
        private CheckBox chkAllPublishers;
        private Button btnFilter;
        private GroupBox grpPublisher;
    }
}