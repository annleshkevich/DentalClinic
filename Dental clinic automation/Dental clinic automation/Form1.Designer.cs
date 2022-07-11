namespace Dental_clinic_automation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.panelPatients = new System.Windows.Forms.Panel();
            this.tablesWaitingList = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tablePatients = new System.Windows.Forms.DataGridView();
            this.Button13 = new System.Windows.Forms.Button();
            this.Button10 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelDoctors = new System.Windows.Forms.Panel();
            this.tableDoctors = new System.Windows.Forms.DataGridView();
            this.Button15 = new System.Windows.Forms.Button();
            this.Button14 = new System.Windows.Forms.Button();
            this.panelServices = new System.Windows.Forms.Panel();
            this.Button17 = new System.Windows.Forms.Button();
            this.Button16 = new System.Windows.Forms.Button();
            this.tableServices = new System.Windows.Forms.DataGridView();
            this.panelMenu.SuspendLayout();
            this.panelPatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablesWaitingList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePatients)).BeginInit();
            this.panelDoctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDoctors)).BeginInit();
            this.panelServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableServices)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.Button5);
            this.panelMenu.Controls.Add(this.panelPatients);
            this.panelMenu.Controls.Add(this.Button7);
            this.panelMenu.Controls.Add(this.Button4);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(800, 450);
            this.panelMenu.TabIndex = 15;
            this.panelMenu.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(176, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 27);
            this.label1.TabIndex = 21;
            this.label1.Text = "Dental Clinic";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 16);
            this.button3.TabIndex = 20;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button2.Location = new System.Drawing.Point(144, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 26);
            this.button2.TabIndex = 19;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.Button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button5.ForeColor = System.Drawing.Color.Black;
            this.Button5.Location = new System.Drawing.Point(480, 8);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(145, 30);
            this.Button5.TabIndex = 1;
            this.Button5.Text = "Врачи";
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.ButtonDoctors);
            // 
            // panelPatients
            // 
            this.panelPatients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(168)))), ((int)(((byte)(130)))));
            this.panelPatients.Controls.Add(this.tablesWaitingList);
            this.panelPatients.Controls.Add(this.button1);
            this.panelPatients.Controls.Add(this.tablePatients);
            this.panelPatients.Controls.Add(this.Button13);
            this.panelPatients.Controls.Add(this.Button10);
            this.panelPatients.Controls.Add(this.Button9);
            this.panelPatients.Location = new System.Drawing.Point(0, 52);
            this.panelPatients.Name = "panelPatients";
            this.panelPatients.Size = new System.Drawing.Size(802, 354);
            this.panelPatients.TabIndex = 18;
            // 
            // tablesWaitingList
            // 
            this.tablesWaitingList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablesWaitingList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.tablesWaitingList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablesWaitingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablesWaitingList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.tablesWaitingList.Location = new System.Drawing.Point(26, 49);
            this.tablesWaitingList.Name = "tablesWaitingList";
            this.tablesWaitingList.RowTemplate.Height = 25;
            this.tablesWaitingList.Size = new System.Drawing.Size(752, 342);
            this.tablesWaitingList.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(325, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Лист ожидания";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tablePatients
            // 
            this.tablePatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablePatients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.tablePatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablePatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablePatients.Location = new System.Drawing.Point(26, 49);
            this.tablePatients.Name = "tablePatients";
            this.tablePatients.RowTemplate.Height = 25;
            this.tablePatients.Size = new System.Drawing.Size(752, 342);
            this.tablePatients.TabIndex = 7;
            this.tablePatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablePatients_CellContentClick);
            // 
            // Button13
            // 
            this.Button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.Button13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button13.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button13.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button13.Location = new System.Drawing.Point(633, 6);
            this.Button13.Name = "Button13";
            this.Button13.Size = new System.Drawing.Size(147, 30);
            this.Button13.TabIndex = 6;
            this.Button13.Text = "Удалиь клиента";
            this.Button13.UseVisualStyleBackColor = false;
            this.Button13.Click += new System.EventHandler(this.ButtonRemovePatient);
            // 
            // Button10
            // 
            this.Button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.Button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button10.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button10.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button10.Location = new System.Drawing.Point(163, 6);
            this.Button10.Name = "Button10";
            this.Button10.Size = new System.Drawing.Size(156, 30);
            this.Button10.TabIndex = 4;
            this.Button10.Text = "Записать на прием";
            this.Button10.UseVisualStyleBackColor = false;
            this.Button10.Click += new System.EventHandler(this.ButtonMakeAnAppointment);
            // 
            // Button9
            // 
            this.Button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.Button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button9.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button9.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button9.Location = new System.Drawing.Point(480, 6);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(145, 30);
            this.Button9.TabIndex = 3;
            this.Button9.Text = "Добавить клиента";
            this.Button9.UseVisualStyleBackColor = false;
            this.Button9.Click += new System.EventHandler(this.ButtonAddPatient);
            // 
            // Button7
            // 
            this.Button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.Button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button7.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button7.ForeColor = System.Drawing.Color.Black;
            this.Button7.Location = new System.Drawing.Point(635, 8);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(145, 30);
            this.Button7.TabIndex = 3;
            this.Button7.Text = "Услуги";
            this.Button7.UseVisualStyleBackColor = false;
            this.Button7.Click += new System.EventHandler(this.ButtonServices);
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button4.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button4.ForeColor = System.Drawing.Color.Black;
            this.Button4.Location = new System.Drawing.Point(325, 8);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(145, 30);
            this.Button4.TabIndex = 0;
            this.Button4.Text = "Пациенты";
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.ButtonPatients);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // panelDoctors
            // 
            this.panelDoctors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(168)))), ((int)(((byte)(130)))));
            this.panelDoctors.Controls.Add(this.tableDoctors);
            this.panelDoctors.Controls.Add(this.Button15);
            this.panelDoctors.Controls.Add(this.Button14);
            this.panelDoctors.Location = new System.Drawing.Point(2, 176);
            this.panelDoctors.Name = "panelDoctors";
            this.panelDoctors.Size = new System.Drawing.Size(800, 90);
            this.panelDoctors.TabIndex = 16;
            // 
            // tableDoctors
            // 
            this.tableDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableDoctors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.tableDoctors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDoctors.Location = new System.Drawing.Point(26, 49);
            this.tableDoctors.Name = "tableDoctors";
            this.tableDoctors.RowTemplate.Height = 25;
            this.tableDoctors.Size = new System.Drawing.Size(752, 342);
            this.tableDoctors.TabIndex = 5;
            // 
            // Button15
            // 
            this.Button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.Button15.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button15.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button15.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button15.Location = new System.Drawing.Point(633, 6);
            this.Button15.Name = "Button15";
            this.Button15.Size = new System.Drawing.Size(145, 30);
            this.Button15.TabIndex = 4;
            this.Button15.Text = "Удалить врача";
            this.Button15.UseVisualStyleBackColor = false;
            this.Button15.Click += new System.EventHandler(this.ButtonRemoveDoctor);
            // 
            // Button14
            // 
            this.Button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.Button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button14.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button14.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button14.Location = new System.Drawing.Point(478, 6);
            this.Button14.Name = "Button14";
            this.Button14.Size = new System.Drawing.Size(145, 30);
            this.Button14.TabIndex = 3;
            this.Button14.Text = "Добавить врача";
            this.Button14.UseVisualStyleBackColor = false;
            this.Button14.Click += new System.EventHandler(this.ButtonAddDoctor);
            // 
            // panelServices
            // 
            this.panelServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(168)))), ((int)(((byte)(130)))));
            this.panelServices.Controls.Add(this.Button17);
            this.panelServices.Controls.Add(this.Button16);
            this.panelServices.Controls.Add(this.tableServices);
            this.panelServices.Location = new System.Drawing.Point(2, 307);
            this.panelServices.Name = "panelServices";
            this.panelServices.Size = new System.Drawing.Size(800, 90);
            this.panelServices.TabIndex = 19;
            // 
            // Button17
            // 
            this.Button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.Button17.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button17.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button17.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button17.Location = new System.Drawing.Point(633, 6);
            this.Button17.Name = "Button17";
            this.Button17.Size = new System.Drawing.Size(145, 30);
            this.Button17.TabIndex = 4;
            this.Button17.Text = "Удалить услугу";
            this.Button17.UseVisualStyleBackColor = false;
            this.Button17.Click += new System.EventHandler(this.ButtonRemoveService);
            // 
            // Button16
            // 
            this.Button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.Button16.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button16.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button16.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button16.Location = new System.Drawing.Point(478, 6);
            this.Button16.Name = "Button16";
            this.Button16.Size = new System.Drawing.Size(145, 30);
            this.Button16.TabIndex = 3;
            this.Button16.Text = "Добавить услугу";
            this.Button16.UseVisualStyleBackColor = false;
            this.Button16.Click += new System.EventHandler(this.ButtonAddService);
            // 
            // tableServices
            // 
            this.tableServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableServices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(163)))), ((int)(((byte)(122)))));
            this.tableServices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableServices.Location = new System.Drawing.Point(26, 49);
            this.tableServices.Name = "tableServices";
            this.tableServices.RowTemplate.Height = 25;
            this.tableServices.Size = new System.Drawing.Size(752, 342);
            this.tableServices.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelServices);
            this.Controls.Add(this.panelDoctors);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dental Clinic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelPatients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablesWaitingList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePatients)).EndInit();
            this.panelDoctors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableDoctors)).EndInit();
            this.panelServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableServices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button Button7;
        private Button Button5;
        private Button Button4;
        private Panel panelMenu;
        private Panel panelDoctors;
        private Panel panelPatients;
        private Button Button10;
        private Button Button9;
        private Button Button13;
        private Button Button15;
        private Button Button14;
        private Panel panelServices;
        private Button Button17;
        private Button Button16;
        internal DataGridView tableServices;
        private DataGridView tablePatients;
        private DataGridView tableDoctors;
        private Button button1;
        private DataGridView tablesWaitingList;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button2;
        private Button button3;
        private Label label1;
    }
}