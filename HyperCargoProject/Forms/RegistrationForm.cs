using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HyperCargoProject.Forms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        readonly string pattern = @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$";

        private void linklblReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxLoginReg.Text) || string.IsNullOrWhiteSpace(tbxLoginReg.Text))
            {
                MessageBox.Show("Проверьте правильность логина!");
            }
            else if (string.IsNullOrEmpty(tbxPasswordReg.Text) || string.IsNullOrWhiteSpace(tbxPasswordReg.Text))
            {
                MessageBox.Show("Проверьте правильность пароля!");
            }
            else if (string.IsNullOrEmpty(tbxEmailReg.Text) || string.IsNullOrWhiteSpace(tbxEmailReg.Text))
            {
                MessageBox.Show("Проверьте правильность email!");
            }
            else
            {
                if (Regex.IsMatch(tbxEmailReg.Text, pattern))
                {
                    errorProvEmail.Clear();
                    DBConnection.DBConnection.CheckLoginEmail(tbxLoginReg.Text, tbxPasswordReg.Text, tbxEmailReg.Text);
                    tbxLoginReg.Clear();
                    tbxPasswordReg.Clear();
                    tbxEmailReg.Clear();
                }
                else
                {
                    errorProvEmail.SetError(this.tbxEmailReg, "Пример: alexsonz@yandex.ru");
                    return;
                }
            }
        }

        private void tbxLoginReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == '.' || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbxPasswordReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == '.' || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbxEmailReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == '@' || e.KeyChar == '.' || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
