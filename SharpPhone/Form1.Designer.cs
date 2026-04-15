namespace SharpPhone
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
            btnAddPhone = new Button();
            btnAanpassen = new Button();
            btnVerwijderen = new Button();
            listBoxPhones = new ListBox();
            lblVoorraad = new Label();
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
            // btnAanpassen
            // 
            btnAanpassen.Location = new Point(420, 65);
            btnAanpassen.Name = "btnAanpassen";
            btnAanpassen.Size = new Size(100, 29);
            btnAanpassen.TabIndex = 1;
            btnAanpassen.Text = "Aanpassen";
            btnAanpassen.UseVisualStyleBackColor = true;
            btnAanpassen.Click += btnModify_Click;
            // 
            // btnVerwijderen
            // 
            btnVerwijderen.Location = new Point(420, 100);
            btnVerwijderen.Name = "btnVerwijderen";
            btnVerwijderen.Size = new Size(100, 29);
            btnVerwijderen.TabIndex = 2;
            btnVerwijderen.Text = "Verwijderen";
            btnVerwijderen.UseVisualStyleBackColor = true;
            btnVerwijderen.Click += btnDelete_Click;
            // 
            // listBoxPhones
            // 
            listBoxPhones.FormattingEnabled = true;
            listBoxPhones.Location = new Point(12, 30);
            listBoxPhones.Name = "listBoxPhones";
            listBoxPhones.Size = new Size(402, 404);
            listBoxPhones.TabIndex = 3;
            // 
            // lblVoorraad
            // 
            lblVoorraad.AutoSize = true;
            lblVoorraad.Location = new Point(12, 9);
            lblVoorraad.Name = "lblVoorraad";
            lblVoorraad.Size = new Size(70, 20);
            lblVoorraad.TabIndex = 0;
            lblVoorraad.Text = "Voorraad";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 453);
            Controls.Add(lblVoorraad);
            Controls.Add(listBoxPhones);
            Controls.Add(btnVerwijderen);
            Controls.Add(btnAanpassen);
            Controls.Add(btnAddPhone);
            Name = "Form1";
            Text = "SoundSharp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddPhone;
        private Button btnAanpassen;
        private Button btnVerwijderen;
        private ListBox listBoxPhones;
        private Label lblVoorraad;
    }
}
