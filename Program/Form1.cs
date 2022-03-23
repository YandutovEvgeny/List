using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class Form1 : Form
    {
        //TODO: Программа использует английские символы 
        Random random;
        string russian = "йцукенгшщзхъфывапролджэячсмитьбю";
        string english = "qwertyuiopasdfghjklzxcvbnm";
        int seconds = 0;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Add(russian[random.Next(russian.Length)]);
            seconds += 1;
            label1.Text = "Время: " + (seconds / 2).ToString();
            if (listBox1.Items.Count >= 30)
                GameOver();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;  //Запуск таймера 
            textBox1.Focus();   //Устанавливает фокус на textBox1 при запуске
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;  //Остановка таймера 
        }

        void GameOver()
        {
            timer1.Enabled = false;
            MessageBox.Show("Игра закончена\nВаш счёт равен " + score.ToString());
            score = 0;
            seconds = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (timer1.Enabled == true && textBox1.Text.Length > 0)
            {
                if (textBox1.Text == listBox1.Items[0].ToString())
                {
                    score++;
                    listBox1.Items.RemoveAt(0);
                    label2.Text = "Счёт: " + score.ToString();
                    //textBox1.Text = "";
                }
                else
                {
                    GameOver();
                } 
            }
            textBox1.Text = "";
        }
    }
}
