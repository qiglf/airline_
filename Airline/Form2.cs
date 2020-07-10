using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Airline
{
    public partial class Form2 : Form
    {
        private string FirstName;
        private string LastName;
        private string Number;
        private string Starting;
        private string Destination;
        private string Airline;
        private string Stopovers;
        private string Eating;
        private string Assistance;
        private string Row;
        private string Column;
        private string DateBirth;
        private string Date;
        private string BackDate;
        private string Email;
        private string Phone;



        public Form2()
        {
            InitializeComponent();
            this.ActiveControl = textBox4;
            textBox4.Focus();
        }
       
        private void Form2_Load(object sender, EventArgs e)
        {
          
        }
        private void FileStream(string v, string selectedState, FileMode fileMode, object append)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int row, col;

            const int MAX_ROW = 6;
            const int MAX_COL = 6;
            bool flightflag = false;

            if (!flightflag)
            {
                int output1;
                if (!int.TryParse(this.textBox1.Text, out output1) || (int.TryParse(this.textBox1.Text, out output1) &&
                    int.Parse(this.textBox1.Text) < 1 || int.Parse(this.textBox1.Text) > 9999999 || int.Parse(this.textBox1.Text) < 999999))
                {
                    MessageBox.Show("Enter a valid 7-numbered ID!");
                }

                else
                {
                    decimal[,] prices = { {450m, 450m,450m,450m},
                {425m, 425m, 425m, 425m},
                {375m, 375m,375m,375m },
                {375m,375m,375m,375m },
                {350m, 350m,350m,350m },
                {10m, 20m, 20m, 10m }
                     };

                    if (int.TryParse(comboBox7.Text, out row))
                    {
                        if (int.TryParse(comboBox8.Text, out col))
                            if (row >= 0 && row <= MAX_ROW)
                                if (col >= 0 && col <= MAX_COL)
                                {
                                    MessageBox.Show(prices[row, col].ToString("c"));
                                }
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Number = textBox1.Text;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Starting = comboBox1.Text;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Destination = comboBox2.Text;
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Airline = comboBox3.Text;
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Stopovers = comboBox4.Text;
        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            Eating = comboBox5.Text;
        }
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            Assistance = comboBox6.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Regexp(@"^([\w]+)@([\w]+)\.([\w]+)$", textBox2);
            Regexp1(@"^(0011)(([ ][0-9]{3}){3})$", textBox3);

            bool flightflag = false;

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "" || comboBox5.Text == "" || comboBox6.Text == "")
            {
                flightflag = true;
                MessageBox.Show("Complete all field data for flight!");
                
            }
            else
            {
                MessageBox.Show("The data was successfully send to the file!");
            }

            try
            {
                string writePath = "Tickets.txt";
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine("First name: " + FirstName + " " + "Last name: "+ LastName + " " + "ID number: " + Number + " " + "Statrting point: " + Starting + " " + "Destination: " + Destination + " " + "Airline name: " + Airline + " " + "Stopovers: " + Stopovers + " " + "Eating on board: " + Eating + " "+ "Special assistance: " + Assistance + " " + "Row: " + Row + " " + "Column: " + Column +" " + "Date of birth: " + DateBirth + " " + "Date: " + Date + " " + "Return Date: " + BackDate + " " + "Email: " + Email + " "+ "Phone number: " + Phone + " ");
                   
                }
            }
            catch (Exception em)
            {
                MessageBox.Show(em.Message);
            }

            AirlineDbEntities db = new AirlineDbEntities();
            Customer customer = new Customer
            {
                Name = textBox4.Text,
                Surname = textBox5.Text,
                Email = textBox2.Text,
                BirthDate = dateTimePicker3.Value,
                Phone = textBox3.Text
            };
            db.Customers.Add(customer);
            db.SaveChanges();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                MessageBox.Show("Please enter something in the textbox");
                return;
            }

            if (textBox4.Text.Any(char.IsWhiteSpace))
            {

                MessageBox.Show("Enter the valid name!");
            }
            if (textBox4.Text.Any(char.IsDigit))
            {

                MessageBox.Show("Enter the valid name!");
            }
            if (textBox4.Text.Any(char.IsPunctuation) && textBox4.Text.Any(char.IsSeparator))
            {

                MessageBox.Show("Enter the valid name!");
            }
            FirstName = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == " ")
            {
                MessageBox.Show("Please enter something in the textbox");
                return;
            }
            if (textBox5.Text == " " ^ textBox5.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Enter the valid name!");
            }
            LastName = textBox5.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Date = dateTimePicker1.Text;
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            Row = comboBox7.Text;
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            Column = comboBox8.Text;
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            DateBirth = dateTimePicker3.Text;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            BackDate = dateTimePicker2.Text; 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Email = textBox2.Text;
        }

        public void Regexp(string re, TextBox tb)
        {
            Regex regex = new Regex(re);
            if (regex.IsMatch(tb.Text))
            {
                MessageBox.Show("valid");
            }
            else
            {
                MessageBox.Show("Invalid email!");
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Phone = textBox3.Text;
        }

        public void Regexp1(string re, TextBox tb)
        {
            Regex regex = new Regex(re);
            if (regex.IsMatch(tb.Text))
            {
                MessageBox.Show("valid");
            }
            else
            {
                MessageBox.Show("Invalid phone!");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }
    }
}
