using System.ComponentModel;

namespace VetClinicMS.Windows;

partial class VeterinarianForm
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
        lblDoctor = new Label();
        btnLogout = new Button();
        leftPanel = new Panel();
        lblMyVisits = new Label();
        lvVisits = new ListView();
        columnHeader1 = new ColumnHeader();
        columnHeader2 = new ColumnHeader();
        columnHeader3 = new ColumnHeader();
        columnHeader4 = new ColumnHeader();
        rightPanel = new Panel();
        lblVisitDetails = new Label();
        gbPatient = new GroupBox();
        lblPetName = new Label();
        lblPetInfo = new Label();
        lblPetAge = new Label();
        lblOwnerInfo = new Label();
        gbProcedures = new GroupBox();
        dgvProcedures = new DataGridView();
        colProcedure = new DataGridViewTextBoxColumn();
        colCost = new DataGridViewTextBoxColumn();
        Column1 = new DataGridViewCheckBoxColumn();
        gbVisitStatus = new GroupBox();
        lblCurrentStatus = new Label();
        lblTotalCost = new Label();
        btnStartVisit = new Button();
        btnCompleteVisit = new Button();
        btnCancelVisit = new Button();
        topPanel.SuspendLayout();
        leftPanel.SuspendLayout();
        rightPanel.SuspendLayout();
        gbPatient.SuspendLayout();
        gbProcedures.SuspendLayout();
        ((ISupportInitialize)dgvProcedures).BeginInit();
        gbVisitStatus.SuspendLayout();
        SuspendLayout();
        // 
        // topPanel
        // 
        topPanel.BackColor = Color.FromArgb(46, 125, 50);
        topPanel.Controls.Add(lblTitle);
        topPanel.Controls.Add(lblDoctor);
        topPanel.Controls.Add(btnLogout);
        topPanel.Dock = DockStyle.Top;
        topPanel.Location = new Point(0, 0);
        topPanel.Name = "topPanel";
        topPanel.Size = new Size(1384, 60);
        topPanel.TabIndex = 2;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(20, 15);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(168, 30);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Панель лікаря";
        // 
        // lblDoctor
        // 
        lblDoctor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblDoctor.Font = new Font("Segoe UI", 10F);
        lblDoctor.ForeColor = Color.White;
        lblDoctor.Location = new Point(837, 20);
        lblDoctor.Name = "lblDoctor";
        lblDoctor.Size = new Size(437, 19);
        lblDoctor.TabIndex = 1;
        lblDoctor.Text = "Лікар: [Ім'я лікаря]";
        lblDoctor.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // btnLogout
        // 
        btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnLogout.BackColor = Color.White;
        btnLogout.Location = new Point(1280, 15);
        btnLogout.Name = "btnLogout";
        btnLogout.Size = new Size(90, 30);
        btnLogout.TabIndex = 2;
        btnLogout.Text = "Вихід";
        btnLogout.UseVisualStyleBackColor = false;
        btnLogout.Click += btnLogout_Click;
        // 
        // leftPanel
        // 
        leftPanel.Controls.Add(lblMyVisits);
        leftPanel.Controls.Add(lvVisits);
        leftPanel.Dock = DockStyle.Left;
        leftPanel.Location = new Point(0, 60);
        leftPanel.Name = "leftPanel";
        leftPanel.Padding = new Padding(10);
        leftPanel.Size = new Size(500, 629);
        leftPanel.TabIndex = 1;
        // 
        // lblMyVisits
        // 
        lblMyVisits.AutoSize = true;
        lblMyVisits.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblMyVisits.Location = new Point(10, 10);
        lblMyVisits.Name = "lblMyVisits";
        lblMyVisits.Size = new Size(93, 21);
        lblMyVisits.TabIndex = 0;
        lblMyVisits.Text = "Мої візити";
        // 
        // lvVisits
        // 
        lvVisits.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        lvVisits.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
        lvVisits.FullRowSelect = true;
        lvVisits.GridLines = true;
        lvVisits.Location = new Point(10, 45);
        lvVisits.MultiSelect = false;
        lvVisits.Name = "lvVisits";
        lvVisits.Size = new Size(480, 572);
        lvVisits.TabIndex = 2;
        lvVisits.UseCompatibleStateImageBehavior = false;
        lvVisits.View = View.Details;
        lvVisits.SelectedIndexChanged += lvVisits_SelectedIndexChanged;
        // 
        // columnHeader1
        // 
        columnHeader1.Text = "Час";
        columnHeader1.Width = 100;
        // 
        // columnHeader2
        // 
        columnHeader2.Text = "Власник";
        columnHeader2.Width = 150;
        // 
        // columnHeader3
        // 
        columnHeader3.Text = "Тварина";
        columnHeader3.Width = 120;
        // 
        // columnHeader4
        // 
        columnHeader4.Text = "Статус";
        columnHeader4.Width = 100;
        // 
        // rightPanel
        // 
        rightPanel.Controls.Add(lblVisitDetails);
        rightPanel.Controls.Add(gbPatient);
        rightPanel.Controls.Add(gbProcedures);
        rightPanel.Controls.Add(gbVisitStatus);
        rightPanel.Dock = DockStyle.Fill;
        rightPanel.Location = new Point(500, 60);
        rightPanel.Name = "rightPanel";
        rightPanel.Padding = new Padding(10);
        rightPanel.Size = new Size(884, 629);
        rightPanel.TabIndex = 0;
        // 
        // lblVisitDetails
        // 
        lblVisitDetails.AutoSize = true;
        lblVisitDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblVisitDetails.Location = new Point(10, 10);
        lblVisitDetails.Name = "lblVisitDetails";
        lblVisitDetails.Size = new Size(114, 21);
        lblVisitDetails.TabIndex = 0;
        lblVisitDetails.Text = "Деталі візиту";
        // 
        // gbPatient
        // 
        gbPatient.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        gbPatient.Controls.Add(lblPetName);
        gbPatient.Controls.Add(lblPetInfo);
        gbPatient.Controls.Add(lblPetAge);
        gbPatient.Controls.Add(lblOwnerInfo);
        gbPatient.Font = new Font("Segoe UI", 10F);
        gbPatient.Location = new Point(10, 45);
        gbPatient.Name = "gbPatient";
        gbPatient.Size = new Size(850, 150);
        gbPatient.TabIndex = 1;
        gbPatient.TabStop = false;
        gbPatient.Text = "Інформація про пацієнта";
        // 
        // lblPetName
        // 
        lblPetName.Location = new Point(15, 25);
        lblPetName.Name = "lblPetName";
        lblPetName.Size = new Size(820, 23);
        lblPetName.TabIndex = 0;
        lblPetName.Text = "Кличка: ";
        // 
        // lblPetInfo
        // 
        lblPetInfo.Location = new Point(15, 50);
        lblPetInfo.Name = "lblPetInfo";
        lblPetInfo.Size = new Size(820, 23);
        lblPetInfo.TabIndex = 1;
        lblPetInfo.Text = "Вид/Порода: ";
        // 
        // lblPetAge
        // 
        lblPetAge.Location = new Point(15, 75);
        lblPetAge.Name = "lblPetAge";
        lblPetAge.Size = new Size(820, 23);
        lblPetAge.TabIndex = 2;
        lblPetAge.Text = "Вік: ";
        // 
        // lblOwnerInfo
        // 
        lblOwnerInfo.Location = new Point(15, 100);
        lblOwnerInfo.Name = "lblOwnerInfo";
        lblOwnerInfo.Size = new Size(820, 23);
        lblOwnerInfo.TabIndex = 3;
        lblOwnerInfo.Text = "Власник: ";
        // 
        // gbProcedures
        // 
        gbProcedures.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        gbProcedures.Controls.Add(dgvProcedures);
        gbProcedures.Font = new Font("Segoe UI", 10F);
        gbProcedures.Location = new Point(10, 205);
        gbProcedures.Name = "gbProcedures";
        gbProcedures.Size = new Size(850, 280);
        gbProcedures.TabIndex = 2;
        gbProcedures.TabStop = false;
        gbProcedures.Text = "Процедури";
        // 
        // dgvProcedures
        // 
        dgvProcedures.AllowUserToAddRows = false;
        dgvProcedures.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvProcedures.ColumnHeadersHeight = 28;
        dgvProcedures.Columns.AddRange(new DataGridViewColumn[] { colProcedure, colCost, Column1 });
        dgvProcedures.Dock = DockStyle.Fill;
        dgvProcedures.Location = new Point(3, 21);
        dgvProcedures.Name = "dgvProcedures";
        dgvProcedures.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvProcedures.Size = new Size(844, 256);
        dgvProcedures.TabIndex = 0;
        // 
        // colProcedure
        // 
        colProcedure.DataPropertyName = "ProcedureName";
        colProcedure.HeaderText = "Процедура";
        colProcedure.Name = "colProcedure";
        // 
        // colCost
        // 
        colCost.DataPropertyName = "ProcedurePrice";
        colCost.HeaderText = "Вартість";
        colCost.Name = "colCost";
        // 
        // Column1
        // 
        Column1.DataPropertyName = "IsCompleted";
        Column1.HeaderText = "Статус";
        Column1.Name = "Column1";
        // 
        // gbVisitStatus
        // 
        gbVisitStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        gbVisitStatus.Controls.Add(lblCurrentStatus);
        gbVisitStatus.Controls.Add(lblTotalCost);
        gbVisitStatus.Controls.Add(btnStartVisit);
        gbVisitStatus.Controls.Add(btnCompleteVisit);
        gbVisitStatus.Controls.Add(btnCancelVisit);
        gbVisitStatus.Font = new Font("Segoe UI", 10F);
        gbVisitStatus.Location = new Point(10, 495);
        gbVisitStatus.Name = "gbVisitStatus";
        gbVisitStatus.Size = new Size(850, 122);
        gbVisitStatus.TabIndex = 3;
        gbVisitStatus.TabStop = false;
        gbVisitStatus.Text = "Статус візиту";
        // 
        // lblCurrentStatus
        // 
        lblCurrentStatus.AutoSize = true;
        lblCurrentStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblCurrentStatus.Location = new Point(15, 25);
        lblCurrentStatus.Name = "lblCurrentStatus";
        lblCurrentStatus.Size = new Size(129, 19);
        lblCurrentStatus.TabIndex = 0;
        lblCurrentStatus.Text = "Поточний статус:";
        // 
        // lblTotalCost
        // 
        lblTotalCost.AutoSize = true;
        lblTotalCost.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblTotalCost.Location = new Point(15, 55);
        lblTotalCost.Name = "lblTotalCost";
        lblTotalCost.Size = new Size(136, 19);
        lblTotalCost.TabIndex = 1;
        lblTotalCost.Text = "Загальна вартість:";
        // 
        // btnStartVisit
        // 
        btnStartVisit.BackColor = Color.FromArgb(33, 150, 243);
        btnStartVisit.FlatStyle = FlatStyle.Flat;
        btnStartVisit.ForeColor = Color.White;
        btnStartVisit.Location = new Point(15, 87);
        btnStartVisit.Name = "btnStartVisit";
        btnStartVisit.Size = new Size(150, 30);
        btnStartVisit.TabIndex = 4;
        btnStartVisit.Text = "Розпочати прийом";
        btnStartVisit.UseVisualStyleBackColor = false;
        btnStartVisit.Click += btnStartVisit_Click;
        // 
        // btnCompleteVisit
        // 
        btnCompleteVisit.BackColor = Color.FromArgb(76, 175, 80);
        btnCompleteVisit.FlatStyle = FlatStyle.Flat;
        btnCompleteVisit.ForeColor = Color.White;
        btnCompleteVisit.Location = new Point(171, 87);
        btnCompleteVisit.Name = "btnCompleteVisit";
        btnCompleteVisit.Size = new Size(150, 30);
        btnCompleteVisit.TabIndex = 5;
        btnCompleteVisit.Text = "Завершити візит";
        btnCompleteVisit.UseVisualStyleBackColor = false;
        btnCompleteVisit.Click += btnCompleteVisit_Click;
        // 
        // btnCancelVisit
        // 
        btnCancelVisit.BackColor = Color.FromArgb(244, 67, 54);
        btnCancelVisit.FlatStyle = FlatStyle.Flat;
        btnCancelVisit.ForeColor = Color.White;
        btnCancelVisit.Location = new Point(327, 87);
        btnCancelVisit.Name = "btnCancelVisit";
        btnCancelVisit.Size = new Size(150, 30);
        btnCancelVisit.TabIndex = 6;
        btnCancelVisit.Text = "Скасувати візит";
        btnCancelVisit.UseVisualStyleBackColor = false;
        btnCancelVisit.Click += btnCancelVisit_Click;
        // 
        // VeterinarianForm
        // 
        ClientSize = new Size(1384, 689);
        Controls.Add(rightPanel);
        Controls.Add(leftPanel);
        Controls.Add(topPanel);
        Name = "VeterinarianForm";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Лікар - Ветеринарна клініка";
        topPanel.ResumeLayout(false);
        topPanel.PerformLayout();
        leftPanel.ResumeLayout(false);
        leftPanel.PerformLayout();
        rightPanel.ResumeLayout(false);
        rightPanel.PerformLayout();
        gbPatient.ResumeLayout(false);
        gbProcedures.ResumeLayout(false);
        ((ISupportInitialize)dgvProcedures).EndInit();
        gbVisitStatus.ResumeLayout(false);
        gbVisitStatus.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel topPanel;
    private Label lblTitle;
    private Label lblDoctor;
    private Button btnLogout;
    private Panel leftPanel;
    private Label lblMyVisits;
    private ListView lvVisits;
    private Panel rightPanel;
    private Label lblVisitDetails;
    private GroupBox gbPatient;
    private Label lblPetName;
    private Label lblPetInfo;
    private Label lblPetAge;
    private Label lblOwnerInfo;
    private GroupBox gbProcedures;
    private DataGridView dgvProcedures;
    private GroupBox gbVisitStatus;
    private Label lblCurrentStatus;
    private Label lblTotalCost;
    private Button btnStartVisit;
    private Button btnCompleteVisit;
    private Button btnCancelVisit;


    private System.Windows.Forms.Timer timer1;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private DataGridViewTextBoxColumn colProcedure;
    private DataGridViewTextBoxColumn colCost;
    private DataGridViewCheckBoxColumn Column1;
}