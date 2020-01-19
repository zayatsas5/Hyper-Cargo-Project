using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using HyperCargoProject.UsersControl;
using HyperCargoProject.Forms;

namespace HyperCargoProject.DBConnection
{
    static class DBConnection
    {

        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Clients.mdf;Integrated Security=True";
        private static SqlConnection sqlConnection = new SqlConnection(connectionString);
        static SqlDataReader sqlDataReader;

        public static void CheckLogin(string Login, string Password)
        {
            string queryCheckLogin = $"SELECT * FROM Clients WHERE user_login = '{Login}' AND user_password = '{Password}'";
            try
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
                sqlConnection.Open();
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryCheckLogin, sqlConnection))
                {
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    if (dataTable.Rows.Count == 1)
                    {
                        MainForm mainForm = new MainForm();
                        GetUserData(Login, Password);
                        mainForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Проверьте правильность логина или пароля!");
                    }
                }
                sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

        public static void GetUserData(string Login, string Password)
        {
            string queryCheckLogin = $"SELECT * FROM Clients WHERE user_login = '{Login}' AND user_password = '{Password}'";
            try
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
                sqlConnection.Open();
                SqlCommand commReadData = new SqlCommand(queryCheckLogin, sqlConnection);
                sqlDataReader = commReadData.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    ucPersonalAccount.Login = sqlDataReader[0].ToString();
                    ucPersonalAccount.Password = sqlDataReader[1].ToString();
                    ucPersonalAccount.Email = sqlDataReader[2].ToString();
                    ucPersonalAccount.FirstName = sqlDataReader[3].ToString();
                    ucPersonalAccount.SecondName = sqlDataReader[4].ToString();
                    ucPersonalAccount.LastName = sqlDataReader[5].ToString();
                    ucPersonalAccount.Cash = Convert.ToInt32(sqlDataReader[6].ToString());
                }
                sqlDataReader.Close();
                sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

        private static void CreateUser(string Login, string Password, string Email)
        {
            string queryCheckLogin = $"INSERT INTO Clients (user_login, user_password, user_email, user_cash) VALUES ('{Login}', '{Password}', '{Email}', '0')";

            try
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
                sqlConnection.Open();
                using (SqlCommand commCreateUser = new SqlCommand(queryCheckLogin, sqlConnection))
                {
                    commCreateUser.ExecuteNonQuery();
                    MessageBox.Show("Пользователь успешно добавлен!");
                }
                sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

        public static void CheckLoginEmail(string Login, string Password, string Email)
        {
            string queryCheckLogin = $"SELECT user_login, user_email FROM Clients WHERE user_login = '{Login}' OR user_email = '{Email}'";

            try
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
                sqlConnection.Open();
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryCheckLogin, sqlConnection))
                {
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 0)
                    {
                        CreateUser(Login, Password, Email);
                    }
                    else
                    {
                        MessageBox.Show("Такой пользователь уже существует!");
                    }
                }
                sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

        public static void UpdateUserPersonalData(string Login, string Password, string FirstName, string SecondName, string LastName, string Cash)
        {
            try
            {
                string queryUpdateUserData = $"UPDATE Clients SET user_password = '{Password}', user_firstname=N'{FirstName}', user_secondname=N'{SecondName}', user_lastname=N'{LastName}', user_cash = '{Cash}' WHERE user_login='{Login}'";

                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
                sqlConnection.Open();
                using (SqlCommand commUpdateUserData = new SqlCommand(queryUpdateUserData, sqlConnection))
                {
                    commUpdateUserData.ExecuteNonQuery();
                    GetUserData(Login, Password);
                }
                sqlConnection.Close();
                MessageBox.Show("Ваши данные были успешно обновлены!");
            }
            catch (SqlException exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
