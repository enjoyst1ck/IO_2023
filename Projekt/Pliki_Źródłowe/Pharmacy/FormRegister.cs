using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class FormRegister : Form
    {
        private DatabaseConnection conn = new DatabaseConnection();

        public FormRegister()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;

            string loginFromDB = conn.GetLoginValue(login);

            if (loginFromDB.Length == 0)
            {
                if (login.Length > 0 && password.Length > 0)
                {
                    conn.InsertData(login, password);
                    MessageBox.Show("Dodano użytkownika.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Uzupełnij dane.");
                }
            }
            else
            {
                MessageBox.Show("Użytkownik o takim loginie już istnieje w bazie danych.");
            }
        }
    }
}
