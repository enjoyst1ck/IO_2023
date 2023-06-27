using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public abstract class Medicament
    {
        public int id;
        public string name;
        public decimal price;
        public string description;
        public string type;
        public int user_id;

        public Medicament()
        {
            this.id = id + 1;
            this.name = "-";
            this.price = 1;
            this.description = "-";
            this.type = "-";
            this.user_id = 0;
        }

        public Medicament(int id, string name, decimal price, string description, string type, int user_id)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.description = description;
            this.type = type;
            this.user_id = user_id;
        }

        public Medicament(string name, decimal price, string description, string type, int user_id)
        {
            this.id = id + 1;
            this.name = name;
            this.price = price;
            this.description = description;
            this.type = type;
            this.user_id = user_id;
        }

        public Medicament(Medicament drug)
        {
            this.id = id + 1;
            this.name = drug.name;
            this.price = drug.price;
            this.description = drug.description;
            this.type = drug.type;
            this.user_id = drug.user_id;
        }

        public virtual void Write(ListBox drug)
        {
            drug.Items.Add("Nazwa:\t\t\t" + name);
            drug.Items.Add("Cena:\t\t\t" + price);
            drug.Items.Add("Opis:\t\t\t" + description);
            drug.Items.Add("Typ:\t\t\t" + type);
        }
    }
}
