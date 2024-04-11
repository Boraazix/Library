namespace Library
{
    partial class frmBookReport
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
            dgvMain = new DataGridView();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(dgvMain);
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1090, 500);
            pnlMain.TabIndex = 0;
            // 
            // dgvMain
            // 
            dgvMain.AllowUserToAddRows = false;
            dgvMain.AllowUserToDeleteRows = false;
            dgvMain.AllowUserToOrderColumns = true;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.Location = new Point(12, 12);
            dgvMain.Name = "dgvMain";
            dgvMain.ReadOnly = true;
            dgvMain.RowTemplate.Height = 25;
            dgvMain.Size = new Size(1066, 476);
            dgvMain.TabIndex = 0;
            // 
            // frmBookReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 500);
            Controls.Add(pnlMain);
            MaximizeBox = false;
            MaximumSize = new Size(1106, 539);
            MinimumSize = new Size(1106, 539);
            Name = "frmBookReport";
            Text = "Book Report";
            pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private DataGridView dgvMain;
    }
}