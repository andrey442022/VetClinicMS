using System.ComponentModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;

namespace VetClinicMS.Windows;

partial class RegisterForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new Container();
        topPanel = new Panel();
        lblTitle = new Label();
        btnLogout = new Button();
        tabControl = new TabControl();
        tabOwners = new TabPage();
        groupBox2 = new GroupBox();
        textBoxEmail = new TextBox();
        label8 = new Label();
        textBoxOwnerPhone = new TextBox();
        label7 = new Label();
        textBoxOwnerName = new TextBox();
        label6 = new Label();
        btnAddOwner = new Button();
        dgvOwners = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
        tabPets = new TabPage();
        dgvPets = new DataGridView();
        dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
        toolPanel = new Panel();
        groupBox1 = new GroupBox();
        numericUpDownPetYears = new NumericUpDown();
        label5 = new Label();
        textBoxPetBreed = new TextBox();
        label4 = new Label();
        textBoxPetType = new TextBox();
        label3 = new Label();
        textBoxPetName = new TextBox();
        label2 = new Label();
        cmbOwner = new ComboBox();
        label1 = new Label();
        btnAddPet = new Button();
        tabVisits = new TabPage();
        rightPanel = new Panel();
        lblVisits = new Label();
        dgvVisits = new DataGridView();
        dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
        leftPanel = new Panel();
        lblNewVisit = new Label();
        lblPet = new Label();
        cmbPet = new ComboBox();
        lblVeterinarian = new Label();
        cmbVeterinarian = new ComboBox();
        lblCabinet = new Label();
        txtCabinet = new TextBox();
        lblDate = new Label();
        dtpVisit = new DateTimePicker();
        lblProcedures = new Label();
        clbProcedures = new CheckedListBox();
        btnCreateVisit = new Button();
        timer1 = new System.Windows.Forms.Timer(components);
        topPanel.SuspendLayout();
        tabControl.SuspendLayout();
        tabOwners.SuspendLayout();
        groupBox2.SuspendLayout();
        ((ISupportInitialize)dgvOwners).BeginInit();
        tabPets.SuspendLayout();
        ((ISupportInitialize)dgvPets).BeginInit();
        toolPanel.SuspendLayout();
        groupBox1.SuspendLayout();
        ((ISupportInitialize)numericUpDownPetYears).BeginInit();
        tabVisits.SuspendLayout();
        rightPanel.SuspendLayout();
        ((ISupportInitialize)dgvVisits).BeginInit();
        leftPanel.SuspendLayout();
        SuspendLayout();
        // 
        // topPanel
        // 
        topPanel.BackColor = Color.FromArgb(0, 120, 215);
        topPanel.Controls.Add(lblTitle);
        topPanel.Controls.Add(btnLogout);
        topPanel.Dock = DockStyle.Top;
        topPanel.Location = new Point(0, 0);
        topPanel.Name = "topPanel";
        topPanel.Size = new Size(1184, 60);
        topPanel.TabIndex = 1;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(20, 15);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(231, 30);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Панель реєстратора";
        // 
        // btnLogout
        // 
        btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnLogout.BackColor = Color.White;
        btnLogout.Location = new Point(1080, 15);
        btnLogout.Name = "btnLogout";
        btnLogout.Size = new Size(90, 30);
        btnLogout.TabIndex = 1;
        btnLogout.Text = "Вихід";
        btnLogout.UseVisualStyleBackColor = false;
        btnLogout.Click += btnLogout_Click;
        // 
        // tabControl
        // 
        tabControl.Controls.Add(tabOwners);
        tabControl.Controls.Add(tabPets);
        tabControl.Controls.Add(tabVisits);
        tabControl.Dock = DockStyle.Fill;
        tabControl.Font = new Font("Segoe UI", 10F);
        tabControl.Location = new Point(0, 60);
        tabControl.Name = "tabControl";
        tabControl.SelectedIndex = 0;
        tabControl.Size = new Size(1184, 601);
        tabControl.TabIndex = 0;
        // 
        // tabOwners
        // 
        tabOwners.Controls.Add(groupBox2);
        tabOwners.Controls.Add(dgvOwners);
        tabOwners.Location = new Point(4, 26);
        tabOwners.Name = "tabOwners";
        tabOwners.Size = new Size(1176, 571);
        tabOwners.TabIndex = 0;
        tabOwners.Text = "Клієнти (Власники)";
        // 
        // groupBox2
        // 
        groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        groupBox2.Controls.Add(textBoxEmail);
        groupBox2.Controls.Add(label8);
        groupBox2.Controls.Add(textBoxOwnerPhone);
        groupBox2.Controls.Add(label7);
        groupBox2.Controls.Add(textBoxOwnerName);
        groupBox2.Controls.Add(label6);
        groupBox2.Controls.Add(btnAddOwner);
        groupBox2.Location = new Point(8, 7);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(1160, 63);
        groupBox2.TabIndex = 7;
        groupBox2.TabStop = false;
        groupBox2.Text = "Додавання клієнта";
        // 
        // textBoxEmail
        // 
        textBoxEmail.Location = new Point(501, 27);
        textBoxEmail.Name = "textBoxEmail";
        textBoxEmail.Size = new Size(160, 25);
        textBoxEmail.TabIndex = 9;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(444, 30);
        label8.Name = "label8";
        label8.Size = new Size(51, 19);
        label8.TabIndex = 8;
        label8.Text = "Пошта";
        // 
        // textBoxOwnerPhone
        // 
        textBoxOwnerPhone.Location = new Point(278, 27);
        textBoxOwnerPhone.Name = "textBoxOwnerPhone";
        textBoxOwnerPhone.Size = new Size(160, 25);
        textBoxOwnerPhone.TabIndex = 7;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(209, 30);
        label7.Name = "label7";
        label7.Size = new Size(63, 19);
        label7.TabIndex = 6;
        label7.Text = "Телефон";
        // 
        // textBoxOwnerName
        // 
        textBoxOwnerName.Location = new Point(43, 27);
        textBoxOwnerName.Name = "textBoxOwnerName";
        textBoxOwnerName.Size = new Size(160, 25);
        textBoxOwnerName.TabIndex = 5;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(6, 30);
        label6.Name = "label6";
        label6.Size = new Size(31, 19);
        label6.TabIndex = 4;
        label6.Text = "ПІБ";
        // 
        // btnAddOwner
        // 
        btnAddOwner.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnAddOwner.Location = new Point(1004, 23);
        btnAddOwner.Name = "btnAddOwner";
        btnAddOwner.Size = new Size(150, 30);
        btnAddOwner.TabIndex = 3;
        btnAddOwner.Text = "Додати клієнта";
        btnAddOwner.Click += button1_Click;
        // 
        // dgvOwners
        // 
        dgvOwners.AllowUserToAddRows = false;
        dgvOwners.AllowUserToDeleteRows = false;
        dgvOwners.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvOwners.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvOwners.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
        dgvOwners.Location = new Point(0, 76);
        dgvOwners.MultiSelect = false;
        dgvOwners.Name = "dgvOwners";
        dgvOwners.ReadOnly = true;
        dgvOwners.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvOwners.Size = new Size(1176, 499);
        dgvOwners.TabIndex = 0;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.DataPropertyName = "ID";
        dataGridViewTextBoxColumn1.HeaderText = "ID";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.DataPropertyName = "FullName";
        dataGridViewTextBoxColumn2.HeaderText = "Ім'я";
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        dataGridViewTextBoxColumn2.ReadOnly = true;
        // 
        // dataGridViewTextBoxColumn3
        // 
        dataGridViewTextBoxColumn3.DataPropertyName = "Phone";
        dataGridViewTextBoxColumn3.HeaderText = "Телефон";
        dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        dataGridViewTextBoxColumn3.ReadOnly = true;
        // 
        // dataGridViewTextBoxColumn4
        // 
        dataGridViewTextBoxColumn4.DataPropertyName = "Email";
        dataGridViewTextBoxColumn4.HeaderText = "Email";
        dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
        dataGridViewTextBoxColumn4.ReadOnly = true;
        // 
        // tabPets
        // 
        tabPets.Controls.Add(dgvPets);
        tabPets.Controls.Add(toolPanel);
        tabPets.Location = new Point(4, 26);
        tabPets.Name = "tabPets";
        tabPets.Size = new Size(1176, 571);
        tabPets.TabIndex = 1;
        tabPets.Text = "Тварини";
        // 
        // dgvPets
        // 
        dgvPets.AllowUserToAddRows = false;
        dgvPets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvPets.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11 });
        dgvPets.Dock = DockStyle.Fill;
        dgvPets.Location = new Point(0, 107);
        dgvPets.Name = "dgvPets";
        dgvPets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvPets.Size = new Size(1176, 464);
        dgvPets.TabIndex = 0;
        // 
        // dataGridViewTextBoxColumn6
        // 
        dataGridViewTextBoxColumn6.DataPropertyName = "Id";
        dataGridViewTextBoxColumn6.HeaderText = "ID";
        dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
        // 
        // dataGridViewTextBoxColumn7
        // 
        dataGridViewTextBoxColumn7.DataPropertyName = "Name";
        dataGridViewTextBoxColumn7.HeaderText = "Кличка";
        dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
        // 
        // dataGridViewTextBoxColumn8
        // 
        dataGridViewTextBoxColumn8.DataPropertyName = "Species";
        dataGridViewTextBoxColumn8.HeaderText = "Вид";
        dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
        // 
        // dataGridViewTextBoxColumn9
        // 
        dataGridViewTextBoxColumn9.DataPropertyName = "Breed";
        dataGridViewTextBoxColumn9.HeaderText = "Порода";
        dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
        // 
        // dataGridViewTextBoxColumn10
        // 
        dataGridViewTextBoxColumn10.DataPropertyName = "Age";
        dataGridViewTextBoxColumn10.HeaderText = "Вік";
        dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
        // 
        // dataGridViewTextBoxColumn11
        // 
        dataGridViewTextBoxColumn11.DataPropertyName = "Owner";
        dataGridViewTextBoxColumn11.HeaderText = "Власник";
        dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
        // 
        // toolPanel
        // 
        toolPanel.Controls.Add(groupBox1);
        toolPanel.Dock = DockStyle.Top;
        toolPanel.Location = new Point(0, 0);
        toolPanel.Name = "toolPanel";
        toolPanel.Padding = new Padding(10);
        toolPanel.Size = new Size(1176, 107);
        toolPanel.TabIndex = 1;
        // 
        // groupBox1
        // 
        groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        groupBox1.Controls.Add(numericUpDownPetYears);
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(textBoxPetBreed);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(textBoxPetType);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(textBoxPetName);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(cmbOwner);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(btnAddPet);
        groupBox1.Location = new Point(3, 7);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(1163, 93);
        groupBox1.TabIndex = 8;
        groupBox1.TabStop = false;
        groupBox1.Text = "Додавання тварини";
        // 
        // numericUpDownPetYears
        // 
        numericUpDownPetYears.Location = new Point(289, 55);
        numericUpDownPetYears.Name = "numericUpDownPetYears";
        numericUpDownPetYears.Size = new Size(155, 25);
        numericUpDownPetYears.TabIndex = 15;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(256, 57);
        label5.Name = "label5";
        label5.Size = new Size(27, 19);
        label5.TabIndex = 14;
        label5.Text = "Вік";
        // 
        // textBoxPetBreed
        // 
        textBoxPetBreed.Location = new Point(75, 54);
        textBoxPetBreed.Name = "textBoxPetBreed";
        textBoxPetBreed.Size = new Size(175, 25);
        textBoxPetBreed.TabIndex = 13;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(11, 57);
        label4.Name = "label4";
        label4.Size = new Size(58, 19);
        label4.TabIndex = 12;
        label4.Text = "Порода";
        // 
        // textBoxPetType
        // 
        textBoxPetType.Location = new Point(536, 24);
        textBoxPetType.Name = "textBoxPetType";
        textBoxPetType.Size = new Size(175, 25);
        textBoxPetType.TabIndex = 11;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(497, 27);
        label3.Name = "label3";
        label3.Size = new Size(33, 19);
        label3.TabIndex = 10;
        label3.Text = "Вид";
        // 
        // textBoxPetName
        // 
        textBoxPetName.Location = new Point(316, 24);
        textBoxPetName.Name = "textBoxPetName";
        textBoxPetName.Size = new Size(175, 25);
        textBoxPetName.TabIndex = 9;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(256, 27);
        label2.Name = "label2";
        label2.Size = new Size(54, 19);
        label2.TabIndex = 7;
        label2.Text = "Кличка";
        // 
        // cmbOwner
        // 
        cmbOwner.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbOwner.FormattingEnabled = true;
        cmbOwner.Location = new Point(75, 24);
        cmbOwner.Name = "cmbOwner";
        cmbOwner.Size = new Size(175, 25);
        cmbOwner.TabIndex = 6;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(9, 27);
        label1.Name = "label1";
        label1.Size = new Size(60, 19);
        label1.TabIndex = 5;
        label1.Text = "Власник";
        // 
        // btnAddPet
        // 
        btnAddPet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnAddPet.Location = new Point(1007, 50);
        btnAddPet.Name = "btnAddPet";
        btnAddPet.Size = new Size(150, 30);
        btnAddPet.TabIndex = 4;
        btnAddPet.Text = "Додати тварину";
        btnAddPet.Click += buttonAddPet_Click;
        // 
        // tabVisits
        // 
        tabVisits.Controls.Add(rightPanel);
        tabVisits.Controls.Add(leftPanel);
        tabVisits.Location = new Point(4, 26);
        tabVisits.Name = "tabVisits";
        tabVisits.Size = new Size(1176, 571);
        tabVisits.TabIndex = 2;
        tabVisits.Text = "Реєстрація візитів";
        // 
        // rightPanel
        // 
        rightPanel.Controls.Add(lblVisits);
        rightPanel.Controls.Add(dgvVisits);
        rightPanel.Dock = DockStyle.Fill;
        rightPanel.Location = new Point(400, 0);
        rightPanel.Name = "rightPanel";
        rightPanel.Padding = new Padding(10);
        rightPanel.Size = new Size(776, 571);
        rightPanel.TabIndex = 0;
        // 
        // lblVisits
        // 
        lblVisits.AutoSize = true;
        lblVisits.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblVisits.Location = new Point(10, 10);
        lblVisits.Name = "lblVisits";
        lblVisits.Size = new Size(176, 21);
        lblVisits.TabIndex = 0;
        lblVisits.Text = "Зареєстровані візити";
        // 
        // dgvVisits
        // 
        dgvVisits.AllowUserToAddRows = false;
        dgvVisits.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvVisits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvVisits.ColumnHeadersHeight = 28;
        dgvVisits.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14, dataGridViewTextBoxColumn15, dataGridViewTextBoxColumn16, dataGridViewTextBoxColumn17, dataGridViewTextBoxColumn18 });
        dgvVisits.Location = new Point(10, 40);
        dgvVisits.Name = "dgvVisits";
        dgvVisits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvVisits.Size = new Size(750, 523);
        dgvVisits.TabIndex = 1;
        // 
        // dataGridViewTextBoxColumn12
        // 
        dataGridViewTextBoxColumn12.DataPropertyName = "Id";
        dataGridViewTextBoxColumn12.HeaderText = "ID";
        dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
        // 
        // dataGridViewTextBoxColumn13
        // 
        dataGridViewTextBoxColumn13.DataPropertyName = "Date";
        dataGridViewTextBoxColumn13.HeaderText = "Дата";
        dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
        // 
        // dataGridViewTextBoxColumn14
        // 
        dataGridViewTextBoxColumn14.DataPropertyName = "Owner";
        dataGridViewTextBoxColumn14.HeaderText = "Власник";
        dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
        // 
        // dataGridViewTextBoxColumn15
        // 
        dataGridViewTextBoxColumn15.DataPropertyName = "Patient";
        dataGridViewTextBoxColumn15.HeaderText = "Тварина";
        dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
        // 
        // dataGridViewTextBoxColumn16
        // 
        dataGridViewTextBoxColumn16.DataPropertyName = "Veterinarian";
        dataGridViewTextBoxColumn16.HeaderText = "Лікар";
        dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
        // 
        // dataGridViewTextBoxColumn17
        // 
        dataGridViewTextBoxColumn17.DataPropertyName = "Office";
        dataGridViewTextBoxColumn17.HeaderText = "Кабінет";
        dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
        // 
        // dataGridViewTextBoxColumn18
        // 
        dataGridViewTextBoxColumn18.DataPropertyName = "Status";
        dataGridViewTextBoxColumn18.HeaderText = "Статус";
        dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
        // 
        // leftPanel
        // 
        leftPanel.Controls.Add(lblNewVisit);
        leftPanel.Controls.Add(lblPet);
        leftPanel.Controls.Add(cmbPet);
        leftPanel.Controls.Add(lblVeterinarian);
        leftPanel.Controls.Add(cmbVeterinarian);
        leftPanel.Controls.Add(lblCabinet);
        leftPanel.Controls.Add(txtCabinet);
        leftPanel.Controls.Add(lblDate);
        leftPanel.Controls.Add(dtpVisit);
        leftPanel.Controls.Add(lblProcedures);
        leftPanel.Controls.Add(clbProcedures);
        leftPanel.Controls.Add(btnCreateVisit);
        leftPanel.Dock = DockStyle.Left;
        leftPanel.Location = new Point(0, 0);
        leftPanel.Name = "leftPanel";
        leftPanel.Padding = new Padding(10);
        leftPanel.Size = new Size(400, 571);
        leftPanel.TabIndex = 1;
        // 
        // lblNewVisit
        // 
        lblNewVisit.AutoSize = true;
        lblNewVisit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblNewVisit.Location = new Point(10, 10);
        lblNewVisit.Name = "lblNewVisit";
        lblNewVisit.Size = new Size(207, 21);
        lblNewVisit.TabIndex = 0;
        lblNewVisit.Text = "Реєстрація нового візиту";
        // 
        // lblPet
        // 
        lblPet.Location = new Point(10, 39);
        lblPet.Name = "lblPet";
        lblPet.Size = new Size(100, 23);
        lblPet.TabIndex = 3;
        lblPet.Text = "Тварина:";
        // 
        // cmbPet
        // 
        cmbPet.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbPet.Location = new Point(10, 64);
        cmbPet.Name = "cmbPet";
        cmbPet.Size = new Size(377, 25);
        cmbPet.TabIndex = 4;
        // 
        // lblVeterinarian
        // 
        lblVeterinarian.Location = new Point(10, 99);
        lblVeterinarian.Name = "lblVeterinarian";
        lblVeterinarian.Size = new Size(100, 23);
        lblVeterinarian.TabIndex = 5;
        lblVeterinarian.Text = "Лікар:";
        // 
        // cmbVeterinarian
        // 
        cmbVeterinarian.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbVeterinarian.Location = new Point(10, 124);
        cmbVeterinarian.Name = "cmbVeterinarian";
        cmbVeterinarian.Size = new Size(377, 25);
        cmbVeterinarian.TabIndex = 6;
        // 
        // lblCabinet
        // 
        lblCabinet.Location = new Point(10, 159);
        lblCabinet.Name = "lblCabinet";
        lblCabinet.Size = new Size(100, 23);
        lblCabinet.TabIndex = 7;
        lblCabinet.Text = "Кабінет:";
        // 
        // txtCabinet
        // 
        txtCabinet.Location = new Point(10, 184);
        txtCabinet.Name = "txtCabinet";
        txtCabinet.Size = new Size(100, 25);
        txtCabinet.TabIndex = 8;
        // 
        // lblDate
        // 
        lblDate.Location = new Point(10, 219);
        lblDate.Name = "lblDate";
        lblDate.Size = new Size(100, 23);
        lblDate.TabIndex = 9;
        lblDate.Text = "Дата та час:";
        // 
        // dtpVisit
        // 
        dtpVisit.CustomFormat = "dd.MM.yyyy HH:mm";
        dtpVisit.Format = DateTimePickerFormat.Custom;
        dtpVisit.Location = new Point(10, 244);
        dtpVisit.Name = "dtpVisit";
        dtpVisit.Size = new Size(377, 25);
        dtpVisit.TabIndex = 10;
        // 
        // lblProcedures
        // 
        lblProcedures.Location = new Point(10, 279);
        lblProcedures.Name = "lblProcedures";
        lblProcedures.Size = new Size(100, 23);
        lblProcedures.TabIndex = 11;
        lblProcedures.Text = "Процедури:";
        // 
        // clbProcedures
        // 
        clbProcedures.Location = new Point(10, 304);
        clbProcedures.Name = "clbProcedures";
        clbProcedures.Size = new Size(377, 144);
        clbProcedures.TabIndex = 12;
        // 
        // btnCreateVisit
        // 
        btnCreateVisit.BackColor = Color.FromArgb(0, 120, 215);
        btnCreateVisit.FlatStyle = FlatStyle.Flat;
        btnCreateVisit.ForeColor = Color.White;
        btnCreateVisit.Location = new Point(10, 523);
        btnCreateVisit.Name = "btnCreateVisit";
        btnCreateVisit.Size = new Size(377, 35);
        btnCreateVisit.TabIndex = 13;
        btnCreateVisit.Text = "Створити візит";
        btnCreateVisit.UseVisualStyleBackColor = false;
        btnCreateVisit.Click += buttonVisitAdd_Click;
        // 
        // timer1
        // 
        timer1.Enabled = true;
        timer1.Interval = 5000;
        timer1.Tick += timer1_Tick;
        // 
        // RegisterForm
        // 
        ClientSize = new Size(1184, 661);
        Controls.Add(tabControl);
        Controls.Add(topPanel);
        Name = "RegisterForm";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Реєстратор - Ветеринарна клініка";
        topPanel.ResumeLayout(false);
        topPanel.PerformLayout();
        tabControl.ResumeLayout(false);
        tabOwners.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ((ISupportInitialize)dgvOwners).EndInit();
        tabPets.ResumeLayout(false);
        ((ISupportInitialize)dgvPets).EndInit();
        toolPanel.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((ISupportInitialize)numericUpDownPetYears).EndInit();
        tabVisits.ResumeLayout(false);
        rightPanel.ResumeLayout(false);
        rightPanel.PerformLayout();
        ((ISupportInitialize)dgvVisits).EndInit();
        leftPanel.ResumeLayout(false);
        leftPanel.PerformLayout();
        ResumeLayout(false);
    }

    private Panel topPanel;
    private Label lblTitle;
    private Button btnLogout;
    private TabControl tabControl;
    private TabPage tabOwners;
    private TabPage tabPets;
    private TabPage tabVisits;
    private Panel toolPanel;
    private DataGridView dgvOwners;
    private Button btnAddPet;
    private DataGridView dgvPets;
    private Panel leftPanel;
    private Label lblNewVisit;
    private Label lblPet;
    private ComboBox cmbPet;
    private Label lblVeterinarian;
    private ComboBox cmbVeterinarian;
    private Label lblCabinet;
    private TextBox txtCabinet;
    private Label lblDate;
    private DateTimePicker dtpVisit;
    private Label lblProcedures;
    private CheckedListBox clbProcedures;
    private Button btnCreateVisit;
    private Panel rightPanel;
    private Label lblVisits;
    private DataGridView dgvVisits;

    #endregion
    private Button btnAddOwner;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    private GroupBox groupBox1;
    private ComboBox cmbOwner;
    private Label label1;
    private TextBox textBoxPetName;
    private Label label2;
    private TextBox textBoxPetBreed;
    private Label label4;
    private TextBox textBoxPetType;
    private Label label3;
    private NumericUpDown numericUpDownPetYears;
    private Label label5;
    private GroupBox groupBox2;
    private Label label6;
    private TextBox textBoxOwnerName;
    private TextBox textBoxEmail;
    private Label label8;
    private TextBox textBoxOwnerPhone;
    private Label label7;
    private System.Windows.Forms.Timer timer1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
}