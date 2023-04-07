using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToCountLogisticFee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnOK1_Click(object sender, EventArgs e)
        {
            //ToLower to make sure that all the user type will be lowercase
            string productType = txtBox_Type.Text.ToLower();

            double productWeight = double.Parse(txtBox_Weight.Text);

            double baseCost = (productType == "electronic" || productType == "電子" ||productType == "elektronik")  ? 50.0 : 10.0;

            double fee = 0.0;
            if (productWeight < 1.0)
            {
                fee = 30.0;
            }
            else if (productWeight >= 1.0 && productWeight <= 5.0)
            {
                fee = 50.0;
            }
            else if (productWeight > 5.0)
            {
                fee = 70.0;
            }
            fee += baseCost;
            //this to show the productType in lblResult Text
            //lblResult.Text = "Logistic Fee: NTD " + fee.ToString();

            //{0} probably to show productType and {1} probably to show fee

            lblResult.Text = string.Format("Logistic Fee for {0}: NTD {1}", productType, fee.ToString());


        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtBox_Type_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_Weight_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

    }
}
