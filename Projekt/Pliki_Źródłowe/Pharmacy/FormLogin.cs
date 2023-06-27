using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class FormLogin : Form
    {
        public bool isLogged = false;


        public int id;
        public string login;
        private string password;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            login = loginTextBox.Text;
            password = passwordTextBox.Text;

            if (login.Length > 0 && password.Length > 0)
            {
                DatabaseConnection conn = new DatabaseConnection();
                if (conn != null)
                {
                    conn.OpenConnection();
                    string loginFromDB = conn.GetLoginValue(login);
                    conn.CloseConnection();
                    if (loginFromDB.Length == 0)
                    {
                        MessageBox.Show("Brak takiego uzytkownika w bazie.");
                    }
                    else
                    {
                        conn.OpenConnection();
                        string passwordFromDB = conn.GetPasswordValue(login);
                        conn.CloseConnection();
                        if (passwordFromDB == password)
                        {
                            isLogged = true;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Błędne hasło.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Uzupełnij dane do logowania.");
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister registerWindow = new FormRegister();
            registerWindow.FormClosed += registerWindow_FormClosed;
            registerWindow.ShowDialog();
        }

        private void registerWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
