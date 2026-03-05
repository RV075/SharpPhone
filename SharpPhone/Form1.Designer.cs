namespace SharpPhone
{
    partial class frmMain
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
            btnAddPhone = new Button();
            btnModify = new Button();
            btnDelete = new Button();
            listPhones = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAddPhone
            // 
            btnAddPhone.Location = new Point(420, 30);
            btnAddPhone.Name = "btnAddPhone";
            btnAddPhone.Size = new Size(100, 29);
            btnAddPhone.TabIndex = 0;
            btnAddPhone.Text = "+";
            btnAddPhone.UseVisualStyleBackColor = true;
            btnAddPhone.Click += btnAddPhone_Click;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(420, 65);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(100, 29);
            btnModify.TabIndex = 1;
            btnModify.Text = "Aanpassen";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(420, 100);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Verwijderen";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // listPhones
            // 
            listPhones.FormattingEnabled = true;
            listPhones.Location = new Point(12, 30);
            listPhones.Name = "listPhones";
            listPhones.Size = new Size(402, 404);
            listPhones.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 453);
            Controls.Add(label1);
            Controls.Add(listPhones);
            Controls.Add(btnDelete);
            Controls.Add(btnModify);
            Controls.Add(btnAddPhone);
            Name = "frmMain";
            Text = "SoundSharp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddPhone;
        private Button btnModify;
        private Button btnDelete;
        private ListBox listPhones;
        private Label label1;
    }
}
