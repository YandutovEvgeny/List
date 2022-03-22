using System;
using System.Collections.Generic;
using System.Text;

namespace TelephoneBook
{
    public class Person
    {
        public string Name { get; set; }         //Имя
        public int Age { get; private set; }     //Возраст
        private DateTime bday;                   //День варенья
        private string telephone;                //Телефон
        public string Photo { get; set; }        //Фото
        
        public string Telephone
        {
            get { return telephone; }
            set 
            {
                bool isCorrect = true;
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] < '0' || value[i] > '9')
                    {
                        isCorrect = false;
                        break;
                    }       
                }
                if (isCorrect) telephone = value;
                else telephone = "Номер не определён";
                
            }
        }
        public DateTime Bday
        {
            get { return bday; }
            set 
            {
                bday = value;
                Age = DateTime.Now.Year - bday.Year;
            }
        }
    }
}
