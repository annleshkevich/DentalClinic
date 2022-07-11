using System.ComponentModel;
namespace Dental_clinic_automation
{
    public partial class Form2 : Form
    {
        int x = 0, y = 0;
        private void Form2_Load(object sender, EventArgs e) { }
        public Form2()
        {
            InitializeComponent();
        }
        public void Visible()
        {
            //управление видимостью объектов
            panelServiceSave.Visible = false;
            panelDoctorSave.Visible = false;
            panelPatientSave.Visible = false;
            panelMakeAnAppointment.Visible = false;
            panelMakeAnAppointment.Location = new Point(-9, -1);
            panelMakeAnAppointment.Size = new Size(528, 382);
            panelPatientSave.Size = new Size(528, 382);
            panelPatientSave.Location = new Point(-9, -1);
            panelDoctorSave.Size = new Size(528, 382);
            panelDoctorSave.Location = new Point(-9, -1);
            panelServiceSave.Size = new Size(528, 382);
            panelServiceSave.Location = new Point(-9, -1);
        }
        public void MakeAnAppointment()
        {
            //запись на прием
            Visible();
            panelMakeAnAppointment.Visible = true;
            for (int i = 0; i < Data.patients.Count; i++)
                comboBoxPatient.Items.Add(Data.patients[i].ToString());
        }
        public void SavePatient()
        {
            //регистрация пациента
            Visible();
            panelPatientSave.Visible = true;
        }
        public void SaveDoctor()
        {
            //регистрация врача
            Visible();
            panelDoctorSave.Visible = true;
        }
        public void SaveService()
        {
            //сохранение услуги
            Visible();
            panelServiceSave.Visible = true;
        }
        private void SavePatient(object sender, EventArgs e)
        {
            try
            {
                //сохранение пациента
                Patient patient = new(textBox20.Text, textBox18.Text, textBox22.Text,
                    textBox28.Text, textBox26.Text, DateTime.Parse(textBox24.Text), textBox30.Text);
                Data.patients.Add(patient);
                patient.AddP(Data.patients.Count - 1, patient);
                Close();
                patient.EventPatient += new Data.EventDelegate(Patient.Add);
                patient.EventPatient += new Data.EventDelegate(Patient.Remove);
                patient.InvokeEvent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ButtonSaveDoctor(object sender, EventArgs e)
        {
            try
            {
                //сохранение врача
                Doctor doctor = new(textBox12.Text, textBox10.Text, textBox14.Text,
                   textBox4.Text, textBox2.Text, DateTime.Parse(textBox16.Text), textBox6.Text, textBox36.Text);
                Data.doctors.Add(doctor);
                doctor.Add(Data.doctors.Count - 1);
                Close();
                doctor.EventDoctor += new Data.EventDelegate(Doctor.Add);
                doctor.EventDoctor += new Data.EventDelegate(Doctor.Remove);
                doctor.InvokeEvent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SaveService(object sender, EventArgs e)
        {
            try
            {
                //сохранение услуги
                Service service = new(textBox8.Text, textBox32.Text, textBox34.Text);

                Data.services.Add(service);
                Service.Add(Data.services.Count - 1);
                Close();
                service.EventService += new Data.EventDelegate(Service.Add);
                service.EventService += new Data.EventDelegate(Service.Remove);
                service.InvokeEvent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ButtonMakeAnAppointment(object sender, EventArgs e)
        {
            try
            {
                //запись на прием
                Patient patient = null;
                Doctor doctor = null;
                Service service = null;
                foreach (var item in Data.doctors)
                {
                    if (item.ToString() == comboBoxDoctor.SelectedItem.ToString())
                    {
                        doctor = item;
                        break;
                    }
                }
                foreach (var item in Data.patients)
                {
                    if (item.ToString() == comboBoxPatient.SelectedItem.ToString())
                    {
                        patient = item;
                        break;
                    }
                }

                foreach (var item in Data.services)
                {
                    if (item.Name == comboBoxService.SelectedItem.ToString())
                    {
                        service = item;
                        break;
                    }
                }
                WaitingList waitingList = new WaitingList(doctor, patient, service);
                Data.waitingList.Add(waitingList);
                waitingList.Add(Data.waitingList.Count - 1);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void panelMakeAnAppointment_Paint(object sender, PaintEventArgs e) { }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox41.Text = $"{Data.patients[comboBoxPatient.SelectedIndex].StateOfHealth}";
            while (x == 0)
            {
                for (int i = 0; i < Data.services.Count; i++)
                    comboBoxService.Items.Add($"{Data.services[i].Name}");
                x++;
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void panelDoctorSave_Paint(object sender, PaintEventArgs e) { }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox42.Text = $"{Data.services[comboBoxService.SelectedIndex].Position}";
            while (y == 0)
            {
                for (int i = 0; i < Data.doctors.Count; i++)
                    if (Data.doctors[i].Position == Data.services[comboBoxService.SelectedIndex].Position)
                        comboBoxDoctor.Items.Add(Data.doctors[i].ToString());
                y++;
            }
        }
    }
}
