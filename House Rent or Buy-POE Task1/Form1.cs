using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Rent_or_Buy_POE_Task1
{
    public partial class homeForm : Form
    {
        public homeForm()
        {
            InitializeComponent();
        }

        public class Expense {
            private int tax;
            private int groceries;
            private int waterLights;
            private int travel;
            private int cell;
            private int otherExpenses;
            private int rent;
            private int monthlyLoan;

            internal int Tax { get => tax; set => tax = value; }
            internal int Groceries { get => groceries; set => groceries = value; }
            internal int WaterLights { get => waterLights; set => waterLights = value; }
            internal int Travel { get => travel; set => travel = value; }
            internal int Cell { get => cell; set => cell = value; }
            internal int OtherExpenses { get => otherExpenses; set => otherExpenses = value; }
            internal int Rent { get => rent; set => rent = value; }
            internal int MonthlyLoan { get => monthlyLoan; set => monthlyLoan = value; }

            public Expense() { }

            public Expense(int tax, int groceries, int waterLights, int travel, int cell, int otherExpenses, int rent, int monthlyLoan)
            {
                this.tax = tax;
                this.groceries = groceries;
                this.waterLights = waterLights;
                this.travel = travel;
                this.cell = cell;
                this.otherExpenses = otherExpenses;
                this.rent = rent;
                this.monthlyLoan = monthlyLoan;
            }
        }
        private void confirmBtn_Click(object sender, EventArgs e)
        { int grossIncome;
            Expense exp = new Expense();
            grossIncome =  Convert.ToInt32(grossIncomeTxt.Text);
            exp.Tax = Convert.ToInt32(taxLbl.Text);
            exp.Groceries = Convert.ToInt32(groceriesLbl.Text);
            exp.WaterLights = Convert.ToInt32(waterLightsLbl.Text);
            exp.Travel = Convert.ToInt32(travelLbl.Text);
            exp.Cell = Convert.ToInt32(cellLbl.Text);
            exp.OtherExpenses = Convert.ToInt32(otherExpTxt.Text);
            Rent_or_Purchase rentForm = new Rent_or_Purchase();
            this.Hide();
            rentForm.ShowDialog();
            this.Close();


        }
    }
}
