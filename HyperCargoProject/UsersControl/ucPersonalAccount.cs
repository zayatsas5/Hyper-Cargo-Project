using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using HyperCargoProject.DBConnection;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace HyperCargoProject.UsersControl
{
    public partial class ucPersonalAccount : UserControl
    {
        public ucPersonalAccount()
        {
            InitializeComponent();
        }

        public static string Login { get; set; }
        public static string Password { get; set; }
        public static string Email { get; set; }
        public static string FirstName { get; set; }
        public static string SecondName { get; set; }
        public static string LastName { get; set; }
        // деньги на аккаунте
        public static int Cash { get; set; }

        private void ucPersonalAccount_Load(object sender, EventArgs e)
        {
            lblLoginName.Text = Login;
            tbxPassword.Text = Password;
            lblEmailName.Text = Email;
            tbxSurname.Text = FirstName;
            tbxName.Text = SecondName;
            tbxLastName.Text = LastName;
            lblCash.Text = $"{Convert.ToString(Cash)} рублей";
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPassword.Text) || string.IsNullOrWhiteSpace(tbxPassword.Text))
            {
                MessageBox.Show("Не введен пароль!");
            }
            else if(string.IsNullOrEmpty(tbxSurname.Text) || string.IsNullOrWhiteSpace(tbxSurname.Text))
            {
                MessageBox.Show("Не введена фамилия!");
            }
            else if (string.IsNullOrEmpty(tbxName.Text) || string.IsNullOrWhiteSpace(tbxName.Text))
            {
                MessageBox.Show("Не введено имя!");
            }
            else if (string.IsNullOrEmpty(tbxLastName.Text) || string.IsNullOrWhiteSpace(tbxLastName.Text))
            {
                MessageBox.Show("Не введено отчество!");
            }
            else
            {
                if (string.IsNullOrEmpty(tbxCash.Text))
                {
                    tbxCash.Text = tbxCash.Text;
                }
                else
                {
                    DBConnection.DBConnection.UpdateUserPersonalData(lblLoginName.Text, tbxPassword.Text, tbxSurname.Text, tbxName.Text, tbxLastName.Text, tbxCash.Text);
                    lblCash.Text = $"{Convert.ToString(Cash)} рублей";
                    tbxCash.Clear();
                }
            }
        }

        private void ucPersonalAccount_MouseLeave(object sender, EventArgs e)
        {
            lblCash.Text = $"{Convert.ToString(Cash)} рублей";
        }
    }
}
