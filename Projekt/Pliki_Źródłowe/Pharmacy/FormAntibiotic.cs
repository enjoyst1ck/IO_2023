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
    public partial class FormAntibiotic : Form
    {
        public string login;

        DatabaseConnection conn = new DatabaseConnection();

        public FormAntibiotic(string login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void addAntibioticButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            decimal price = priceNumericUpDown.Value;
            string description = descriptionTextBox.Text;
            string type = typeComboBox.Text;
            bool prescription = prescriptionCheckBox.Checked;

            try
            {
                if (name.Length > 0 && price > 0 && description.Length > 0 && type.Length > 0)
                {
                    conn.OpenConnection();
                    int id = Convert.ToInt32(conn.GetIdValue(login));
                    conn.CloseConnection();
                    Antibiotic antibiotic = new Antibiotic(name, price, description, type, prescription, id);
                    conn.InsertData(antibiotic);
                    ClearData();
                    listBoxAntibiotic.Items.Clear();  //wyczyszczenie listBoxa
                    antibiotic.Write(listBoxAntibiotic);
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
                MessageBox.Show("Dodano Antybiotyk do bazy danych!.");
            }
        }

        private void ClearData()
        {
            nameTextBox.Text = "";
            priceNumericUpDown.Value = 0;
            descriptionTextBox.Text = "";
            typeComboBox.Text = "";
            prescriptionCheckBox.Checked = false;
        }
    }
}
