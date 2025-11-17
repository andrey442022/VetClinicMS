using VetClinicMS.Models;

namespace VetClinicMS.Windows;

public partial class RegisterForm : Form
{
    public RegisterForm()
    {
        InitializeComponent();
        UpdateTable();
        cmbOwner.DisplayMember = "FullName";
        cmbPet.DisplayMember = "Name";
        cmbVeterinarian.DisplayMember = "FullName";
        clbProcedures.DisplayMember = "Name";

        //timer1.Enabled = true;
    }

    private void UpdateTable()
    {
        if (!dgvOwners.Focused)
            dgvOwners.DataSource = Program.ownerService.GetOwners();
        if (!dgvPets.Focused)
            dgvPets.DataSource = Program.petService.GetPets();
        if (!dgvVisits.Focused)
            dgvVisits.DataSource = Program.visitService
                .GetVisits(item => item.Status == VisitStatus.Registered)
                .Select(item => new
                {
                    Id = item.Id,
                    Owner = item.Patient.Owner.FullName,
                    Patient = item.Patient,
                    Veterinarian = item.Veterinarian,
                    Status = item.Status,
                    Date = item.Date,
                    Office = item.Office
                }).ToList();

        if (!cmbOwner.Focused)
            cmbOwner.DataSource = Program.ownerService.GetOwners();
        if (!cmbPet.Focused)
            cmbPet.DataSource = Program.petService.GetPets();
        if (!cmbVeterinarian.Focused)
            cmbVeterinarian.DataSource = Program.veterinarianService.GetVeterinarians();

        if (!clbProcedures.Focused)
        {
            clbProcedures.Items.Clear();
            var items = Program.procedureService.GetActualProcedures();
            foreach (var item in items) clbProcedures.Items.Add(item, false);
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (textBoxOwnerName.Text.Length == 0) return;

        Program.ownerService.RegisterOwner(textBoxOwnerName.Text, textBoxOwnerPhone.Text, textBoxEmail.Text);
        UpdateTable();

        textBoxOwnerName.Clear();
        textBoxOwnerPhone.Clear();
        textBoxEmail.Clear();
    }

    private void buttonAddPet_Click(object sender, EventArgs e)
    {
        if (textBoxPetName.Text.Length == 0 ||
            textBoxPetBreed.Text.Length == 0 ||
            textBoxPetType.Text.Length == 0 ||
            cmbOwner.SelectedItem is null) return;

        Program.petService
            .RegisterPet(textBoxPetName.Text, textBoxPetType.Text, textBoxPetBreed.Text,
                (int)numericUpDownPetYears.Value, (Owner)cmbOwner.SelectedItem!);

        textBoxPetName.Clear();
        textBoxPetBreed.Clear();
        textBoxPetType.Clear();
        cmbOwner.SelectedIndex = -1;
        numericUpDownPetYears.Value = 0;

        UpdateTable();
    }

    private void buttonVisitAdd_Click(object sender, EventArgs e)
    {
        if (txtCabinet.Text.Length == 0 ||
            cmbVeterinarian.SelectedItem is null ||
            cmbPet.SelectedItem is null ||
            clbProcedures.SelectedItems.Count == 0) return;

        var checkedProcedure = clbProcedures.CheckedItems.Cast<Procedure>().ToList();

        Program.visitService.AddVisit((Pet)cmbPet.SelectedItem, checkedProcedure, dtpVisit.Value,
            txtCabinet.Text, (Veterinarian)cmbVeterinarian.SelectedItem);

        cmbVeterinarian.SelectedIndex = -1;
        cmbPet.SelectedIndex = -1;
        txtCabinet.Clear();
        clbProcedures.Items.Clear();

        UpdateTable();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        if (!dgvVisits.Focused)
            dgvVisits.DataSource = Program.visitService
                .GetVisits(item => item.Status == VisitStatus.Registered)
                .Select(item => new
                {
                    Id = item.Id,
                    Owner = item.Patient.Owner,
                    Patient = item.Patient,
                    Veterinarian = item.Veterinarian,
                    Status = item.Status,
                    Date = item.Date,
                    Office = item.Office
                }).ToList();

        if (!cmbVeterinarian.Focused)
            cmbVeterinarian.DataSource = Program.veterinarianService.GetVeterinarians();

        if (!clbProcedures.Focused)
        {
            clbProcedures.Items.Clear();
            var items = Program.procedureService.GetActualProcedures();
            foreach (var item in items) clbProcedures.Items.Add(item, false);
        }
    }

    private void btnLogout_Click(object sender, EventArgs e)
    {
        Close();
    }
}