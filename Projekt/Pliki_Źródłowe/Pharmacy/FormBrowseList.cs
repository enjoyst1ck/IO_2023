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
    public partial class FormBrowseList : Form
    {
        private int currentIndex = -1;

        private DatabaseConnection conn = new DatabaseConnection();
        private List<Medicament> medicamentList = new List<Medicament>();
        public FormBrowseList()
        {
            InitializeComponent();
            currentIndex = -1;
            UpdateButtons();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            List<Supplement> supplementsList = conn.GetSupplements();
            List<Antibiotic> antibioticList = conn.GetAntibiotic();

            medicamentList.Clear();

            if (supplementsList != null)
            {
                for (int i = 0; i < supplementsList.Count; i++)
                {
                    medicamentList.Add(supplementsList[i]);
                }
            }

            if (antibioticList != null)
            {
                for (int i = 0; i < antibioticList.Count; i++)
                {
                    medicamentList.Add(antibioticList[i]);
                }
            }

            listBoxList.Items.Clear();

            if (medicamentList != null)
            {
                if (medicamentList.Count > 0) //jeżeli lista nie jest pusta
                {
                    currentIndex = 0; //wyświetlamy pierwszy obiekt
                    listBoxList.Items.Clear();
                    medicamentList[currentIndex].Write(listBoxList);
                    UpdateButtons();
                }
                else
                    MessageBox.Show("Lista jest pusta!");
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            currentIndex--;
            listBoxList.Items.Clear();
            medicamentList[currentIndex].Write(listBoxList);
            UpdateButtons();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            currentIndex++;
            listBoxList.Items.Clear();
            medicamentList[currentIndex].Write(listBoxList);
            UpdateButtons();
        }

        private void UpdateButtons()
        {
            if (currentIndex == 0) //jeżeli wyświetlamy pierwszy element na liście
            {
                buttonPrevious.Enabled = false;
            }
            else
            {
                buttonPrevious.Enabled = true;
            }
            if (currentIndex >= medicamentList.Count - 1) //jeżeli wyświetlamy ostatni element na liście
            {
                buttonNext.Enabled = false;
            }
            else
            {
                buttonNext.Enabled = true;
            }

            if (currentIndex < 0) //nic nie wyświetlamy
            {
                buttonNext.Enabled = false;
                buttonPrevious.Enabled = false;
            }
        }
    }
}
