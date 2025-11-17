using VetClinicMS.Models;

namespace VetClinicMS.Windows;

public partial class VeterinarianForm : Form
{
    private readonly Guid idVet;

    private Visit? selectVisit;

    public VeterinarianForm(Veterinarian vet)
    {
        this.idVet = vet.Id;
        InitializeComponent();
        UpdateVisits();
        lblDoctor.Text = "Лікар: " + vet.FullName;
    }

    private void UpdateVisits()
    {
        var newData = Program.visitService.GetVisits(item => item.Veterinarian.Id == idVet
                                                             && item.Status != VisitStatus.Completed
                                                             && item.Status != VisitStatus.Cancelled);
        lvVisits.Items.Clear();
        if (lvVisits.Items == null ||
            lvVisits.Items.Count != newData.Count)
        {
            foreach (var visit in newData)
            {
                lvVisits.Items.Add(new ListViewItem(visit.Date.ToString("dd.MM.yyyy HH:mm:ss"))
                {
                    Tag = visit,
                    SubItems =
                    {
                        new ListViewItem.ListViewSubItem()
                        {
                            Text = visit.Patient.Owner.FullName
                        },
                        new ListViewItem.ListViewSubItem()
                        {
                            Text = visit.Patient.Name
                        },
                        new ListViewItem.ListViewSubItem()
                        {
                            Text = visit.Status.ToString()
                        }
                    }
                });
            }
        }
    }

    private void lvVisits_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvVisits.SelectedItems.Count == 0) return;

        selectVisit = (Visit)lvVisits.SelectedItems[0].Tag!;

        dgvProcedures.AutoGenerateColumns = false;
        dgvProcedures.DataSource = selectVisit.Procedures;

        dgvProcedures.ReadOnly = selectVisit.Status is VisitStatus.Completed or VisitStatus.Cancelled;

        lblPetName.Text = "Кличка: " + selectVisit.Patient.Name;
        lblPetInfo.Text = $"Вид/Порода: {selectVisit.Patient.Species}/{selectVisit.Patient.Breed}";
        lblPetAge.Text = "Вік: " + selectVisit.Patient.Age;
        lblOwnerInfo.Text = "Власник: " + selectVisit.Patient.Owner.FullName;

        lblCurrentStatus.Text = "Поточний статус: " + selectVisit.Status.ToString();
        lblTotalCost.Text = "Загальна вартість: " + selectVisit.Procedures.Sum(item => item.ProcedurePrice) + " грн";
    }

    private void btnStartVisit_Click(object sender, EventArgs e)
    {
        if (selectVisit is not { Status: VisitStatus.Registered }) return;

        selectVisit.Status = VisitStatus.InProgress;

        Program.visitService.UpdateVisit(selectVisit);
        UpdateVisits();
    }

    private void btnCompleteVisit_Click(object sender, EventArgs e)
    {
        if (selectVisit is not { Status: VisitStatus.InProgress }) return;
        if (selectVisit.Procedures.Any(item => !item.IsCompleted))
        {
            MessageBox.Show("Потрібно завершити всі процедури!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        Program.visitService.CloseVisit(selectVisit);
        selectVisit = null;
        UpdateVisits();
        ClearControls();
    }

    private void btnCancelVisit_Click(object sender, EventArgs e)
    {
        if (selectVisit == null || selectVisit.Status == VisitStatus.Completed) return;

        selectVisit.Status = VisitStatus.Cancelled;
        Program.visitService.UpdateVisit(selectVisit);
        selectVisit = null;
        UpdateVisits();
        ClearControls();
    }

    private void ClearControls()
    {
        dgvProcedures.DataSource = null;

        lblPetName.Text = "Кличка: ";
        lblPetInfo.Text = $"Вид/Порода: ";
        lblPetAge.Text = "Вік: ";
        lblOwnerInfo.Text = "Власник: ";

        lblCurrentStatus.Text = "Поточний статус: ";
        lblTotalCost.Text = "Загальна вартість: ";
    }

    private void btnLogout_Click(object sender, EventArgs e)
    {
        Close();
    }

    //private void dataGridViewVisits_SelectionChanged(object sender, EventArgs e)
    //{
    //    if (dataGridViewVisits.SelectedRows.Count == 0 || dataGridViewVisits.SelectedRows[0].Cells[0].Value == null)
    //    {
    //        checkedListBoxProcedures.Items.Clear();
    //        return;
    //    }

    //    var idVisit = (Guid) dataGridViewVisits.SelectedRows[0].Cells[0].Value;
    //    selectVisit = Program.visitService.GetVisit(idVisit);

    //    checkedListBoxProcedures.Items.Clear();
    //    foreach (var item in selectVisit!.Procedures) checkedListBoxProcedures.Items.Add(item, false);
    //    checkedListBoxProcedures.DisplayMember = "Procedure.Name";
    //}

    //private void timer1_Tick(object sender, EventArgs e)
    //{
    //    var newData = Program.visitService.GetVisits(item => item.Veterinarian.Id == idVet
    //                                                         && item.Status == VisitStatus.Registered);
    //    if (dataGridViewVisits.DataSource == null ||
    //        ((List<Visit>) dataGridViewVisits.DataSource).Count != newData.Count)
    //        dataGridViewVisits.DataSource = newData;
    //}

    //private void button1_Click(object sender, EventArgs e)
    //{
    //    if (selectVisit == null ||
    //        checkedListBoxProcedures.CheckedItems.Count != selectVisit.Procedures.Count) return;

    //    selectVisit.Procedures.ForEach(item => item.IsCompleted = true);

    //    Program.visitService.CloseVisit(selectVisit);

    //    selectVisit = null;

    //    MessageBox.Show("Ви закрили візит!");
    //}

    //private void dataGridViewVisits_DataError(object sender, DataGridViewDataErrorEventArgs e)
    //{
    //    e.ThrowException = false;
    //}
}