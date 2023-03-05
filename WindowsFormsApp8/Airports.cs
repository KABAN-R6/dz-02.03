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
    public partial class Airports : Form
    {
        private Airoportsdatabase _airoports;
        public Airports()
        {
            InitializeComponent();

            _airoports = new Airoportsdatabase();
            _airoports.Initialize();

            dataGridView1.DataSource = _airoports.Airoportstables.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            flights newform = new flights();
            newform.Show();
        }

        private void Airports_Load(object sender, EventArgs e)
        {
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
