using System.ComponentModel;

namespace Dental_clinic_automation
{
    public partial class Form1 : Form
    {
        Form2 form2;
        private void Form1_Load(object sender, EventArgs e) { }
        public Form1()
        {
            InitializeComponent();
            Data.Table table = TablePatients;
            table += TableServices;
            table += TableDoctors;
            table += TableWaitingList;
            table();
            Visible();
        }
        public void Visible()
        {
            //управление видимостью объектов
            panelMenu.Visible = true;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Size = new Size(800, 450);
            tablePatients.Visible = false;
            tablesWaitingList.Visible = false;
            tablePatients.Location = new Point(26, 49);
            tablePatients.Size = new Size(752, 342);
            panelPatients.Visible = false;
            panelPatients.Location = new Point(0, 41);
            panelPatients.Size = new Size(800, 400);
            panelDoctors.Visible = false;
            tableDoctors.Visible = false;
            panelDoctors.Location = new Point(0, 41);
            panelDoctors.Size = new Size(800, 400);
            tableDoctors.Visible = false;
            panelServices.Visible = false;
            panelServices.Location = new Point(0, 41);
            panelServices.Size = new Size(800, 400);
        }
        public void TablePatients()
        {
            //создание и заполнение таблиц
            //таблица пациентов
            StreamReader streamPatients = new(@"D:\Документы\ООП\Patients.txt");
            string strPatients = streamPatients.ReadToEnd();
            string[] arrayPatients = strPatients.Split('|');
            Data.tableP.Columns.Add("Фамилия", typeof(string));
            Data.tableP.Columns.Add("Имя", typeof(string));
            Data.tableP.Columns.Add("Отчество", typeof(string));
            Data.tableP.Columns.Add("Дата Рождения", typeof(DateTime));
            Data.tableP.Columns.Add("Номер", typeof(string));
            Data.tableP.Columns.Add("Состояние", typeof(string));
            Data.tableP.Columns.Add("Пол", typeof(string));
            string[] arrayP = new string[7];
            for (int i = 0, m = 0; i < arrayPatients.Length; i++, m++)
            {
                arrayP[m] = arrayPatients[i];
                if (m == 6)
                {
                    Data.patients.Add(new Patient(arrayP[1], arrayP[0], arrayP[2], arrayP[6], arrayP[4],
                         DateTime.Parse(arrayP[3]), arrayP[5]));
                    m = -1;
                }
            }
            for (int y = 0; y < Data.patients.Count; y++)
            {
                Data.tableP.Rows.Add(Data.patients[y].SurName, Data.patients[y].Name, Data.patients[y].Patronymic, Data.patients[y].DateBirth,
                     Data.patients[y].Phone, Data.patients[y].StateOfHealth, Data.patients[y].Gender);
            }
            tablePatients.DataSource = Data.tableP;
            streamPatients.Close();
        }
        public void TableDoctors()
        {
            //таблица врачей
            StreamReader streamDoctors = new(@"D:\Документы\ООП\Doctors.txt");
            string strDoctors = streamDoctors.ReadToEnd();
            string[] arrayDoctors = strDoctors.Split('|');
            Data.tableD.Columns.Add("Фамилия", typeof(string));
            Data.tableD.Columns.Add("Имя", typeof(string));
            Data.tableD.Columns.Add("Отчество", typeof(string));
            Data.tableD.Columns.Add("Пол", typeof(string));
            Data.tableD.Columns.Add("Дата Рождения", typeof(DateTime));
            Data.tableD.Columns.Add("Номер", typeof(string));
            Data.tableD.Columns.Add("Специализация", typeof(string));
            Data.tableD.Columns.Add("Кабинет", typeof(string));
            string[] arrayD = new string[8];
            for (int i = 0, m = 0; i < arrayDoctors.Length; i++, m++)
            {
                arrayD[m] = arrayDoctors[i];
                if (m == 7)
                {
                    Data.doctors.Add(new Doctor(arrayD[1], arrayD[0], arrayD[2], arrayD[3], arrayD[5],
                        DateTime.Parse(arrayD[4]), arrayD[7], arrayD[6]));
                    m = -1;
                }
            }
            for (int y = 0; y < Data.doctors.Count; y++)
            {
                Data.tableD.Rows.Add(Data.doctors[y].SurName, Data.doctors[y].Name,
                    Data.doctors[y].Patronymic, Data.doctors[y].Gender, Data.doctors[y].DateBirth,
                    Data.doctors[y].Phone, Data.doctors[y].Position, Data.doctors[y].OfficeNumber);
            }
            tableDoctors.DataSource = Data.tableD;
            streamDoctors.Close();
        }
        public void TableServices()
        {
            //таблица услуг
            using StreamReader streamServices = new(@"D:\Документы\ООП\Services.txt");
            string strServices = streamServices.ReadToEnd();
            string[] arrayServices = strServices.Split('|');
            Data.tableS.Columns.Add("Вид операции", typeof(string));
            Data.tableS.Columns.Add("Специализация", typeof(string));
            Data.tableS.Columns.Add("Цена, руб.", typeof(string));
            string[] arrayS = new string[3];
            for (int i = 0, m = 0; i < arrayServices.Length; i++, m++)
            {
                arrayS[m] = arrayServices[i];
                if (m == 2)
                {
                    Data.services.Add(new Service(arrayS[0], arrayS[1], arrayS[2]));
                    m = -1;
                }
            }
            for (int y = 0; y < Data.services.Count; y++)
            {
                Data.tableS.Rows.Add(Data.services[y].Name, Data.services[y].Position, Data.services[y].Price);
            }
            tableServices.DataSource = Data.tableS;
            streamServices.Close();
        }
        public void TableWaitingList()
        {
            //лист ожидания
            StreamReader streamWaitingList = new(@"D:\Документы\ООП\WaitingList.txt");
            string strWL = streamWaitingList.ReadToEnd();
            string[] arrayWaitingList = strWL.Split('|');
            Data.tableWL.Columns.Add("ФИО пациента", typeof(string));
            Data.tableWL.Columns.Add("Состояние", typeof(string));
            Data.tableWL.Columns.Add("Услуга", typeof(string));
            Data.tableWL.Columns.Add("ФИО врача", typeof(string));
            Data.tableWL.Columns.Add("Кабинет", typeof(string));
            Data.tableWL.Columns.Add("Цена, руб.", typeof(string));
            string[] arrayWL = new string[6];
            Patient patient = null;
            Service service = null;
            Doctor doctor = null;
            for (int i = 0, m = 0; i < arrayWaitingList.Length; i++, m++)
            {
                arrayWL[m] = arrayWaitingList[i];
                if (m == 5)
                {

                    foreach (var item in Data.doctors)
                    {


                        if (item.ToString().Trim('\r', '\n') == arrayWL[3])
                        {
                            doctor = item;
                        }
                    }
                    foreach (var item in Data.patients)
                    {
                        if (item.ToString().Trim('\r', '\n') == arrayWL[0])
                        {
                            patient = item;
                        }
                    }
                    foreach (var item in Data.services)
                    {
                        if (item.Name.Trim('\r', '\n') == arrayWL[2])
                        {
                            service = item;
                        }
                    }

                    Data.waitingList.Add(new WaitingList(doctor, patient, service));
                    m = -1;
                }
            }
            for (int y = 0; y < Data.waitingList.Count; y++)
            {
                Data.tableWL.Rows.Add(Data.waitingList[y].FullNamePatient, Data.waitingList[y].PositionPatient, Data.waitingList[y].Service,
                    Data.waitingList[y].FullNameDoctor, Data.waitingList[y].OfficeOfNumber, Data.waitingList[y].Price);
            }
            tablesWaitingList.DataSource = Data.tableWL;
            streamWaitingList.Close();
        }
        private void ButtonPatients(object sender, EventArgs e)
        {
            //пациенты
            Visible();
            panelPatients.Visible = true;
            tablePatients.Visible = true;
        }
        private void ButtonDoctors(object sender, EventArgs e)
        {
            //врачи
            Visible();
            panelDoctors.Visible = true;
            tableDoctors.Visible = true;
        }
        private void ButtonServices(object sender, EventArgs e)
        {
            //услуги
            Visible();
            panelServices.Location = new Point(0, 41);
            panelServices.Size = new Size(797, 397);
            panelServices.Visible = true;
        }
        private void ButtonMakeAnAppointment(object sender, EventArgs e)
        {
            //записать на прием
            Visible();
            panelPatients.Visible = true;
            form2 = new Form2();
            form2.MakeAnAppointment();
            form2.Show();
            tablesWaitingList.Refresh();
        }
        private void ButtonAddPatient(object sender, EventArgs e)
        {
            //добавление пациента
            Visible();
            panelPatients.Visible = true;
            tablePatients.Visible = true;
            form2 = new Form2();
            form2.SavePatient();
            form2.Show();
            tablePatients.Refresh();
        }
        private void ButtonAddDoctor(object sender, EventArgs e)
        {
            //добавление врача
            Visible();
            panelDoctors.Visible = true;
            tableDoctors.Visible = true;
            form2 = new Form2();
            form2.SaveDoctor();
            form2.Show();
            tableDoctors.Refresh();
        }
        private void ButtonAddService(object sender, EventArgs e)
        {
            //добавить услугу
            Visible();
            panelServices.Visible = true;
            tableServices.Visible = true;
            form2 = new Form2();
            form2.SaveService();
            form2.Show();
            tableServices.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //лист ожидания
            Visible();
            panelPatients.Visible = true;
            tablesWaitingList.Visible = true;
        }
        private void ButtonRemovePatient(object sender, EventArgs e)
        {
            //удаление клиента
            Visible();
            panelPatients.Visible = true;
            tablePatients.Visible = true;
            tablePatients.Rows.RemoveAt(tablePatients.CurrentCell.RowIndex);
            Patient.Remove(tablePatients.CurrentCell.RowIndex);
        }
        private void ButtonRemoveDoctor(object sender, EventArgs e)
        {
            //удаление врача
            Visible();
            panelDoctors.Visible = true;
            tableDoctors.Visible = true;
            tableDoctors.Rows.RemoveAt(tableDoctors.CurrentCell.RowIndex);
            Doctor.Remove(tableDoctors.CurrentCell.RowIndex);
        }
        private void ButtonRemoveService(object sender, EventArgs e)
        {
            //удалить услуг
            Visible();
            panelServices.Visible = true;
            tableServices.Visible = true;
            tableServices.Rows.RemoveAt(tableServices.CurrentCell.RowIndex);
            Service.Remove(tableServices.CurrentCell.RowIndex);
        }
        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e) { }
        private void Button2_Click(object sender, EventArgs e) { }
        private void Button3_Click(object sender, EventArgs e) => Close();
        private void Label1_Click(object sender, EventArgs e) { }
        private void tablePatients_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}