using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class flights : Form
    {
        private Flightsdatabase _flight;
        public flights()
        {
            InitializeComponent();
            

            _flight = new Flightsdatabase();
            _flight.Initialize();

            dataGridView1.DataSource = _flight.flighttables.ToList();
        }

        private void flights_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            employess newform = new employess();
            newform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Airports newform = new Airports();
            newform.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Stock newform = new Stock();
            newform.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Tours newform = new Tours();
            newform.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = _flight.flighttables.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
