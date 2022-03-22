using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lists
{
    public partial class Form1 : Form
    {
        List<string> names; 
        public Form1()
        {
            InitializeComponent();
            names = new List<string>() { "Maus", "Ирина", "Carl"}; //Инициализация листа
            names.Add("Женёк");
            names.Add("Ivan");
            names.Add("Oleg");
            //MessageBox.Show(names[2]);  //Oleg
            RefreshListBox();
        }

        void RefreshListBox()
        {
            listBox1.Items.Clear();
            /*for (int i = 0; i < names.Count; i++)
            {
                listBox1.Items.Add(names[i]);
            }*/
            foreach (string name in names)
            {
                //if (name.Contains("И"));
                listBox1.Items.Add(name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
                names.Add(textBox1.Text);
            RefreshListBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*if (textBox1.TextLength > 0)
                names.Remove(textBox1.Text);*/
            if(listBox1.SelectedIndex>=0)
                names.RemoveAt(listBox1.SelectedIndex);
            RefreshListBox();
        }
    }
}
