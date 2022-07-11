using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_clinic_automation
{
    internal class WaitingList : IObject
    {
        Patient patient;
        Doctor doctor;
        Service service;
        public string FullNamePatient { get => patient.ToString(); }
        public string PositionPatient { get => patient.StateOfHealth; }
        public string Service { get => service.Name; }
        public string FullNameDoctor { get => doctor.ToString(); }
        public string OfficeOfNumber { get => doctor.OfficeNumber; }
        public string Price { get => service.Price; }
        public WaitingList(Doctor doctor, Patient patient, Service service)
        {

            this.service = service;
            this.doctor = doctor;
            this.patient = patient;
        }
        public void Add(int i)
        {
            //метод, добавляющий запись в лист ожидания
            StreamWriter streamWL = new(@"D:\Документы\ООП\WaitingList.txt", true);
            Data.tableWL.Rows.Add(Data.waitingList[i].FullNamePatient, Data.waitingList[i].PositionPatient, Data.waitingList[i].Service,
                    Data.waitingList[i].FullNameDoctor, Data.waitingList[i].OfficeOfNumber, Data.waitingList[i].Price);
            streamWL.WriteLine($"{Data.waitingList[i].FullNamePatient}|{Data.waitingList[i].PositionPatient}|{Data.waitingList[i].Service}|{Data.waitingList[i].FullNameDoctor}|{Data.waitingList[i].OfficeOfNumber}|{Data.waitingList[i].Price}|", true);
            streamWL.Close();
        }
    }
}
