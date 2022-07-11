using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dental_clinic_automation
{
    static class Data
    {
        public static List<Patient> patients = new List<Patient>();
        public static List<Service> services = new List<Service>();
        public static List<Doctor> doctors = new List<Doctor>();
        public static List<WaitingList> waitingList = new List<WaitingList>();
        public static DataTable tableP = new DataTable();
        public static DataTable tableD = new DataTable();
        public static DataTable tableS = new DataTable();
        public static DataTable tableWL = new DataTable();
        public delegate void Table();
        public delegate void EventDelegate();
    }
}
