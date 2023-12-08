using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payments
{
   
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private int Calc(int FirmTime ,int RepTime, int EmbTime)
        {
            int FirmCost = 10;
            int RepCost = 20;
            int EmbCost = 30;
            int val;
           val = (FirmTime * FirmCost) + (RepTime * RepCost) + (EmbTime * EmbCost);
           return val;
        }
        
        private void CalBtn_Click(object sender, EventArgs e)
        {
            float money = 0;
            if (string.IsNullOrEmpty(FirmTmTxBox.Text))
                FirmTmTxBox.Text = "0";
            if (string.IsNullOrEmpty(RepTmTxBox.Text))
                RepTmTxBox.Text = "0";
            if (string.IsNullOrEmpty(EmbTmTxBox.Text))
                EmbTmTxBox.Text = "0";
            try
            {
                 money = Calc(int.Parse(FirmTmTxBox.Text), int.Parse(RepTmTxBox.Text), int.Parse(EmbTmTxBox.Text));
            }
            catch
            {
                MessageBox.Show("Please enter time");
                return;
            }
            if (OutChBox.Checked)
            money = money + 10;
            string mn = Convert.ToString(money);
            PrcValLbl.Text = mn + "€";
        }

        private void RepTmTxBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EmbLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
