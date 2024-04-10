namespace Library
{
    partial class frmBookRegistration
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.chkRelease = new System.Windows.Forms.CheckBox();
            this.nudEdition = new System.Windows.Forms.NumericUpDown();
            this.lblEdition = new System.Windows.Forms.Label();
            this.nudPages = new System.Windows.Forms.NumericUpDown();
            this.lblPages = new System.Windows.Forms.Label();
            this.dtpPublication = new System.Windows.Forms.DateTimePicker();
            this.lblPublication = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.cmbPublishers = new System.Windows.Forms.ComboBox();
            this.lblSelectedAuthors = new System.Windows.Forms.Label();
            this.lblSearching = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lstSelectedAuthors = new System.Windows.Forms.ListBox();
            this.lstAuthors = new System.Windows.Forms.ListBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthors = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPages)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnRegister);
            this.pnlMain.Controls.Add(this.chkRelease);
            this.pnlMain.Controls.Add(this.nudEdition);
            this.pnlMain.Controls.Add(this.lblEdition);
            this.pnlMain.Controls.Add(this.nudPages);
            this.pnlMain.Controls.Add(this.lblPages);
            this.pnlMain.Controls.Add(this.dtpPublication);
            this.pnlMain.Controls.Add(this.lblPublication);
            this.pnlMain.Controls.Add(this.lblPublisher);
            this.pnlMain.Controls.Add(this.cmbPublishers);
            this.pnlMain.Controls.Add(this.lblSelectedAuthors);
            this.pnlMain.Controls.Add(this.lblSearching);
            this.pnlMain.Controls.Add(this.lblInstructions);
            this.pnlMain.Controls.Add(this.lstSelectedAuthors);
            this.pnlMain.Controls.Add(this.lstAuthors);
            this.pnlMain.Controls.Add(this.txtAuthor);
            this.pnlMain.Controls.Add(this.lblAuthors);
            this.pnlMain.Controls.Add(this.txtDescription);
            this.pnlMain.Controls.Add(this.lblDescription);
            this.pnlMain.Controls.Add(this.txtIsbn);
            this.pnlMain.Controls.Add(this.txtTitle);
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Controls.Add(this.lblIsbn);
            this.pnlMain.Controls.Add(this.txtCode);
            this.pnlMain.Controls.Add(this.lblCode);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(769, 303);
            this.pnlMain.TabIndex = 0;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(677, 263);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 27;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // chkRelease
            // 
            this.chkRelease.AutoSize = true;
            this.chkRelease.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkRelease.Location = new System.Drawing.Point(651, 217);
            this.chkRelease.Name = "chkRelease";
            this.chkRelease.Size = new System.Drawing.Size(101, 23);
            this.chkRelease.TabIndex = 26;
            this.chkRelease.Text = "New release";
            this.chkRelease.UseVisualStyleBackColor = true;
            // 
            // nudEdition
            // 
            this.nudEdition.Location = new System.Drawing.Point(587, 245);
            this.nudEdition.Name = "nudEdition";
            this.nudEdition.Size = new System.Drawing.Size(51, 23);
            this.nudEdition.TabIndex = 24;
            // 
            // lblEdition
            // 
            this.lblEdition.AutoSize = true;
            this.lblEdition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEdition.Location = new System.Drawing.Point(520, 245);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(61, 21);
            this.lblEdition.TabIndex = 23;
            this.lblEdition.Text = "Edition:";
            // 
            // nudPages
            // 
            this.nudPages.Location = new System.Drawing.Point(587, 216);
            this.nudPages.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudPages.Name = "nudPages";
            this.nudPages.Size = new System.Drawing.Size(51, 23);
            this.nudPages.TabIndex = 22;
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPages.Location = new System.Drawing.Point(528, 216);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(53, 21);
            this.lblPages.TabIndex = 21;
            this.lblPages.Text = "Pages:";
            // 
            // dtpPublication
            // 
            this.dtpPublication.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPublication.Location = new System.Drawing.Point(412, 244);
            this.dtpPublication.Name = "dtpPublication";
            this.dtpPublication.Size = new System.Drawing.Size(78, 23);
            this.dtpPublication.TabIndex = 20;
            // 
            // lblPublication
            // 
            this.lblPublication.AutoSize = true;
            this.lblPublication.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPublication.Location = new System.Drawing.Point(316, 245);
            this.lblPublication.Name = "lblPublication";
            this.lblPublication.Size = new System.Drawing.Size(90, 21);
            this.lblPublication.TabIndex = 19;
            this.lblPublication.Text = "Publication:";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPublisher.Location = new System.Drawing.Point(328, 213);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(78, 21);
            this.lblPublisher.TabIndex = 18;
            this.lblPublisher.Text = "Publisher:";
            // 
            // cmbPublishers
            // 
            this.cmbPublishers.FormattingEnabled = true;
            this.cmbPublishers.Location = new System.Drawing.Point(412, 215);
            this.cmbPublishers.Name = "cmbPublishers";
            this.cmbPublishers.Size = new System.Drawing.Size(109, 23);
            this.cmbPublishers.TabIndex = 17;
            // 
            // lblSelectedAuthors
            // 
            this.lblSelectedAuthors.AutoSize = true;
            this.lblSelectedAuthors.Location = new System.Drawing.Point(591, 184);
            this.lblSelectedAuthors.Name = "lblSelectedAuthors";
            this.lblSelectedAuthors.Size = new System.Drawing.Size(94, 15);
            this.lblSelectedAuthors.TabIndex = 16;
            this.lblSelectedAuthors.Text = "Selected authors";
            // 
            // lblSearching
            // 
            this.lblSearching.AutoSize = true;
            this.lblSearching.Location = new System.Drawing.Point(394, 184);
            this.lblSearching.Name = "lblSearching";
            this.lblSearching.Size = new System.Drawing.Size(59, 15);
            this.lblSearching.TabIndex = 15;
            this.lblSearching.Text = "Searching";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(539, 19);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(144, 15);
            this.lblInstructions.TabIndex = 14;
            this.lblInstructions.Text = "Drag and drop the author.";
            // 
            // lstSelectedAuthors
            // 
            this.lstSelectedAuthors.AllowDrop = true;
            this.lstSelectedAuthors.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstSelectedAuthors.FormattingEnabled = true;
            this.lstSelectedAuthors.ItemHeight = 17;
            this.lstSelectedAuthors.Location = new System.Drawing.Point(539, 40);
            this.lstSelectedAuthors.Name = "lstSelectedAuthors";
            this.lstSelectedAuthors.Size = new System.Drawing.Size(213, 140);
            this.lstSelectedAuthors.TabIndex = 13;
            this.lstSelectedAuthors.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstAll_DragDrop);
            this.lstSelectedAuthors.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstAll_DragEnter);
            this.lstSelectedAuthors.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstAll_MouseDown);
            // 
            // lstAuthors
            // 
            this.lstAuthors.AllowDrop = true;
            this.lstAuthors.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstAuthors.FormattingEnabled = true;
            this.lstAuthors.ItemHeight = 17;
            this.lstAuthors.Location = new System.Drawing.Point(320, 41);
            this.lstAuthors.Name = "lstAuthors";
            this.lstAuthors.Size = new System.Drawing.Size(213, 140);
            this.lstAuthors.TabIndex = 12;
            this.lstAuthors.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstAll_DragDrop);
            this.lstAuthors.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstAll_DragEnter);
            this.lstAuthors.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstAll_MouseDown);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(394, 12);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.PlaceholderText = "Search by author\'s name";
            this.txtAuthor.Size = new System.Drawing.Size(139, 23);
            this.txtAuthor.TabIndex = 11;
            this.txtAuthor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAuthor_KeyUp);
            // 
            // lblAuthors
            // 
            this.lblAuthors.AutoSize = true;
            this.lblAuthors.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAuthors.Location = new System.Drawing.Point(320, 10);
            this.lblAuthors.Name = "lblAuthors";
            this.lblAuthors.Size = new System.Drawing.Size(68, 21);
            this.lblAuthors.TabIndex = 10;
            this.lblAuthors.Text = "Authors:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(110, 98);
            this.txtDescription.MaxLength = 300;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "Write the description of the book";
            this.txtDescription.Size = new System.Drawing.Size(194, 188);
            this.txtDescription.TabIndex = 9;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(12, 96);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(92, 21);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Description:";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(110, 40);
            this.txtIsbn.MaxLength = 13;
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(100, 23);
            this.txtIsbn.TabIndex = 2;
            this.txtIsbn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIsbn_KeyPress);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(110, 69);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PlaceholderText = "Write the book\'s title";
            this.txtTitle.Size = new System.Drawing.Size(194, 23);
            this.txtTitle.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(62, 67);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(42, 21);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Title:";
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIsbn.Location = new System.Drawing.Point(57, 38);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(47, 21);
            this.lblIsbn.TabIndex = 5;
            this.lblIsbn.Text = "ISBN:";
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(110, 11);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 23);
            this.txtCode.TabIndex = 1;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCode.Location = new System.Drawing.Point(55, 9);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(49, 21);
            this.lblCode.TabIndex = 3;
            this.lblCode.Text = "Code:";
            // 
            // frmBookRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 303);
            this.Controls.Add(this.pnlMain);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(785, 342);
            this.MinimumSize = new System.Drawing.Size(785, 342);
            this.Name = "frmBookRegistration";
            this.Text = "Book Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBookRegistration_FormClosing);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlMain;
        private TextBox txtCode;
        private Label lblCode;
        private Label lblIsbn;
        private TextBox txtTitle;
        private Label lblTitle;
        private TextBox txtIsbn;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblAuthors;
        private Label lblSelectedAuthors;
        private Label lblSearching;
        private Label lblInstructions;
        private ListBox lstSelectedAuthors;
        private ListBox lstAuthors;
        private TextBox txtAuthor;
        private Label lblPublisher;
        private ComboBox cmbPublishers;
        private Label lblPublication;
        private DateTimePicker dtpPublication;
        private NumericUpDown nudEdition;
        private Label lblEdition;
        private NumericUpDown nudPages;
        private Label lblPages;
        private CheckBox chkRelease;
        private Button btnRegister;
    }
}