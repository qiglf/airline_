using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            AirlineDbEntities db = new AirlineDbEntities();
            var items = db.Customers.ToList();
            dataGridView1.DataSource = items;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            AirlineDbEntities db = new AirlineDbEntities();
            var items  = db.Customers.Where(a => a.Name.Equals(textBox1.Text)).ToList();
            dataGridView1.DataSource = items; 
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
