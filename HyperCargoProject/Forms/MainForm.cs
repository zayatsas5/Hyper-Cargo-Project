using System;
using System.Windows.Forms;

namespace HyperCargoProject.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnPersonalAccount_Click(object sender, EventArgs e)
        {
            ucPersonalAccount1.BringToFront();
        }

        private void btnCalcCargo_Click(object sender, EventArgs e)
        {
            ucCalculatonCargo1.BringToFront();
        }

        private void btnCargoHistory_Click(object sender, EventArgs e)
        {
            ucCargoHistory1.BringToFront();
            MessageBox.Show("В разработке");
        }
    }
}
