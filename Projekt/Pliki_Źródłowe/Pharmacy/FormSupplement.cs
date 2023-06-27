using MySql.Data.MySqlClient;
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
    public partial class FormSupplement : Form
    {
        public string login;

        DatabaseConnection conn = new DatabaseConnection();

        public FormSupplement(string login)
        {
            InitializeComponent();
            this.login = login;
        }

        public void addSupplementButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            decimal price = priceNumericUpDown.Value;
            string description = descriptionTextBox.Text;
            string type = typeComboBox.Text;
            string activeSubstance = activeSubstanceTextBox.Text;

            try
            {
                if (name.Length > 0 && price > 0 && description.Length > 0 && type.Length > 0 && activeSubstance.Length > 0)
                {
                    conn.OpenConnection();
                    int user_id = Convert.ToInt32(conn.GetIdValue(login));
                    conn.CloseConnection();
                    Supplement sup = new Supplement(name, price, description, type, activeSubstance, user_id);
                    conn.InsertData(sup);
                    ClearData();
                    listBoxSupplement.Items.Clear();  //wyczyszczenie listBoxa
                    sup.Write(listBoxSupplement);
                }
                else
                {
                    MessageBox.Show("Uzupełnij pola danymi");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Wystąpił wyjątek: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił wyjątek: " + ex.Message);
            }
            finally
            {
                MessageBox.Show("Dodano Suplement do bazy danych!.");
            }
        }

        private void ClearData()
        {
            nameTextBox.Text = "";
            priceNumericUpDown.Value = 0;
            descriptionTextBox.Text = "";
            //typeComboBox.Items.;
            activeSubstanceTextBox.Text = "";
        }
    }
}
