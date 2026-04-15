namespace SharpPhone
{
    partial class frmAddPhone
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
            txtStock = new TextBox();
            txtSize = new TextBox();
            txtPrice = new TextBox();
            txtModel = new TextBox();
            txtBrand = new TextBox();
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
            // txtStock
            // 
            txtStock.Location = new Point(126, 267);
            txtStock.Name = "txtStock";
            txtStock.PlaceholderText = "0";
            txtStock.Size = new Size(269, 27);
            txtStock.TabIndex = 7;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(126, 205);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(269, 27);
            txtSize.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(126, 145);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(269, 27);
            txtPrice.TabIndex = 9;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(126, 84);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(269, 27);
            txtModel.TabIndex = 10;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(126, 27);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(269, 27);
            txtBrand.TabIndex = 11;
            // 
            // frmAddPhone
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 378);
            Controls.Add(txtBrand);
            Controls.Add(txtModel);
            Controls.Add(txtPrice);
            Controls.Add(txtSize);
            Controls.Add(txtStock);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(lblVoorraad);
            Controls.Add(lblGrootte);
            Controls.Add(lblPrijs);
            Controls.Add(lblModel);
            Controls.Add(lblMerk);
            Name = "frmAddPhone";
            Text = "SmartPhone";
            Load += frmAddPhone_Load;
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
        private TextBox txtStock;
        private TextBox txtSize;
        private TextBox txtPrice;
        private TextBox txtModel;
        private TextBox txtBrand;
    }
}