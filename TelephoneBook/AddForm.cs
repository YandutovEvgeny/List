using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TelephoneBook
{
    public partial class AddForm : Form
    {
        List<Person> people;
        Person person = new Person();
        public AddForm()
        {
            InitializeComponent();
        }
        public AddForm(List<Person> people)
        {
            InitializeComponent();
            this.people = people;
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            person.Name = textBox1.Text;
            person.Telephone = textBox2.Text;
            person.Bday = dateTimePicker1.Value;
            people.Add(person);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                person.Photo = openFileDialog1.FileName;
            }
        }
    }
}
