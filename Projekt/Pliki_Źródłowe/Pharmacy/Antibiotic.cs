using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    class Antibiotic : Medicament
    {
        public bool prescription;      //czy antybiotyk na recepta

        public Antibiotic() : base()
        {
            prescription = false;
        }

        public Antibiotic(string name, decimal price, string description, string type, bool prescription, int user_id) : base(name, price, description, type, user_id)
        {
            this.prescription = prescription;
        }

        public Antibiotic(int id, string name, decimal price, string description, string type, bool prescription, int user_id) : base(id, name, price, description, type, user_id)
        {
            this.prescription = prescription;
        }

        public Antibiotic(Antibiotic drug) : base(drug)
        {
            this.prescription = drug.prescription;
        }

        public override void Write(ListBox drug)
        {
            base.Write(drug);
            drug.Items.Add("Czy lek na recepte?:\t\t\t" + prescription);
            drug.Items.Add("Dodane przez użytkownika o id:\t\t\t" + user_id);
        }
    }
}
