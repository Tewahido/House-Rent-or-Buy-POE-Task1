using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace House_Rent_or_Buy_POE_Task1
{
    public partial class Rent_or_Purchase : Form
    {
        public Rent_or_Purchase()
        {
            InitializeComponent();
        }

        private void rentBtn_Click(object sender, EventArgs e)
        {
            Rent rentorm = new Rent();
            this.Hide();
            rentForm.ShowDialog();
            this.Close();
        }
    }
}
