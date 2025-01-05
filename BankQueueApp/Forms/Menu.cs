using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankQueueApp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DisplayForm displayForm = new DisplayForm();
            displayForm.Show();
        }

        private void btnKiosk_Click(object sender, EventArgs e)
        {
            KioskForm kioskForm = new KioskForm();
            kioskForm.Show();
        }

        private void btnTeller_Click(object sender, EventArgs e)
        {
            TellerForm tellerForm = new TellerForm();
            tellerForm.Show();
        }
    }
}
