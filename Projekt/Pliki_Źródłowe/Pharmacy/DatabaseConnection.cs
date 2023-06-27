using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace Pharmacy
{
    internal class DatabaseConnection
    {
        private MySqlConnection connection;
        private string connectionString;
        private string server;
        private string username;
        private string password;
        private string database;

        public DatabaseConnection()
        {
            this.server = "localhost";
            this.username = "root";
            this.password = "";
            this.database = "projekt_inzynieria";
        }

        public void OpenConnection()
        {
            connectionString = $"Server={server};Database={database};Uid={username};Pwd={password};";
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas otwierania połączenia: " + ex.Message);
            }
        }

        public void CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas zamykania połączenia: " + ex.Message);
            }
        }

        public string GetIdValue(string login)
        {
            string query = $"SELECT user_id FROM users WHERE login = @login";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@login", login);

            try
            {
                object result = command.ExecuteScalar();
                return result != null ? result.ToString() : string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas pobierania wartości z bazy danych: " + ex.Message);
                return string.Empty;
            }
        }

        public string GetLoginValue(string login)
        {
            OpenConnection();
            string query = $"SELECT login FROM users WHERE login = @login";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@login", login);
            try
            {
                object result = command.ExecuteScalar();
                return result != null ? result.ToString() : string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas pobierania wartości z bazy danych: " + ex.Message);
                return string.Empty;
            }
        }

        public string GetPasswordValue(string login)
        {
            string query = $"SELECT password FROM users WHERE login = @login";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@login", login);

            try
            {
                object result = command.ExecuteScalar();
                return result != null ? result.ToString() : string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas pobierania wartości z bazy danych: " + ex.Message);
                return string.Empty;
            }
        }

        public List<Supplement> GetSupplements()
        {
            OpenConnection();

            string query = $"SELECT * FROM supplements";
            List<Supplement> supplementsList = new List<Supplement>();

            //command.Parameters.AddWithValue("@login", login);

            MySqlCommand command = new MySqlCommand(query, connection);
            
            try
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id_supplement = reader.GetInt32("id_supplement");
                        string name = reader.GetString("name");
                        decimal price = reader.GetDecimal("price");
                        string type = reader.GetString("type");
                        string description = reader.GetString("description");
                        string activeSubstance = reader.GetString("activeSubstance");
                        int user_id = reader.GetInt32("user_id");

                        // Tworzenie obiektu Supplement i dodawanie do listy
                        Supplement supplement = new Supplement(id_supplement, name, price, description, type, activeSubstance, user_id);
                        supplementsList.Add(supplement);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas pobierania wartości z bazy danych: " + ex.Message);
                return null;
            }

            return supplementsList;
        }

        public List<Antibiotic> GetAntibiotic()
        {
            OpenConnection();

            string query = $"SELECT * FROM antibiotics";
            List<Antibiotic> antibioticsList = new List<Antibiotic>();

            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id_antibiotic = reader.GetInt32("id_antibiotic");
                        string name = reader.GetString("name");
                        decimal price = reader.GetDecimal("price");
                        string description = reader.GetString("description");
                        string type = reader.GetString("type");
                        bool prescription = reader.GetBoolean("prescription");
                        int user_id = reader.GetInt32("user_id");

                        // Tworzenie obiektu Supplement i dodawanie do listy
                        Antibiotic antibiotic = new Antibiotic(id_antibiotic, name, price, description, type, prescription, user_id);
                        antibioticsList.Add(antibiotic);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas pobierania wartości z bazy danych: " + ex.Message);
                return null;
            }

            return antibioticsList;
        }

        public bool InsertData(string login, string password)
        {
            try
            {

                OpenConnection();

                // Utworzenie zapytania SQL z parametrami
                string query = "INSERT INTO users (login, password) VALUES (@login, @password)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Przypisanie wartości parametru
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", password);

                    // Wykonanie zapytania
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas dodawania danych: " + ex.Message);
            }

            return false;
        }

        public bool InsertData(Supplement sup)
        {
                try
                {
                    OpenConnection();
                    string name = sup.name;
                    decimal price = sup.price;
                    string description = sup.description;
                    string type = sup.type;
                    string activeSubstance = sup.activeSubstance;
                    int user_id = sup.user_id;
                    // Utworzenie zapytania SQL z parametrami
                    string query = "INSERT INTO supplements (name, price, description, type, activeSubstance, user_id) VALUES (@name, @price, @description, @type, @activeSubstance, @user_id)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Przypisanie wartości parametru
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@price", price);
                        command.Parameters.AddWithValue("@description", description);
                        command.Parameters.AddWithValue("@type", type);
                        command.Parameters.AddWithValue("@activeSubstance", activeSubstance);
                        command.Parameters.AddWithValue("@user_id", user_id);

                        // Wykonanie zapytania
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Udało się wprowadzic nowy suplement!");
                            return true;
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas dodawania danych: " + ex.Message);
            }

            return false;
        }

        public bool InsertData(Antibiotic antibiotic)
        {
            try
            {
                OpenConnection();
                string name = antibiotic.name;
                decimal price = antibiotic.price;
                string description = antibiotic.description;
                string type = antibiotic.type;
                bool prescription = antibiotic.prescription;
                int user_id = antibiotic.user_id;
                // Utworzenie zapytania SQL z parametrami
                string query = "INSERT INTO antibiotics (name, price, description, type, prescription, user_id) VALUES (@name, @price, @description, @type, @prescription, @user_id)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Przypisanie wartości parametru
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@type", type);
                    command.Parameters.AddWithValue("@prescription", prescription);
                    command.Parameters.AddWithValue("@user_id", user_id);

                    // Wykonanie zapytania
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Udało się wprowadzic nowy antybiotyk!");
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas dodawania danych: " + ex.Message);
            }

            return false;
        }
    }
}
