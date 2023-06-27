using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public class Supplement : Medicament
    {
        public string activeSubstance; //składnik czynny witaminy

        public Supplement() : base()
        {
            activeSubstance = "-";
        }

        public Supplement(string name, decimal price, string description, string type, string activeSubstance, int user_id) : base(name, price, description, type, user_id)
        {
            this.activeSubstance = activeSubstance;
        }

        public Supplement(int id, string name, decimal price, string description, string type, string activeSubstance, int user_id) : base(id, name, price, description, type, user_id)
        {
            this.activeSubstance = activeSubstance;
        }

        public Supplement(Supplement drug) : base(drug)
        {
            this.activeSubstance = drug.activeSubstance;
        }

        public override void Write(ListBox drug)
        {
            base.Write(drug);
            drug.Items.Add("Aktywna substancja:\t\t\t" + activeSubstance);
            drug.Items.Add("Dodane przez użytkownika o id:\t\t\t" + user_id);
        }
    }
}
