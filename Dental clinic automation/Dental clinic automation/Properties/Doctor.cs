using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_clinic_automation
{
    internal class Doctor : Person
    {
        string _officeNumber, _position;
        public string OfficeNumber
        {
            get => _officeNumber; set
            {
                if (value != "") _officeNumber = value;
                else throw new Exception("Недопустимое значение null в ячейке 'Номер кабинета'");
            }
        }
        public string Position
        {
            get => _position; set
            {
                if (value != "") _position = value;
                else throw new Exception("Недопустимое значение null в ячейке 'Специальность'");
            }
        }
        public Doctor(string name, string surname, string patronymic, string gender, string phone,
            DateTime dateTime, string officeNumber, string position)
            : base(name, surname, patronymic, gender, phone, dateTime)
        {
            OfficeNumber = officeNumber;
            Position = position;
        }
        public override string ToString() => SurName + " " + Name + " " + Patronymic;
        public void Add(int i)
        {
            //метод, добавляющий врача
            StreamWriter streamDoctors = new(@"D:\Документы\ООП\Doctors.txt", true);
            Data.tableD.Rows.Add(Data.doctors[i].SurName, Data.doctors[i].Name, Data.doctors[i].Patronymic,
                Data.doctors[i].Gender, Data.doctors[i].DateBirth, Data.doctors[i].Phone,
                Data.doctors[i].Position, Data.doctors[i].OfficeNumber);
            streamDoctors.WriteLine($"{Data.doctors[i].SurName}|{Data.doctors[i].Name}|{Data.doctors[i].Patronymic}" +
                    $"|{Data.doctors[i].Gender}|{Data.doctors[i].DateBirth.ToShortDateString()}|{Data.doctors[i].Phone}|" +
                    $"{Data.doctors[i].Position}|{Data.doctors[i].OfficeNumber}|", true);
            streamDoctors.Close();
        }
        public static void Remove(int i)
        {
            //метод, удаляющий врача
            var doctor = new List<string>(File.ReadAllLines("D:\\Документы\\ООП\\Doctors.txt"));
            doctor.RemoveAt(i);
            File.WriteAllLines("D:\\Документы\\ООП\\Doctors.txt", doctor.ToArray());
        }
        Data.EventDelegate? eventDoctor = null;
        public event Data.EventDelegate EventDoctor
        {
            add { eventDoctor += value; }
            remove { eventDoctor -= value; }
        }
        public void InvokeEvent() => eventDoctor.Invoke();
        public static void Add() => throw new Exception("Доктор добавлен");
        public static void Remove() => throw new Exception("Доктор удален");
    }
}
