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
        private employsdatabase _employs;
        public employess()
        {
            InitializeComponent();
            _employs = new employsdatabase();
            _employs.Initialize();

            dataGridView1.DataSource = _employs.employs.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            flights newform = new flights();
            newform.Show();
        }

        private void employess_Load(object sender, EventArgs e)
        {

        }
    }
}
