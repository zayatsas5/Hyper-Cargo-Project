using System;
using System.Windows.Forms;
using HyperCargoProject.UsersControl;
using HyperCargoProject.Classes;

namespace HyperCargoProject.Forms
{
    public partial class PaymentForm : Form
    {
        // сумма которая приходит из той формы
        int SummPay = 0;

        public PaymentForm(int CashSumm)
        {
            InitializeComponent();
            lblPayment.Text = $"К оплате: {Convert.ToString(CashSumm)}";
            SummPay = CashSumm;
        }

        private void btnPaymentRub_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxSummPay.Text) || string.IsNullOrEmpty(tbxSummPay.Text))
            {
                MessageBox.Show("Введите сумму для оплаты!");
            }
            else if (SummPay > Convert.ToInt32(tbxSummPay.Text) && (Convert.ToInt32(tbxSummPay.Text) > Convert.ToInt32(ucPersonalAccount.Cash)))
            {
                MessageBox.Show("Ваша сумма меньше, чем указанная!");
            }
            else if ((SummPay < ucPersonalAccount.Cash) &&(SummPay < Convert.ToInt32(tbxSummPay.Text)))
            {
                // расчет сдачи
                int Change = ucPersonalAccount.Cash - SummPay;
                MessageBox.Show($"Ваша сдача: {Change}");
                lblPayment.Text = "Оплачено";
                ucPersonalAccount.Cash = Change;
                tbxSummPay.Enabled = true;
                btnPaymentRub.Enabled = true;
                btnPaymentRub.Enabled = false;
                tbxSummPay.Clear();
                SummPay = 0;
                ucCalculatonCargo.Result = 0;
                Document.CreateDirectory();
            }
            else if(SummPay >Convert.ToInt32(tbxSummPay.Text))
            {
                MessageBox.Show("Введенная сумма не достаточна для оплаты!");
            }
            else if (SummPay > ucPersonalAccount.Cash)
            {
                MessageBox.Show("На вашем счете недостаточно денег!");
            }
        }
    }
}    

