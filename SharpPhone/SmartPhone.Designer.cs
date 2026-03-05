namespace SharpPhone
{
    partial class SmartPhone
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
            lblMerk = new Label();
            lblModel = new Label();
            lblPrijs = new Label();
            lblGrootte = new Label();
            lblVoorraad = new Label();
            btnOk = new Button();
            btnCancel = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // lblMerk
            // 
            lblMerk.AutoSize = true;
            lblMerk.Location = new Point(12, 30);
            lblMerk.Name = "lblMerk";
            lblMerk.Size = new Size(42, 20);
            lblMerk.TabIndex = 0;
            lblMerk.Text = "Merk";
            lblMerk.Click += label1_Click;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(12, 87);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(52, 20);
            lblModel.TabIndex = 1;
            lblModel.Text = "Model";
            // 
            // lblPrijs
            // 
            lblPrijs.AutoSize = true;
            lblPrijs.Location = new Point(12, 148);
            lblPrijs.Name = "lblPrijs";
            lblPrijs.Size = new Size(36, 20);
            lblPrijs.TabIndex = 2;
            lblPrijs.Text = "Prijs";
            // 
            // lblGrootte
            // 
            lblGrootte.AutoSize = true;
            lblGrootte.Location = new Point(12, 208);
            lblGrootte.Name = "lblGrootte";
            lblGrootte.Size = new Size(96, 20);
            lblGrootte.TabIndex = 3;
            lblGrootte.Text = "Grootte (MB)";
            // 
            // lblVoorraad
            // 
            lblVoorraad.AutoSize = true;
            lblVoorraad.Location = new Point(12, 270);
            lblVoorraad.Name = "lblVoorraad";
            lblVoorraad.Size = new Size(70, 20);
            lblVoorraad.TabIndex = 4;
            lblVoorraad.Text = "Voorraad";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(270, 337);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(125, 29);
            btnOk.TabIndex = 5;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 337);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 29);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 267);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "0";
            textBox1.Size = new Size(269, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(126, 205);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(269, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(126, 145);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(269, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(126, 84);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(269, 27);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(126, 27);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(269, 27);
            textBox5.TabIndex = 11;
            // 
            // SmartPhone
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 378);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(lblVoorraad);
            Controls.Add(lblGrootte);
            Controls.Add(lblPrijs);
            Controls.Add(lblModel);
            Controls.Add(lblMerk);
            Name = "SmartPhone";
            Text = "SmartPhone";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMerk;
        private Label lblModel;
        private Label lblPrijs;
        private Label lblGrootte;
        private Label lblVoorraad;
        private Button btnOk;
        private Button btnCancel;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}