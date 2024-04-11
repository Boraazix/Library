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
            pnlMain = new Panel();
            grpDetails = new GroupBox();
            lstSelectedAuthors = new ListBox();
            lblAuthors = new Label();
            btnRegister = new Button();
            txtAuthor = new TextBox();
            chkRelease = new CheckBox();
            lstAuthors = new ListBox();
            nudEdition = new NumericUpDown();
            lblInstructions = new Label();
            lblEdition = new Label();
            lblSearching = new Label();
            nudPages = new NumericUpDown();
            lblSelectedAuthors = new Label();
            lblPages = new Label();
            cmbPublishers = new ComboBox();
            dtpPublication = new DateTimePicker();
            lblPublisher = new Label();
            lblPublication = new Label();
            grpMainData = new GroupBox();
            txtCode = new TextBox();
            lblCode = new Label();
            lblIsbn = new Label();
            lblTitle = new Label();
            txtTitle = new TextBox();
            txtIsbn = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            pnlMain.SuspendLayout();
            grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudEdition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPages).BeginInit();
            grpMainData.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(grpDetails);
            pnlMain.Controls.Add(grpMainData);
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(808, 338);
            pnlMain.TabIndex = 0;
            // 
            // grpDetails
            // 
            grpDetails.Controls.Add(lstSelectedAuthors);
            grpDetails.Controls.Add(lblAuthors);
            grpDetails.Controls.Add(btnRegister);
            grpDetails.Controls.Add(txtAuthor);
            grpDetails.Controls.Add(chkRelease);
            grpDetails.Controls.Add(lstAuthors);
            grpDetails.Controls.Add(nudEdition);
            grpDetails.Controls.Add(lblInstructions);
            grpDetails.Controls.Add(lblEdition);
            grpDetails.Controls.Add(lblSearching);
            grpDetails.Controls.Add(nudPages);
            grpDetails.Controls.Add(lblSelectedAuthors);
            grpDetails.Controls.Add(lblPages);
            grpDetails.Controls.Add(cmbPublishers);
            grpDetails.Controls.Add(dtpPublication);
            grpDetails.Controls.Add(lblPublisher);
            grpDetails.Controls.Add(lblPublication);
            grpDetails.Location = new Point(333, 12);
            grpDetails.Name = "grpDetails";
            grpDetails.Size = new Size(463, 315);
            grpDetails.TabIndex = 1;
            grpDetails.TabStop = false;
            grpDetails.Text = "Details";
            // 
            // lstSelectedAuthors
            // 
            lstSelectedAuthors.AllowDrop = true;
            lstSelectedAuthors.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lstSelectedAuthors.FormattingEnabled = true;
            lstSelectedAuthors.ItemHeight = 17;
            lstSelectedAuthors.Location = new Point(234, 49);
            lstSelectedAuthors.Name = "lstSelectedAuthors";
            lstSelectedAuthors.Size = new Size(213, 157);
            lstSelectedAuthors.TabIndex = 13;
            lstSelectedAuthors.DragDrop += lstAll_DragDrop;
            lstSelectedAuthors.DragEnter += lstAll_DragEnter;
            lstSelectedAuthors.MouseDown += lstAll_MouseDown;
            // 
            // lblAuthors
            // 
            lblAuthors.AutoSize = true;
            lblAuthors.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAuthors.Location = new Point(15, 19);
            lblAuthors.Name = "lblAuthors";
            lblAuthors.Size = new Size(68, 21);
            lblAuthors.TabIndex = 10;
            lblAuthors.Text = "Authors:";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(346, 273);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(101, 23);
            btnRegister.TabIndex = 27;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(89, 21);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.PlaceholderText = "Search by author's name";
            txtAuthor.Size = new Size(139, 23);
            txtAuthor.TabIndex = 11;
            txtAuthor.KeyUp += txtAuthor_KeyUp;
            // 
            // chkRelease
            // 
            chkRelease.AutoSize = true;
            chkRelease.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            chkRelease.Location = new Point(346, 244);
            chkRelease.Name = "chkRelease";
            chkRelease.Size = new Size(101, 23);
            chkRelease.TabIndex = 26;
            chkRelease.Text = "New release";
            chkRelease.UseVisualStyleBackColor = true;
            // 
            // lstAuthors
            // 
            lstAuthors.AllowDrop = true;
            lstAuthors.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lstAuthors.FormattingEnabled = true;
            lstAuthors.ItemHeight = 17;
            lstAuthors.Location = new Point(15, 50);
            lstAuthors.Name = "lstAuthors";
            lstAuthors.Size = new Size(213, 157);
            lstAuthors.TabIndex = 12;
            lstAuthors.DragDrop += lstAll_DragDrop;
            lstAuthors.DragEnter += lstAll_DragEnter;
            lstAuthors.MouseDown += lstAll_MouseDown;
            // 
            // nudEdition
            // 
            nudEdition.Location = new Point(282, 272);
            nudEdition.Name = "nudEdition";
            nudEdition.Size = new Size(51, 23);
            nudEdition.TabIndex = 24;
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Location = new Point(234, 28);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(144, 15);
            lblInstructions.TabIndex = 14;
            lblInstructions.Text = "Drag and drop the author.";
            // 
            // lblEdition
            // 
            lblEdition.AutoSize = true;
            lblEdition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEdition.Location = new Point(215, 272);
            lblEdition.Name = "lblEdition";
            lblEdition.Size = new Size(61, 21);
            lblEdition.TabIndex = 23;
            lblEdition.Text = "Edition:";
            // 
            // lblSearching
            // 
            lblSearching.AutoSize = true;
            lblSearching.Location = new Point(89, 210);
            lblSearching.Name = "lblSearching";
            lblSearching.Size = new Size(59, 15);
            lblSearching.TabIndex = 15;
            lblSearching.Text = "Searching";
            // 
            // nudPages
            // 
            nudPages.Location = new Point(282, 243);
            nudPages.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudPages.Name = "nudPages";
            nudPages.Size = new Size(51, 23);
            nudPages.TabIndex = 22;
            // 
            // lblSelectedAuthors
            // 
            lblSelectedAuthors.AutoSize = true;
            lblSelectedAuthors.Location = new Point(284, 210);
            lblSelectedAuthors.Name = "lblSelectedAuthors";
            lblSelectedAuthors.Size = new Size(94, 15);
            lblSelectedAuthors.TabIndex = 16;
            lblSelectedAuthors.Text = "Selected authors";
            // 
            // lblPages
            // 
            lblPages.AutoSize = true;
            lblPages.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPages.Location = new Point(223, 243);
            lblPages.Name = "lblPages";
            lblPages.Size = new Size(53, 21);
            lblPages.TabIndex = 21;
            lblPages.Text = "Pages:";
            // 
            // cmbPublishers
            // 
            cmbPublishers.FormattingEnabled = true;
            cmbPublishers.Location = new Point(107, 242);
            cmbPublishers.Name = "cmbPublishers";
            cmbPublishers.Size = new Size(109, 23);
            cmbPublishers.TabIndex = 17;
            // 
            // dtpPublication
            // 
            dtpPublication.Format = DateTimePickerFormat.Short;
            dtpPublication.Location = new Point(107, 271);
            dtpPublication.Name = "dtpPublication";
            dtpPublication.Size = new Size(78, 23);
            dtpPublication.TabIndex = 20;
            // 
            // lblPublisher
            // 
            lblPublisher.AutoSize = true;
            lblPublisher.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPublisher.Location = new Point(23, 240);
            lblPublisher.Name = "lblPublisher";
            lblPublisher.Size = new Size(78, 21);
            lblPublisher.TabIndex = 18;
            lblPublisher.Text = "Publisher:";
            // 
            // lblPublication
            // 
            lblPublication.AutoSize = true;
            lblPublication.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPublication.Location = new Point(11, 272);
            lblPublication.Name = "lblPublication";
            lblPublication.Size = new Size(90, 21);
            lblPublication.TabIndex = 19;
            lblPublication.Text = "Publication:";
            // 
            // grpMainData
            // 
            grpMainData.Controls.Add(txtCode);
            grpMainData.Controls.Add(lblCode);
            grpMainData.Controls.Add(lblIsbn);
            grpMainData.Controls.Add(lblTitle);
            grpMainData.Controls.Add(txtTitle);
            grpMainData.Controls.Add(txtIsbn);
            grpMainData.Controls.Add(lblDescription);
            grpMainData.Controls.Add(txtDescription);
            grpMainData.Location = new Point(12, 12);
            grpMainData.Name = "grpMainData";
            grpMainData.Size = new Size(315, 315);
            grpMainData.TabIndex = 0;
            grpMainData.TabStop = false;
            grpMainData.Text = "Main data";
            // 
            // txtCode
            // 
            txtCode.Enabled = false;
            txtCode.Location = new Point(105, 21);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(100, 23);
            txtCode.TabIndex = 1;
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCode.Location = new Point(50, 19);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(49, 21);
            lblCode.TabIndex = 3;
            lblCode.Text = "Code:";
            // 
            // lblIsbn
            // 
            lblIsbn.AutoSize = true;
            lblIsbn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblIsbn.Location = new Point(52, 48);
            lblIsbn.Name = "lblIsbn";
            lblIsbn.Size = new Size(47, 21);
            lblIsbn.TabIndex = 5;
            lblIsbn.Text = "ISBN:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(57, 77);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(42, 21);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Title:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(105, 79);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Write the book's title";
            txtTitle.Size = new Size(194, 23);
            txtTitle.TabIndex = 3;
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(105, 50);
            txtIsbn.MaxLength = 13;
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(100, 23);
            txtIsbn.TabIndex = 2;
            txtIsbn.KeyPress += txtIsbn_KeyPress;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.Location = new Point(7, 106);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(92, 21);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(105, 108);
            txtDescription.MaxLength = 300;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Write the description of the book";
            txtDescription.Size = new Size(194, 188);
            txtDescription.TabIndex = 9;
            // 
            // frmBookRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 338);
            Controls.Add(pnlMain);
            MaximizeBox = false;
            MaximumSize = new Size(824, 377);
            MinimumSize = new Size(824, 377);
            Name = "frmBookRegistration";
            Text = "Book Registration";
            FormClosing += frmBookRegistration_FormClosing;
            pnlMain.ResumeLayout(false);
            grpDetails.ResumeLayout(false);
            grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudEdition).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPages).EndInit();
            grpMainData.ResumeLayout(false);
            grpMainData.PerformLayout();
            ResumeLayout(false);
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
        private GroupBox grpMainData;
        private GroupBox grpDetails;
    }
}