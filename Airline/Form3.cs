using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.ActiveControl = usertxt;
            usertxt.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AirlineDbEntities db = new AirlineDbEntities(); 
            if (usertxt.Text !=string.Empty && passtxt.Text !=string.Empty)
            {
                var user = db.Admin.Where(a => a.Username.Equals(usertxt.Text)).SingleOrDefault();
                if (user != null)
                {
                    if (user.Password.Equals(passtxt.Text))
                    {
                        MessageBox.Show("You have logged in successfully");
                        MessageBox.Show("All yout tickets will be shown here:");
                        try
                        {
                            using (StreamReader sr = new StreamReader("Tickets.txt"))
                            {
                                string line;

                                while ((line = sr.ReadLine()) != null)
                                {
                                    MessageBox.Show(line);
                                }
                            }
                        }
                        catch (Exception em)
                        {
                            Console.WriteLine("The file could not be read:");
                            Console.WriteLine(em.Message);
                        }
                        this.Hide();
                        Clients frm = new Clients();
                        frm.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Incorrect username or password!");
            }
        }
         

        private void usertxt_TextChanged(object sender, EventArgs e)
        {
            if (usertxt.Text.Any(char.IsDigit))
            {

                MessageBox.Show("Enter the valid name!");
            }
            if (usertxt.Text.Any(char.IsPunctuation) && usertxt.Text.Any(char.IsSeparator))
            {

                MessageBox.Show("Enter the valid name!");
            }
            if (usertxt.Text.Any(char.IsWhiteSpace))
            {

                MessageBox.Show("Enter the valid name!");
            }
        }
        private void passtxt_TextChanged(object sender, EventArgs e)
        {
             if (passtxt.Text.Any(char.IsDigit))
            {

                MessageBox.Show("Enter the valid password!");
            }
            if (passtxt.Text.Any(char.IsPunctuation) && passtxt.Text.Any(char.IsSeparator))
            {

                MessageBox.Show("Enter the valid password!");
            }
            if (passtxt.Text.Any(char.IsWhiteSpace))
            {

                MessageBox.Show("Enter the valid name!");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void usertxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                passtxt.Focus();
            }
        }

        private void passtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
