using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_clinic_automation
{
    internal class Patient : Person
    {
        string _stateOfHealth;
        public string StateOfHealth
        {
            get => _stateOfHealth; set
            {
                if (value != null) _stateOfHealth = value;
                else throw new Exception("Недопустимое значение null в ячейке 'Состояние'");
            }
        }
        public Patient(string name, string surname, string patronymic, string gender, string phone,
            DateTime dateTime, string stateOfHealth)
            : base(name, surname, patronymic, gender, phone, dateTime)
        {
            StateOfHealth = stateOfHealth;
        }
        public override string ToString() => $"{SurName} {Name} {Patronymic}";
        public void AddP(int i, Patient patient)
        {
            //метод, добавляющий пациента
            StreamWriter streamPatients = new(@"D:\Документы\ООП\Patients.txt", true);
            Data.tableP.Rows.Add(patient.SurName, patient.Name, patient.Patronymic, DateBirth, patient.Phone, patient.StateOfHealth, patient.Gender);
            streamPatients.WriteLine($"{patient.SurName}|{patient.Name}|{patient.Patronymic}|{patient.DateBirth.ToShortDateString()}|{patient.Phone}|" +
                    $"{patient.StateOfHealth}|{patient.Gender}|", true);
            streamPatients.Close();
        }
        public static void Remove(int i)
        {
            //метод, удаляющий пациента 
            var patient = new List<string>(File.ReadAllLines("D:\\Документы\\ООП\\Patients.txt"));
            patient.RemoveAt(i);
            File.WriteAllLines("D:\\Документы\\ООП\\Patients.txt", patient.ToArray());
        }
        Data.EventDelegate eventPatient = null;
        public event Data.EventDelegate EventPatient
        {
            add { eventPatient += value; }
            remove { eventPatient -= value; }
        }
        public void InvokeEvent()
        {
            eventPatient.Invoke();
        }
        public static void Add() => throw new Exception("Пациент добавлен");
        public static void Remove() => throw new Exception("Пациент удален");
    }
}
