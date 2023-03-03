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
    public partial class employess : Form
    {
        public employess()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            flights newform = new flights();
            newform.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            InitializeComponent();


            _employs = new travel_mapdatabase();
            _employs.Initialize();

            dataGridView1.DataSource = _tours.travel_Maptabls.ToList();
        }
    }
}
