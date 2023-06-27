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
    public partial class FormMain : Form
    {
        private string login;
        public FormMain(string login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void buttonAddSupplement_Click(object sender, EventArgs e)
        {
            FormSupplement formSupplement = new FormSupplement(this.login);
            formSupplement.ShowDialog();
        }

        private void buttonAddAntibiotic_Click(object sender, EventArgs e)
        {
            FormAntibiotic formAntibiotic = new FormAntibiotic(this.login);
            formAntibiotic.ShowDialog();
        }

        private void buttonBrowseList_Click(object sender, EventArgs e)
        {
            FormBrowseList formBrowseList = new FormBrowseList();
            formBrowseList.ShowDialog();
        }
    }
}
