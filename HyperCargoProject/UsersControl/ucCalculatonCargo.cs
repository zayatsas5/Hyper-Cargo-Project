using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HyperCargoProject.Classes;
using HyperCargoProject.Forms;

namespace HyperCargoProject.UsersControl
{
    public partial class ucCalculatonCargo : UserControl
    {
        public ucCalculatonCargo()
        {
            InitializeComponent();
        }

        // к оплате
        public static int Result { get; set; }

        private void btnCalculationCargo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxLength.Text) || string.IsNullOrWhiteSpace(tbxLength.Text))
            {
                MessageBox.Show("Не введена длина");
            }
            else if (string.IsNullOrWhiteSpace(tbxWidth.Text) || string.IsNullOrEmpty(tbxWidth.Text))
            {
                MessageBox.Show("Не введена ширина");
            }
            else if (string.IsNullOrEmpty(tbxHeight.Text) || string.IsNullOrWhiteSpace(tbxHeight.Text))
            {
                MessageBox.Show("Не введена высота");
            }
            else if (string.IsNullOrEmpty(tbxFrom.Text) || string.IsNullOrWhiteSpace(tbxFrom.Text))
            {
                MessageBox.Show("Не введена точка отправления");
            }
            else if (string.IsNullOrEmpty(tbxTo.Text) || string.IsNullOrWhiteSpace(tbxTo.Text))
            {
                MessageBox.Show("Не введена точка прибытия");
            }
            else
            {
                int Lenght = Convert.ToInt32(tbxLength.Text);
                int Width = Convert.ToInt32(tbxWidth.Text);
                int Height = Convert.ToInt32(tbxHeight.Text);
                if (Lenght > 12)
                {
                    MessageBox.Show("Длина должна быть не более 12 м");
                }
                else if (Width > 3)
                {
                    MessageBox.Show("Ширина должна быть не более 3 м");
                }
                else if (Height > 3)
                {
                    MessageBox.Show("Высота должна быть не более 3 м");
                }
                else
                {
                    CalculationCargo.FindCity(Lenght, Width, Height, tbxFrom.Text, tbxTo.Text);
                    tbxLength.Clear();
                    tbxHeight.Clear();
                    tbxWidth.Clear();
                    tbxFrom.Clear();
                    tbxTo.Clear();
                    lblPrice.Visible = true;
                    btnPayment.Visible = true;
                    lblPrice.Text = $"К оплате: {Convert.ToString(Result)}";
                }
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            PaymentForm paymentForm = new PaymentForm(Result);
            paymentForm.ShowDialog();
        }

        private void ucCalculatonCargo_Load(object sender, EventArgs e)
        {
            lblCashPersAcc.Text = $"У вас на счету: {ucPersonalAccount.Cash}";
        }

        private void ucCalculatonCargo_MouseLeave(object sender, EventArgs e)
        {
            lblCashPersAcc.Text = $"У вас на счету: {ucPersonalAccount.Cash}";
            lblPrice.Text = $"К оплате: {Result}";
            if (Result == 0)
            {
                btnPayment.Enabled = false;
            }
            else
            {
                btnPayment.Enabled = true;
            }
        }
    }
}
