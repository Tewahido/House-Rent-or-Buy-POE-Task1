
namespace House_Rent_or_Buy_POE_Task1
{
    partial class Rent_or_Purchase
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
            this.rentOrPurchaseLbl = new System.Windows.Forms.Label();
            this.rentBtn = new System.Windows.Forms.Button();
            this.purchaseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rentOrPurchaseLbl
            // 
            this.rentOrPurchaseLbl.AutoSize = true;
            this.rentOrPurchaseLbl.Location = new System.Drawing.Point(59, 45);
            this.rentOrPurchaseLbl.Name = "rentOrPurchaseLbl";
            this.rentOrPurchaseLbl.Size = new System.Drawing.Size(238, 15);
            this.rentOrPurchaseLbl.TabIndex = 0;
            this.rentOrPurchaseLbl.Text = "Would you like to rent or purchase a house?";
            // 
            // rentBtn
            // 
            this.rentBtn.Location = new System.Drawing.Point(75, 103);
            this.rentBtn.Name = "rentBtn";
            this.rentBtn.Size = new System.Drawing.Size(75, 23);
            this.rentBtn.TabIndex = 1;
            this.rentBtn.Text = "Rent";
            this.rentBtn.UseVisualStyleBackColor = true;
            this.rentBtn.Click += new System.EventHandler(this.rentBtn_Click);
            // 
            // purchaseBtn
            // 
            this.purchaseBtn.Location = new System.Drawing.Point(202, 103);
            this.purchaseBtn.Name = "purchaseBtn";
            this.purchaseBtn.Size = new System.Drawing.Size(75, 23);
            this.purchaseBtn.TabIndex = 2;
            this.purchaseBtn.Text = "Purchase";
            this.purchaseBtn.UseVisualStyleBackColor = true;
            // 
            // Rent_or_Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 208);
            this.Controls.Add(this.purchaseBtn);
            this.Controls.Add(this.rentBtn);
            this.Controls.Add(this.rentOrPurchaseLbl);
            this.Name = "Rent_or_Purchase";
            this.Text = "Rent or Purchase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rentOrPurchaseLbl;
        private System.Windows.Forms.Button rentBtn;
        private System.Windows.Forms.Button purchaseBtn;
    }
}