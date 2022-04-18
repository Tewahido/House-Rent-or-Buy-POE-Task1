
namespace House_Rent_or_Buy_POE_Task1
{
    partial class homeForm
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
            this.grossIncomeTxt = new System.Windows.Forms.TextBox();
            this.taxTxt = new System.Windows.Forms.TextBox();
            this.groceryTxt = new System.Windows.Forms.TextBox();
            this.waterLightTxt = new System.Windows.Forms.TextBox();
            this.travelTxt = new System.Windows.Forms.TextBox();
            this.cellTxt = new System.Windows.Forms.TextBox();
            this.otherExpTxt = new System.Windows.Forms.TextBox();
            this.incLbl = new System.Windows.Forms.Label();
            this.taxLbl = new System.Windows.Forms.Label();
            this.groceriesLbl = new System.Windows.Forms.Label();
            this.waterLightsLbl = new System.Windows.Forms.Label();
            this.travelLbl = new System.Windows.Forms.Label();
            this.cellLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.headingLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // grossIncomeTxt
            // 
            this.grossIncomeTxt.Location = new System.Drawing.Point(229, 73);
            this.grossIncomeTxt.Name = "grossIncomeTxt";
            this.grossIncomeTxt.Size = new System.Drawing.Size(116, 23);
            this.grossIncomeTxt.TabIndex = 0;
            // 
            // taxTxt
            // 
            this.taxTxt.Location = new System.Drawing.Point(229, 102);
            this.taxTxt.Name = "taxTxt";
            this.taxTxt.Size = new System.Drawing.Size(116, 23);
            this.taxTxt.TabIndex = 1;
            // 
            // groceryTxt
            // 
            this.groceryTxt.Location = new System.Drawing.Point(229, 131);
            this.groceryTxt.Name = "groceryTxt";
            this.groceryTxt.Size = new System.Drawing.Size(116, 23);
            this.groceryTxt.TabIndex = 2;
            // 
            // waterLightTxt
            // 
            this.waterLightTxt.Location = new System.Drawing.Point(229, 160);
            this.waterLightTxt.Name = "waterLightTxt";
            this.waterLightTxt.Size = new System.Drawing.Size(116, 23);
            this.waterLightTxt.TabIndex = 3;
            // 
            // travelTxt
            // 
            this.travelTxt.Location = new System.Drawing.Point(229, 189);
            this.travelTxt.Name = "travelTxt";
            this.travelTxt.Size = new System.Drawing.Size(116, 23);
            this.travelTxt.TabIndex = 4;
            // 
            // cellTxt
            // 
            this.cellTxt.Location = new System.Drawing.Point(229, 218);
            this.cellTxt.Name = "cellTxt";
            this.cellTxt.Size = new System.Drawing.Size(116, 23);
            this.cellTxt.TabIndex = 5;
            // 
            // otherExpTxt
            // 
            this.otherExpTxt.Location = new System.Drawing.Point(229, 247);
            this.otherExpTxt.Name = "otherExpTxt";
            this.otherExpTxt.Size = new System.Drawing.Size(116, 23);
            this.otherExpTxt.TabIndex = 6;
            // 
            // incLbl
            // 
            this.incLbl.AutoSize = true;
            this.incLbl.Location = new System.Drawing.Point(47, 76);
            this.incLbl.Name = "incLbl";
            this.incLbl.Size = new System.Drawing.Size(156, 15);
            this.incLbl.TabIndex = 7;
            this.incLbl.Text = "Enter gross monthly income";
            // 
            // taxLbl
            // 
            this.taxLbl.AutoSize = true;
            this.taxLbl.Location = new System.Drawing.Point(47, 105);
            this.taxLbl.Name = "taxLbl";
            this.taxLbl.Size = new System.Drawing.Size(156, 15);
            this.taxLbl.TabIndex = 8;
            this.taxLbl.Text = "Enter estimated monthly tax";
            // 
            // groceriesLbl
            // 
            this.groceriesLbl.AutoSize = true;
            this.groceriesLbl.Location = new System.Drawing.Point(47, 134);
            this.groceriesLbl.Name = "groceriesLbl";
            this.groceriesLbl.Size = new System.Drawing.Size(171, 15);
            this.groceriesLbl.TabIndex = 9;
            this.groceriesLbl.Text = "Enter total groceries per month";
            // 
            // waterLightsLbl
            // 
            this.waterLightsLbl.AutoSize = true;
            this.waterLightsLbl.Location = new System.Drawing.Point(47, 163);
            this.waterLightsLbl.Name = "waterLightsLbl";
            this.waterLightsLbl.Size = new System.Drawing.Size(173, 15);
            this.waterLightsLbl.TabIndex = 10;
            this.waterLightsLbl.Text = "Enter total water and lights cost";
            // 
            // travelLbl
            // 
            this.travelLbl.AutoSize = true;
            this.travelLbl.Location = new System.Drawing.Point(47, 192);
            this.travelLbl.Name = "travelLbl";
            this.travelLbl.Size = new System.Drawing.Size(171, 15);
            this.travelLbl.TabIndex = 11;
            this.travelLbl.Text = "Enter total travel monthly costs";
            // 
            // cellLbl
            // 
            this.cellLbl.AutoSize = true;
            this.cellLbl.Location = new System.Drawing.Point(47, 221);
            this.cellLbl.Name = "cellLbl";
            this.cellLbl.Size = new System.Drawing.Size(146, 15);
            this.cellLbl.TabIndex = 12;
            this.cellLbl.Text = "Enter total cellphone costs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Enter other expenses total if any";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(251, 314);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 23);
            this.confirmBtn.TabIndex = 14;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // headingLbl
            // 
            this.headingLbl.AutoSize = true;
            this.headingLbl.Location = new System.Drawing.Point(71, 32);
            this.headingLbl.Name = "headingLbl";
            this.headingLbl.Size = new System.Drawing.Size(264, 15);
            this.headingLbl.TabIndex = 15;
            this.headingLbl.Text = "Welcome, please complete this page to continue";
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 356);
            this.Controls.Add(this.headingLbl);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cellLbl);
            this.Controls.Add(this.travelLbl);
            this.Controls.Add(this.waterLightsLbl);
            this.Controls.Add(this.groceriesLbl);
            this.Controls.Add(this.taxLbl);
            this.Controls.Add(this.incLbl);
            this.Controls.Add(this.otherExpTxt);
            this.Controls.Add(this.cellTxt);
            this.Controls.Add(this.travelTxt);
            this.Controls.Add(this.waterLightTxt);
            this.Controls.Add(this.groceryTxt);
            this.Controls.Add(this.taxTxt);
            this.Controls.Add(this.grossIncomeTxt);
            this.Name = "homeForm";
            this.Text = "Income";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox grossIncomeTxt;
        private System.Windows.Forms.TextBox taxTxt;
        private System.Windows.Forms.TextBox groceryTxt;
        private System.Windows.Forms.TextBox waterLightTxt;
        private System.Windows.Forms.TextBox travelTxt;
        private System.Windows.Forms.TextBox cellTxt;
        private System.Windows.Forms.TextBox otherExpTxt;
        private System.Windows.Forms.Label incLbl;
        private System.Windows.Forms.Label taxLbl;
        private System.Windows.Forms.Label groceriesLbl;
        private System.Windows.Forms.Label waterLightsLbl;
        private System.Windows.Forms.Label travelLbl;
        private System.Windows.Forms.Label cellLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label headingLbl;
    }
}

