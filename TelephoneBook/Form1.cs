using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelephoneBook
{
    public partial class Form1 : Form
    {
        List<Person> people;

        void RefreshList()
        {
            listBox1.Items.Clear();
            foreach(Person person in people)
            {
                listBox1.Items.Add(person.Name);
            }
        }
        public Form1()
        {
            InitializeComponent();
            people = new List<Person>();
            
            //1 способ
            Person Igor = new Person();
            Igor.Name = "Игорь";
            Igor.Photo = "C:\\Users\\Admin\\Pictures\\GameCenter\\Warface\\Warface_190130_2027.jpg";
            Igor.Telephone = "89067543275";
            Igor.Bday = new DateTime(1990, 3, 17);

            people.Add(Igor);
            
            //2 способ
            people.Add(new Person()
            {
                Bday = new DateTime(1990, 7, 28),
                Name = "Ольга",
                Photo = "C:\\Users\\Admin\\Pictures\\GameCenter\\Warface\\Warface_190130_2027.jpg",
                Telephone = "39067534581"
            });

            RefreshList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            if(listBox1.SelectedIndex>=0)   //Если номер выделен
            {
                int index = listBox1.SelectedIndex;     //Выделенный номер
                pictureBox1.Image = Image.FromFile(people[index].Photo);
                label1.Text = "Имя: " + people[index].Name;
                label2.Text = $"Телефон: {people[index].Telephone}";
                label3.Text = $"Возраст: {people[index].Age.ToString()}";
                label4.Text = "Дата рождения: " + people[index].Bday.ToString("dd.MM.yyyy");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(people);
            addForm.ShowDialog();
            RefreshList();
        }
    }
}
