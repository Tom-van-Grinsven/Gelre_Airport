using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gelre_airport.Database;
using System.Windows.Forms;
using Gelre_airport.Classes;
using System.Data.SqlClient;

namespace Gelre_airport
{
    public partial class MainForm : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        GelreAirport airport = new GelreAirport();
        public MainForm()
        {
            InitializeComponent();         
        }

        public void UpdateEmbeddedForm(Form form)
        {
            pnlWindow.Controls.Clear();

            form.Dock = DockStyle.Fill;
            form.AutoSize = true;
            form.FormBorderStyle = FormBorderStyle.None;

            form.TopLevel = false;
            pnlWindow.Controls.Add(form);
            form.Show();

            form.Closed += new EventHandler(CloseForm);
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }



        private void btnGetCheckInCounters_Click(object sender, EventArgs e)
        {
            foreach (var counter in airport.counters)
            {
                lbCheckInCounters.Items.Add(counter);
            }
        }

        private void btnSelectCheckInCounter_Click(object sender, EventArgs e)
        {
            var SelectedCheckInCounter = lbCheckInCounters.SelectedItem as CheckInCounter;
            if (SelectedCheckInCounter != null)
            {
                UpdateEmbeddedForm(new CheckInForm(SelectedCheckInCounter.CheckInCounterNumber, this.airport));
            }
            else
            {
                MessageBox.Show("Selecteer een balie");
            }
            
        }
    }
}
