using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_clinic_automation
{
    internal class Service : IObject
    {
        string _name, _position, _price;
        public string Name
        {
            get => _name; set
            {
                if (value != null) _name = value;
                else throw new Exception("Недопустимое значение null" +
                    " в ячейке 'Название услуги'");
            }
        }
        public string Position
        {
            get => _position; set
            {
                if (value != null) _position = value;
                else throw new Exception("Недопустимое значение null " +
                    "в ячейке 'Специальность'");
            }
        }
        public string Price
        {
            get => _price; set
            {
                if (value != null) _price = value;
                else throw new Exception("Недопустимое значение null в ячейке 'Цена'");
            }
        }
        public Service(string name, string position, string price)
        {
            Name = name;
            Position = position;
            Price = price;
        }
        public static void Add(int i)
        {
            //метод, добавляющий услугу
            StreamWriter streamService = new(@"D:\Документы\ООП\Services.txt", true);
            Data.tableS.Rows.Add(Data.services[i].Name, Data.services[i].Position, Data.services[i].Price);
            streamService.WriteLine($"{Data.services[i].Name}|{Data.services[i].Position}|{Data.services[i].Price}|", true);
            streamService.Close();
        }
        public static void Remove(int i)
        {
            //метод, удаляющий услугу
            var service = new List<string>(File.ReadAllLines("D:\\Документы\\ООП\\Services.txt"));
            service.RemoveAt(i);
            File.WriteAllLines("D:\\Документы\\ООП\\Services.txt", service.ToArray());
        }
        Data.EventDelegate? eventService = null;
        public event Data.EventDelegate EventService
        {
            add { eventService += value; }
            remove { eventService -= value; }
        }
        public void InvokeEvent()
        {
            eventService.Invoke();
        }
        public static void Add() => throw new Exception("Услуга добавлена");
        public static void Remove() => throw new Exception("Услуга удалена");
    }
}
