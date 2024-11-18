namespace BinaryTree
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInput = new TextBox();
            label1 = new Label();
            btnInsert = new Button();
            btnDelete = new Button();
            lblResult = new Label();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Segoe UI", 15F);
            txtInput.Location = new Point(22, 40);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(92, 34);
            txtInput.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(123, 28);
            label1.TabIndex = 1;
            label1.Text = "Enter a value";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(22, 80);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(92, 41);
            btnInsert.TabIndex = 2;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(22, 127);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 41);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 15F);
            lblResult.Location = new Point(38, 213);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 28);
            lblResult.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(22, 174);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(92, 41);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 532);
            Controls.Add(btnSearch);
            Controls.Add(lblResult);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(label1);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Label label1;
        private Button btnInsert;
        private Button btnDelete;
        private Label lblResult;
        private Button btnSearch;
    }
}
