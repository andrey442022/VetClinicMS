using System.ComponentModel;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using Button = System.Windows.Forms.Button;
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;

namespace VetClinicMS.Windows;

partial class AdminForm
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
        topPanel = new Panel();
        lblTitle = new Label();
        btnLogout = new Button();
        tabControl = new TabControl();
        tabVeterinarians = new TabPage();
        groupBox1 = new GroupBox();
        textBoxVetSpec = new TextBox();
        label4 = new Label();
        textBoxVetName = new TextBox();
        label2 = new Label();
        btnAddVet = new Button();
        dgvVeterinarians = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
        tabProcedures = new TabPage();
        dgvProcedures = new DataGridView();
        dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn13 = new DataGridViewCheckBoxColumn();
        toolPanel = new Panel();
        groupBox2 = new GroupBox();
        numericUpDownProcedureCostPrice = new NumericUpDown();
        numericUpDownProcedurePrice = new NumericUpDown();
        textBoxTags = new TextBox();
        label9 = new Label();
        label8 = new Label();
        btnAddProcedure = new Button();
        label6 = new Label();
        textBoxProcedureName = new TextBox();
        label7 = new Label();
        tabStatistics = new TabPage();
        tabDetails = new TabControl();
        tabByVets = new TabPage();
        dgvVetStats = new DataGridView();
        dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
        tabByCabinets = new TabPage();
        dgvCabinetStats = new DataGridView();
        dataGridViewTextBoxColumn19 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn20 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn21 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn22 = new DataGridViewTextBoxColumn();
        tabByProcedures = new TabPage();
        dgvProcedureStats = new DataGridView();
        dataGridViewTextBoxColumn23 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn24 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn25 = new DataGridViewTextBoxColumn();
        summaryPanel = new Panel();
        cardRevenue = new Panel();
        lblTitleRevenue = new Label();
        lblValueRevenue = new Label();
        cardCompleted = new Panel();
        label3 = new Label();
        labelVisitCompleted = new Label();
        filterPanel = new Panel();
        lblPeriod = new Label();
        cmbPeriod = new ComboBox();
        lblFrom = new Label();
        dtpFrom = new DateTimePicker();
        lblTo = new Label();
        dtpTo = new DateTimePicker();
        btnLoadStatistics = new Button();
        lblTitleVisits = new Label();
        lblValueVisits = new Label();
        lblTitleCompleted = new Label();
        lblValueCompleted = new Label();
        lblTitleAvgTime = new Label();
        lblValueAvgTime = new Label();
        topPanel.SuspendLayout();
        tabControl.SuspendLayout();
        tabVeterinarians.SuspendLayout();
        groupBox1.SuspendLayout();
        ((ISupportInitialize)dgvVeterinarians).BeginInit();
        tabProcedures.SuspendLayout();
        ((ISupportInitialize)dgvProcedures).BeginInit();
        toolPanel.SuspendLayout();
        groupBox2.SuspendLayout();
        ((ISupportInitialize)numericUpDownProcedureCostPrice).BeginInit();
        ((ISupportInitialize)numericUpDownProcedurePrice).BeginInit();
        tabStatistics.SuspendLayout();
        tabDetails.SuspendLayout();
        tabByVets.SuspendLayout();
        ((ISupportInitialize)dgvVetStats).BeginInit();
        tabByCabinets.SuspendLayout();
        ((ISupportInitialize)dgvCabinetStats).BeginInit();
        tabByProcedures.SuspendLayout();
        ((ISupportInitialize)dgvProcedureStats).BeginInit();
        summaryPanel.SuspendLayout();
        cardRevenue.SuspendLayout();
        cardCompleted.SuspendLayout();
        filterPanel.SuspendLayout();
        SuspendLayout();
        // 
        // topPanel
        // 
        topPanel.BackColor = Color.FromArgb(156, 39, 176);
        topPanel.Controls.Add(lblTitle);
        topPanel.Controls.Add(btnLogout);
        topPanel.Dock = DockStyle.Top;
        topPanel.Location = new Point(0, 0);
        topPanel.Name = "topPanel";
        topPanel.Size = new Size(1384, 60);
        topPanel.TabIndex = 1;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(20, 15);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(262, 30);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Панель адміністратора";
        // 
        // btnLogout
        // 
        btnLogout.BackColor = Color.White;
        btnLogout.Location = new Point(1280, 15);
        btnLogout.Name = "btnLogout";
        btnLogout.Size = new Size(90, 30);
        btnLogout.TabIndex = 1;
        btnLogout.Text = "Вихід";
        btnLogout.UseVisualStyleBackColor = false;
        btnLogout.Click += btnLogout_Click;
        // 
        // tabControl
        // 
        tabControl.Controls.Add(tabVeterinarians);
        tabControl.Controls.Add(tabProcedures);
        tabControl.Controls.Add(tabStatistics);
        tabControl.Dock = DockStyle.Fill;
        tabControl.Font = new Font("Segoe UI", 10F);
        tabControl.Location = new Point(0, 60);
        tabControl.Name = "tabControl";
        tabControl.SelectedIndex = 0;
        tabControl.Size = new Size(1384, 701);
        tabControl.TabIndex = 0;
        // 
        // tabVeterinarians
        // 
        tabVeterinarians.Controls.Add(groupBox1);
        tabVeterinarians.Controls.Add(dgvVeterinarians);
        tabVeterinarians.Location = new Point(4, 26);
        tabVeterinarians.Name = "tabVeterinarians";
        tabVeterinarians.Size = new Size(1376, 671);
        tabVeterinarians.TabIndex = 0;
        tabVeterinarians.Text = "Лікарі";
        // 
        // groupBox1
        // 
        groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        groupBox1.Controls.Add(textBoxVetSpec);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(textBoxVetName);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(btnAddVet);
        groupBox1.Location = new Point(16, 14);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(1350, 67);
        groupBox1.TabIndex = 2;
        groupBox1.TabStop = false;
        groupBox1.Text = "Додавання лікарая";
        // 
        // textBoxVetSpec
        // 
        textBoxVetSpec.Location = new Point(323, 28);
        textBoxVetSpec.Name = "textBoxVetSpec";
        textBoxVetSpec.Size = new Size(175, 25);
        textBoxVetSpec.TabIndex = 5;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(225, 31);
        label4.Name = "label4";
        label4.Size = new Size(92, 19);
        label4.TabIndex = 4;
        label4.Text = "Спеціалізація";
        // 
        // textBoxVetName
        // 
        textBoxVetName.Location = new Point(43, 28);
        textBoxVetName.Name = "textBoxVetName";
        textBoxVetName.Size = new Size(175, 25);
        textBoxVetName.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(6, 31);
        label2.Name = "label2";
        label2.Size = new Size(31, 19);
        label2.TabIndex = 2;
        label2.Text = "ПІБ";
        // 
        // btnAddVet
        // 
        btnAddVet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnAddVet.BackColor = Color.FromArgb(76, 175, 80);
        btnAddVet.FlatStyle = FlatStyle.Flat;
        btnAddVet.ForeColor = Color.White;
        btnAddVet.Location = new Point(1194, 24);
        btnAddVet.Name = "btnAddVet";
        btnAddVet.Size = new Size(150, 30);
        btnAddVet.TabIndex = 1;
        btnAddVet.Text = "Додати лікаря";
        btnAddVet.UseVisualStyleBackColor = false;
        btnAddVet.Click += btnAddVet_Click;
        // 
        // dgvVeterinarians
        // 
        dgvVeterinarians.AllowUserToAddRows = false;
        dgvVeterinarians.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvVeterinarians.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvVeterinarians.ColumnHeadersHeight = 28;
        dgvVeterinarians.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
        dgvVeterinarians.Location = new Point(3, 87);
        dgvVeterinarians.Name = "dgvVeterinarians";
        dgvVeterinarians.ReadOnly = true;
        dgvVeterinarians.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvVeterinarians.Size = new Size(1373, 576);
        dgvVeterinarians.TabIndex = 0;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.DataPropertyName = "Id";
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
        dataGridViewTextBoxColumn3.DataPropertyName = "Specialization";
        dataGridViewTextBoxColumn3.HeaderText = "Спеціалізація";
        dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        dataGridViewTextBoxColumn3.ReadOnly = true;
        // 
        // tabProcedures
        // 
        tabProcedures.Controls.Add(dgvProcedures);
        tabProcedures.Controls.Add(toolPanel);
        tabProcedures.Location = new Point(4, 26);
        tabProcedures.Name = "tabProcedures";
        tabProcedures.Size = new Size(1376, 671);
        tabProcedures.TabIndex = 1;
        tabProcedures.Text = "Процедури";
        // 
        // dgvProcedures
        // 
        dgvProcedures.AllowUserToAddRows = false;
        dgvProcedures.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvProcedures.ColumnHeadersHeight = 28;
        dgvProcedures.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13 });
        dgvProcedures.Dock = DockStyle.Fill;
        dgvProcedures.Location = new Point(0, 98);
        dgvProcedures.Name = "dgvProcedures";
        dgvProcedures.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvProcedures.Size = new Size(1376, 573);
        dgvProcedures.TabIndex = 0;
        dgvProcedures.CellValueChanged += dgvProcedures_CellValueChanged;
        // 
        // dataGridViewTextBoxColumn8
        // 
        dataGridViewTextBoxColumn8.DataPropertyName = "Id";
        dataGridViewTextBoxColumn8.HeaderText = "ID";
        dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
        dataGridViewTextBoxColumn8.ReadOnly = true;
        // 
        // dataGridViewTextBoxColumn9
        // 
        dataGridViewTextBoxColumn9.DataPropertyName = "Name";
        dataGridViewTextBoxColumn9.HeaderText = "Назва";
        dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
        dataGridViewTextBoxColumn9.ReadOnly = true;
        // 
        // dataGridViewTextBoxColumn10
        // 
        dataGridViewTextBoxColumn10.DataPropertyName = "Price";
        dataGridViewTextBoxColumn10.HeaderText = "Вартість";
        dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
        dataGridViewTextBoxColumn10.ReadOnly = true;
        // 
        // dataGridViewTextBoxColumn11
        // 
        dataGridViewTextBoxColumn11.DataPropertyName = "CostPrice";
        dataGridViewTextBoxColumn11.HeaderText = "Собівартість";
        dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
        dataGridViewTextBoxColumn11.ReadOnly = true;
        // 
        // dataGridViewTextBoxColumn12
        // 
        dataGridViewTextBoxColumn12.DataPropertyName = "TagsString";
        dataGridViewTextBoxColumn12.HeaderText = "Теги";
        dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
        dataGridViewTextBoxColumn12.ReadOnly = true;
        // 
        // dataGridViewTextBoxColumn13
        // 
        dataGridViewTextBoxColumn13.DataPropertyName = "IsBlocked";
        dataGridViewTextBoxColumn13.HeaderText = "Заблокована";
        dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
        dataGridViewTextBoxColumn13.Resizable = DataGridViewTriState.True;
        dataGridViewTextBoxColumn13.SortMode = DataGridViewColumnSortMode.Automatic;
        // 
        // toolPanel
        // 
        toolPanel.Controls.Add(groupBox2);
        toolPanel.Dock = DockStyle.Top;
        toolPanel.Location = new Point(0, 0);
        toolPanel.Name = "toolPanel";
        toolPanel.Padding = new Padding(10);
        toolPanel.Size = new Size(1376, 98);
        toolPanel.TabIndex = 1;
        // 
        // groupBox2
        // 
        groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        groupBox2.Controls.Add(numericUpDownProcedureCostPrice);
        groupBox2.Controls.Add(numericUpDownProcedurePrice);
        groupBox2.Controls.Add(textBoxTags);
        groupBox2.Controls.Add(label9);
        groupBox2.Controls.Add(label8);
        groupBox2.Controls.Add(btnAddProcedure);
        groupBox2.Controls.Add(label6);
        groupBox2.Controls.Add(textBoxProcedureName);
        groupBox2.Controls.Add(label7);
        groupBox2.Location = new Point(13, 13);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(1350, 72);
        groupBox2.TabIndex = 5;
        groupBox2.TabStop = false;
        groupBox2.Text = "Додавання лікарая";
        // 
        // numericUpDownProcedureCostPrice
        // 
        numericUpDownProcedureCostPrice.Location = new Point(585, 28);
        numericUpDownProcedureCostPrice.Name = "numericUpDownProcedureCostPrice";
        numericUpDownProcedureCostPrice.Size = new Size(175, 25);
        numericUpDownProcedureCostPrice.TabIndex = 11;
        // 
        // numericUpDownProcedurePrice
        // 
        numericUpDownProcedurePrice.Location = new Point(311, 28);
        numericUpDownProcedurePrice.Name = "numericUpDownProcedurePrice";
        numericUpDownProcedurePrice.Size = new Size(175, 25);
        numericUpDownProcedurePrice.TabIndex = 10;
        // 
        // textBoxTags
        // 
        textBoxTags.Location = new Point(808, 28);
        textBoxTags.Name = "textBoxTags";
        textBoxTags.PlaceholderText = "тег1, тег2";
        textBoxTags.Size = new Size(175, 25);
        textBoxTags.TabIndex = 9;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(766, 31);
        label9.Name = "label9";
        label9.Size = new Size(36, 19);
        label9.TabIndex = 8;
        label9.Text = "Теги";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(492, 31);
        label8.Name = "label8";
        label8.Size = new Size(87, 19);
        label8.TabIndex = 6;
        label8.Text = "Собівартість";
        // 
        // btnAddProcedure
        // 
        btnAddProcedure.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnAddProcedure.BackColor = Color.FromArgb(33, 150, 243);
        btnAddProcedure.FlatStyle = FlatStyle.Flat;
        btnAddProcedure.ForeColor = Color.White;
        btnAddProcedure.Location = new Point(1173, 24);
        btnAddProcedure.Name = "btnAddProcedure";
        btnAddProcedure.Size = new Size(160, 30);
        btnAddProcedure.TabIndex = 4;
        btnAddProcedure.Text = "Додати процедуру";
        btnAddProcedure.UseVisualStyleBackColor = false;
        btnAddProcedure.Click += btnAddProcedure_Click;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(239, 31);
        label6.Name = "label6";
        label6.Size = new Size(66, 19);
        label6.TabIndex = 4;
        label6.Text = "Варстість";
        // 
        // textBoxProcedureName
        // 
        textBoxProcedureName.Location = new Point(58, 28);
        textBoxProcedureName.Name = "textBoxProcedureName";
        textBoxProcedureName.Size = new Size(175, 25);
        textBoxProcedureName.TabIndex = 3;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(6, 31);
        label7.Name = "label7";
        label7.Size = new Size(46, 19);
        label7.TabIndex = 2;
        label7.Text = "Назва";
        // 
        // tabStatistics
        // 
        tabStatistics.Controls.Add(tabDetails);
        tabStatistics.Controls.Add(summaryPanel);
        tabStatistics.Controls.Add(filterPanel);
        tabStatistics.Location = new Point(4, 26);
        tabStatistics.Name = "tabStatistics";
        tabStatistics.Size = new Size(1376, 671);
        tabStatistics.TabIndex = 2;
        tabStatistics.Text = "Статистика";
        // 
        // tabDetails
        // 
        tabDetails.Controls.Add(tabByVets);
        tabDetails.Controls.Add(tabByCabinets);
        tabDetails.Controls.Add(tabByProcedures);
        tabDetails.Dock = DockStyle.Fill;
        tabDetails.Font = new Font("Segoe UI", 9F);
        tabDetails.Location = new Point(0, 171);
        tabDetails.Name = "tabDetails";
        tabDetails.SelectedIndex = 0;
        tabDetails.Size = new Size(1376, 500);
        tabDetails.TabIndex = 0;
        // 
        // tabByVets
        // 
        tabByVets.Controls.Add(dgvVetStats);
        tabByVets.Location = new Point(4, 24);
        tabByVets.Name = "tabByVets";
        tabByVets.Size = new Size(1368, 472);
        tabByVets.TabIndex = 0;
        tabByVets.Text = "По лікарях";
        // 
        // dgvVetStats
        // 
        dgvVetStats.AllowUserToAddRows = false;
        dgvVetStats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvVetStats.ColumnHeadersHeight = 28;
        dgvVetStats.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn15, dataGridViewTextBoxColumn16, dataGridViewTextBoxColumn17, dataGridViewTextBoxColumn18 });
        dgvVetStats.Dock = DockStyle.Fill;
        dgvVetStats.Location = new Point(0, 0);
        dgvVetStats.Name = "dgvVetStats";
        dgvVetStats.Size = new Size(1368, 472);
        dgvVetStats.TabIndex = 0;
        // 
        // dataGridViewTextBoxColumn15
        // 
        dataGridViewTextBoxColumn15.DataPropertyName = "Vet";
        dataGridViewTextBoxColumn15.HeaderText = "Лікар";
        dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
        // 
        // dataGridViewTextBoxColumn16
        // 
        dataGridViewTextBoxColumn16.DataPropertyName = "Visit";
        dataGridViewTextBoxColumn16.HeaderText = "Візитів";
        dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
        // 
        // dataGridViewTextBoxColumn17
        // 
        dataGridViewTextBoxColumn17.DataPropertyName = "Sum";
        dataGridViewTextBoxColumn17.HeaderText = "Виручка";
        dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
        // 
        // dataGridViewTextBoxColumn18
        // 
        dataGridViewTextBoxColumn18.DataPropertyName = "Average";
        dataGridViewTextBoxColumn18.HeaderText = "Сер. час (хв)";
        dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
        // 
        // tabByCabinets
        // 
        tabByCabinets.Controls.Add(dgvCabinetStats);
        tabByCabinets.Location = new Point(4, 24);
        tabByCabinets.Name = "tabByCabinets";
        tabByCabinets.Size = new Size(1368, 472);
        tabByCabinets.TabIndex = 1;
        tabByCabinets.Text = "По кабінетах";
        // 
        // dgvCabinetStats
        // 
        dgvCabinetStats.AllowUserToAddRows = false;
        dgvCabinetStats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvCabinetStats.ColumnHeadersHeight = 28;
        dgvCabinetStats.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn19, dataGridViewTextBoxColumn20, dataGridViewTextBoxColumn21, dataGridViewTextBoxColumn22 });
        dgvCabinetStats.Dock = DockStyle.Fill;
        dgvCabinetStats.Location = new Point(0, 0);
        dgvCabinetStats.Name = "dgvCabinetStats";
        dgvCabinetStats.Size = new Size(1368, 472);
        dgvCabinetStats.TabIndex = 0;
        // 
        // dataGridViewTextBoxColumn19
        // 
        dataGridViewTextBoxColumn19.DataPropertyName = "Office";
        dataGridViewTextBoxColumn19.HeaderText = "Кабінет";
        dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
        // 
        // dataGridViewTextBoxColumn20
        // 
        dataGridViewTextBoxColumn20.DataPropertyName = "Visit";
        dataGridViewTextBoxColumn20.HeaderText = "Візитів";
        dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
        // 
        // dataGridViewTextBoxColumn21
        // 
        dataGridViewTextBoxColumn21.DataPropertyName = "Average";
        dataGridViewTextBoxColumn21.HeaderText = "Сер. час (хв)";
        dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
        // 
        // dataGridViewTextBoxColumn22
        // 
        dataGridViewTextBoxColumn22.DataPropertyName = "Util";
        dataGridViewTextBoxColumn22.HeaderText = "Завантаженість %";
        dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
        // 
        // tabByProcedures
        // 
        tabByProcedures.Controls.Add(dgvProcedureStats);
        tabByProcedures.Location = new Point(4, 24);
        tabByProcedures.Name = "tabByProcedures";
        tabByProcedures.Size = new Size(1368, 472);
        tabByProcedures.TabIndex = 2;
        tabByProcedures.Text = "По процедурах";
        // 
        // dgvProcedureStats
        // 
        dgvProcedureStats.AllowUserToAddRows = false;
        dgvProcedureStats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvProcedureStats.ColumnHeadersHeight = 28;
        dgvProcedureStats.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn23, dataGridViewTextBoxColumn24, dataGridViewTextBoxColumn25 });
        dgvProcedureStats.Dock = DockStyle.Fill;
        dgvProcedureStats.Location = new Point(0, 0);
        dgvProcedureStats.Name = "dgvProcedureStats";
        dgvProcedureStats.Size = new Size(1368, 472);
        dgvProcedureStats.TabIndex = 0;
        // 
        // dataGridViewTextBoxColumn23
        // 
        dataGridViewTextBoxColumn23.DataPropertyName = "Procedure";
        dataGridViewTextBoxColumn23.HeaderText = "Процедура";
        dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
        // 
        // dataGridViewTextBoxColumn24
        // 
        dataGridViewTextBoxColumn24.DataPropertyName = "Count";
        dataGridViewTextBoxColumn24.HeaderText = "К-сть виконань";
        dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
        // 
        // dataGridViewTextBoxColumn25
        // 
        dataGridViewTextBoxColumn25.DataPropertyName = "Sum";
        dataGridViewTextBoxColumn25.HeaderText = "Виручка";
        dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
        // 
        // summaryPanel
        // 
        summaryPanel.Controls.Add(cardRevenue);
        summaryPanel.Controls.Add(cardCompleted);
        summaryPanel.Dock = DockStyle.Top;
        summaryPanel.Location = new Point(0, 51);
        summaryPanel.Name = "summaryPanel";
        summaryPanel.Padding = new Padding(10);
        summaryPanel.Size = new Size(1376, 120);
        summaryPanel.TabIndex = 1;
        // 
        // cardRevenue
        // 
        cardRevenue.BackColor = Color.FromArgb(76, 175, 80);
        cardRevenue.Controls.Add(lblTitleRevenue);
        cardRevenue.Controls.Add(lblValueRevenue);
        cardRevenue.Location = new Point(10, 10);
        cardRevenue.Name = "cardRevenue";
        cardRevenue.Padding = new Padding(15);
        cardRevenue.Size = new Size(280, 100);
        cardRevenue.TabIndex = 0;
        // 
        // lblTitleRevenue
        // 
        lblTitleRevenue.AutoSize = true;
        lblTitleRevenue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblTitleRevenue.ForeColor = Color.White;
        lblTitleRevenue.Location = new Point(18, 15);
        lblTitleRevenue.Name = "lblTitleRevenue";
        lblTitleRevenue.Size = new Size(68, 19);
        lblTitleRevenue.TabIndex = 0;
        lblTitleRevenue.Text = "Виручка";
        // 
        // lblValueRevenue
        // 
        lblValueRevenue.AutoSize = true;
        lblValueRevenue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblValueRevenue.ForeColor = Color.White;
        lblValueRevenue.Location = new Point(18, 45);
        lblValueRevenue.Name = "lblValueRevenue";
        lblValueRevenue.Size = new Size(85, 37);
        lblValueRevenue.TabIndex = 1;
        lblValueRevenue.Text = "0 грн";
        // 
        // cardCompleted
        // 
        cardCompleted.BackColor = Color.FromArgb(255, 152, 0);
        cardCompleted.Controls.Add(label3);
        cardCompleted.Controls.Add(labelVisitCompleted);
        cardCompleted.Location = new Point(305, 10);
        cardCompleted.Name = "cardCompleted";
        cardCompleted.Padding = new Padding(15);
        cardCompleted.Size = new Size(280, 100);
        cardCompleted.TabIndex = 2;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        label3.ForeColor = Color.White;
        label3.Location = new Point(18, 15);
        label3.Name = "label3";
        label3.Size = new Size(88, 19);
        label3.TabIndex = 4;
        label3.Text = "Завершено";
        // 
        // labelVisitCompleted
        // 
        labelVisitCompleted.AutoSize = true;
        labelVisitCompleted.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        labelVisitCompleted.ForeColor = Color.White;
        labelVisitCompleted.Location = new Point(18, 45);
        labelVisitCompleted.Name = "labelVisitCompleted";
        labelVisitCompleted.Size = new Size(33, 37);
        labelVisitCompleted.TabIndex = 5;
        labelVisitCompleted.Text = "0";
        // 
        // filterPanel
        // 
        filterPanel.Controls.Add(lblPeriod);
        filterPanel.Controls.Add(cmbPeriod);
        filterPanel.Controls.Add(lblFrom);
        filterPanel.Controls.Add(dtpFrom);
        filterPanel.Controls.Add(lblTo);
        filterPanel.Controls.Add(dtpTo);
        filterPanel.Controls.Add(btnLoadStatistics);
        filterPanel.Dock = DockStyle.Top;
        filterPanel.Location = new Point(0, 0);
        filterPanel.Name = "filterPanel";
        filterPanel.Padding = new Padding(10);
        filterPanel.Size = new Size(1376, 51);
        filterPanel.TabIndex = 2;
        // 
        // lblPeriod
        // 
        lblPeriod.Location = new Point(10, 15);
        lblPeriod.Name = "lblPeriod";
        lblPeriod.Size = new Size(70, 23);
        lblPeriod.TabIndex = 0;
        lblPeriod.Text = "Період:";
        // 
        // cmbPeriod
        // 
        cmbPeriod.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbPeriod.Items.AddRange(new object[] { "Сьогодні", "Тиждень", "Місяць", "Рік", "Довільний" });
        cmbPeriod.Location = new Point(90, 12);
        cmbPeriod.Name = "cmbPeriod";
        cmbPeriod.Size = new Size(150, 25);
        cmbPeriod.TabIndex = 1;
        // 
        // lblFrom
        // 
        lblFrom.Location = new Point(260, 15);
        lblFrom.Name = "lblFrom";
        lblFrom.Size = new Size(40, 23);
        lblFrom.TabIndex = 2;
        lblFrom.Text = "Від:";
        // 
        // dtpFrom
        // 
        dtpFrom.Format = DateTimePickerFormat.Short;
        dtpFrom.Location = new Point(305, 12);
        dtpFrom.Name = "dtpFrom";
        dtpFrom.Size = new Size(150, 25);
        dtpFrom.TabIndex = 3;
        // 
        // lblTo
        // 
        lblTo.Location = new Point(475, 15);
        lblTo.Name = "lblTo";
        lblTo.Size = new Size(40, 23);
        lblTo.TabIndex = 4;
        lblTo.Text = "До:";
        // 
        // dtpTo
        // 
        dtpTo.Format = DateTimePickerFormat.Short;
        dtpTo.Location = new Point(520, 12);
        dtpTo.Name = "dtpTo";
        dtpTo.Size = new Size(150, 25);
        dtpTo.TabIndex = 5;
        dtpTo.Value = new DateTime(2025, 11, 8, 11, 47, 41, 32);
        // 
        // btnLoadStatistics
        // 
        btnLoadStatistics.BackColor = Color.FromArgb(156, 39, 176);
        btnLoadStatistics.FlatStyle = FlatStyle.Flat;
        btnLoadStatistics.ForeColor = Color.White;
        btnLoadStatistics.Location = new Point(690, 10);
        btnLoadStatistics.Name = "btnLoadStatistics";
        btnLoadStatistics.Size = new Size(130, 30);
        btnLoadStatistics.TabIndex = 6;
        btnLoadStatistics.Text = "Завантажити";
        btnLoadStatistics.UseVisualStyleBackColor = false;
        btnLoadStatistics.Click += btnLoadStatistics_Click;
        // 
        // lblTitleVisits
        // 
        lblTitleVisits.AutoSize = true;
        lblTitleVisits.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblTitleVisits.ForeColor = Color.White;
        lblTitleVisits.Location = new Point(15, 15);
        lblTitleVisits.Name = "lblTitleVisits";
        lblTitleVisits.Size = new Size(100, 23);
        lblTitleVisits.TabIndex = 0;
        lblTitleVisits.Text = "Візитів";
        // 
        // lblValueVisits
        // 
        lblValueVisits.AutoSize = true;
        lblValueVisits.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblValueVisits.ForeColor = Color.White;
        lblValueVisits.Location = new Point(15, 45);
        lblValueVisits.Name = "lblValueVisits";
        lblValueVisits.Size = new Size(100, 23);
        lblValueVisits.TabIndex = 0;
        lblValueVisits.Text = "0";
        // 
        // lblTitleCompleted
        // 
        lblTitleCompleted.AutoSize = true;
        lblTitleCompleted.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblTitleCompleted.ForeColor = Color.White;
        lblTitleCompleted.Location = new Point(15, 15);
        lblTitleCompleted.Name = "lblTitleCompleted";
        lblTitleCompleted.Size = new Size(100, 23);
        lblTitleCompleted.TabIndex = 0;
        lblTitleCompleted.Text = "Завершено";
        // 
        // lblValueCompleted
        // 
        lblValueCompleted.AutoSize = true;
        lblValueCompleted.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblValueCompleted.ForeColor = Color.White;
        lblValueCompleted.Location = new Point(15, 45);
        lblValueCompleted.Name = "lblValueCompleted";
        lblValueCompleted.Size = new Size(100, 23);
        lblValueCompleted.TabIndex = 0;
        lblValueCompleted.Text = "0";
        // 
        // lblTitleAvgTime
        // 
        lblTitleAvgTime.AutoSize = true;
        lblTitleAvgTime.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblTitleAvgTime.ForeColor = Color.White;
        lblTitleAvgTime.Location = new Point(15, 15);
        lblTitleAvgTime.Name = "lblTitleAvgTime";
        lblTitleAvgTime.Size = new Size(100, 23);
        lblTitleAvgTime.TabIndex = 0;
        lblTitleAvgTime.Text = "Сер. час";
        // 
        // lblValueAvgTime
        // 
        lblValueAvgTime.AutoSize = true;
        lblValueAvgTime.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblValueAvgTime.ForeColor = Color.White;
        lblValueAvgTime.Location = new Point(15, 45);
        lblValueAvgTime.Name = "lblValueAvgTime";
        lblValueAvgTime.Size = new Size(100, 23);
        lblValueAvgTime.TabIndex = 0;
        lblValueAvgTime.Text = "0";
        // 
        // AdminForm
        // 
        ClientSize = new Size(1384, 761);
        Controls.Add(tabControl);
        Controls.Add(topPanel);
        Name = "AdminForm";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Адміністратор - Ветеринарна клініка";
        topPanel.ResumeLayout(false);
        topPanel.PerformLayout();
        tabControl.ResumeLayout(false);
        tabVeterinarians.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((ISupportInitialize)dgvVeterinarians).EndInit();
        tabProcedures.ResumeLayout(false);
        ((ISupportInitialize)dgvProcedures).EndInit();
        toolPanel.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ((ISupportInitialize)numericUpDownProcedureCostPrice).EndInit();
        ((ISupportInitialize)numericUpDownProcedurePrice).EndInit();
        tabStatistics.ResumeLayout(false);
        tabDetails.ResumeLayout(false);
        tabByVets.ResumeLayout(false);
        ((ISupportInitialize)dgvVetStats).EndInit();
        tabByCabinets.ResumeLayout(false);
        ((ISupportInitialize)dgvCabinetStats).EndInit();
        tabByProcedures.ResumeLayout(false);
        ((ISupportInitialize)dgvProcedureStats).EndInit();
        summaryPanel.ResumeLayout(false);
        cardRevenue.ResumeLayout(false);
        cardRevenue.PerformLayout();
        cardCompleted.ResumeLayout(false);
        cardCompleted.PerformLayout();
        filterPanel.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel topPanel;
    private Label lblTitle;
    private Button btnLogout;
    private TabControl tabControl;
    private TabPage tabVeterinarians;
    private TabPage tabProcedures;
    private TabPage tabStatistics;
    private Panel toolPanel;
    private DataGridView dgvVeterinarians;
    private Button btnAddProcedure;
    private DataGridView dgvProcedures;
    private Panel filterPanel;
    private Label lblPeriod;
    private ComboBox cmbPeriod;
    private Label lblFrom;
    private DateTimePicker dtpFrom;
    private Label lblTo;
    private DateTimePicker dtpTo;
    private Button btnLoadStatistics;
    private Panel summaryPanel;
    private TabControl tabDetails;
    private TabPage tabByVets;
    private DataGridView dgvVetStats;
    private TabPage tabByCabinets;
    private DataGridView dgvCabinetStats;
    private TabPage tabByProcedures;
    private DataGridView dgvProcedureStats;
    private Panel cardRevenue;
    private Label lblTitleRevenue;
    private Label lblValueRevenue;
    private Label lblTitleVisits;
    private Label lblValueVisits;
    private Panel cardCompleted;
    private Label lblTitleCompleted;
    private Label lblValueCompleted;
    private Label lblTitleAvgTime;
    private Label lblValueAvgTime;
    private Button btnAddVet;
    private Label label3;
    private Label labelVisitCompleted;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private GroupBox groupBox1;
    private TextBox textBoxVetSpec;
    private Label label4;
    private TextBox textBoxVetName;
    private Label label2;
    private GroupBox groupBox2;
    private TextBox textBoxTags;
    private Label label9;
    private Label label8;
    private Label label6;
    private TextBox textBoxProcedureName;
    private Label label7;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    private DataGridViewCheckBoxColumn dataGridViewTextBoxColumn13;
    private NumericUpDown numericUpDownProcedureCostPrice;
    private NumericUpDown numericUpDownProcedurePrice;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
}