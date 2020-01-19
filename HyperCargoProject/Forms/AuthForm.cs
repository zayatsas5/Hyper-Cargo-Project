using System;
using System.Windows.Forms;

namespace HyperCargoProject.Forms
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void linklblAuth_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxLoginAuth.Text) || string.IsNullOrWhiteSpace(tbxLoginAuth.Text))
            {
                MessageBox.Show("Проверьте правильность логина!");
            }
            else if (string.IsNullOrEmpty(tbxPasswordAuth.Text) || string.IsNullOrWhiteSpace(tbxPasswordAuth.Text))
            {
                MessageBox.Show("Проверьте правильность пароля!");
            }
            else
            {
                    DBConnection.DBConnection.CheckLogin(tbxLoginAuth.Text, tbxPasswordAuth.Text);
                    tbxLoginAuth.Clear();
                    tbxPasswordAuth.Clear();
            }
        }

        private void tbxLoginAuth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == '@' || e.KeyChar == '.' || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbxPasswordAuth_KeyPress(object sender, KeyPressEventArgs e)
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
