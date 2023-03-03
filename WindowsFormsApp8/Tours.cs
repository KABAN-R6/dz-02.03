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
    public partial class Tours : Form
    {
        private travel_mapdatabase _tours;
        public Tours() 
        {
            
            InitializeComponent();


            _tours = new travel_mapdatabase();
            _tours.Initialize();

            dataGridView1.DataSource = _tours.travel_Maptabls.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            flights newform = new flights();
            newform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void Tours_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
