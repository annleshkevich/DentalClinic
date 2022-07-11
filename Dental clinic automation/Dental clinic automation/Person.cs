using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_clinic_automation
{
    internal abstract class Person : IObject
    {
        string _name, _surName, _patronymic, _gender, _phone;
        DateTime _dateBirth;
        public string SurName
        {
            get => _surName; set
            {
                if (value != "") _surName = value;
                else throw new Exception("Недопустимое значение null в ячейке 'Фамилия'");
            }
        }
        public string Name
        {
            get => _name; set
            {
                if (value != "") _name = value;
                else throw new Exception("Недопустимое значение null в ячейке 'Имя'");
            }
        }
        public string Patronymic
        {
            get => _patronymic; set
            {
                if (value != "") _patronymic = value;
                else throw new Exception("Недопустимое значение null в ячейке 'Отчество'");
            }
        }
        public string Gender
        {
            get => _gender; set
            {
                if (value != "") _gender = value;
                else throw new Exception("Недопустимое значение null в ячейке 'Пол'");
            }
        }
        public string Phone
        {
            get => _phone; set
            {
                if (value != "") _phone = value;
                else throw new Exception("Недопустимое значение null в ячейке 'Телефон'");
            }
        }
        public DateTime DateBirth
        {
            get => _dateBirth; set
            {
                if (value != null) _dateBirth = value;
                else throw new Exception("Недопустимое значение null в ячейке 'Дата рождения'");
            }
        }
        public Person(string name, string surname, string patronymic, string gender, string phone,
            DateTime dateTime)
        {
            Name = name;
            SurName = surname;
            Patronymic = patronymic;
            Gender = gender;
            DateBirth = dateTime;
            Phone = phone;
        }
    }
}
