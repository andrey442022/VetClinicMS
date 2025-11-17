using VetClinicMS.Models;
using static System.Windows.Forms.AxHost;

namespace VetClinicMS.Windows;

public partial class AdminForm : Form
{


    public AdminForm()
    {
        InitializeComponent();
        UpdateTable();
        cmbPeriod.SelectedIndex = 0;
    }

    private void UpdateTable()
    {
        dgvVeterinarians.DataSource = Program.veterinarianService.GetVeterinarians();
        dgvProcedures.DataSource = Program.procedureService.GetProcedures();
    }

    private void btnLogout_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnAddVet_Click(object sender, EventArgs e)
    {
        if (textBoxVetName.Text.Length == 0 || textBoxVetSpec.Text.Length == 0) return;

        Program.veterinarianService.CreateVeterinarian(textBoxVetName.Text, textBoxVetSpec.Text);

        textBoxVetName.Clear();
        textBoxVetSpec.Clear();

        UpdateTable();
    }

    private void btnAddProcedure_Click(object sender, EventArgs e)
    {
        if (textBoxProcedureName.Text.Length == 0 || numericUpDownProcedurePrice.Value == 0) return;

        var tags = textBoxTags.Text.Length == 0 ? null : textBoxTags.Text.Split(",", StringSplitOptions.TrimEntries).ToList();
        Program.procedureService.CreateProcedure(textBoxProcedureName.Text, numericUpDownProcedurePrice.Value, numericUpDownProcedureCostPrice.Value, tags);
        textBoxProcedureName.Clear();
        numericUpDownProcedurePrice.Value = 0;
        UpdateTable();
    }

    private void dgvProcedures_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        var procedure = (Procedure)dgvProcedures.Rows[e.RowIndex].DataBoundItem;

        Program.procedureService.UpdateProcedure(procedure);
    }

    private void btnLoadStatistics_Click(object sender, EventArgs e)
    {
        var start = DateTime.Today;

        var end = cmbPeriod.SelectedIndex switch
        {
            1 => start.AddDays(7),
            2 => start.AddMonths(1),
            3 => start.AddYears(1),
            _ => start.AddDays(1)
        };

        if (cmbPeriod.SelectedIndex == 4)
        {
            start = dtpFrom.Value.Date;
            end = dtpTo.Value.Date;
        }

        var stat = Program.statisticsService.GetTotalSumAndCountVisitsForPeriod(start, end);
        labelVisitCompleted.Text = stat.count.ToString();
        lblValueRevenue.Text = stat.total + " грн";

        var vetList = new List<object>();

        foreach (var veterinarian in Program.veterinarianService.GetVeterinarians())
        {
            var statVet = Program.statisticsService.GetStatisticsVeterinarian(veterinarian, start, end);

            vetList.Add(new
            {
                Vet = veterinarian,
                Visit = statVet.count,
                Sum = statVet.all,
                Average = Math.Round(statVet.average / 60)
            });
        }

        dgvVetStats.DataSource = vetList;

        var officeList = new List<object>();

        for (var startOfficeDate = start; startOfficeDate < end; startOfficeDate = startOfficeDate.AddDays(1))
        {
            foreach (var office in Program.visitService.GetVisits().DistinctBy(item => item.Office).Select(item => item.Office))
            {
                var statOffice = Program.statisticsService.GetCabinetStatistics(office, startOfficeDate);

                officeList.Add(new
                {
                    Office = office,
                    Visit = statOffice.count,
                    Average = Math.Round(statOffice.average / 60),
                    Util = statOffice.util
                });
            }
        }

        dgvCabinetStats.DataSource = officeList;

        var procedureList = new List<object>();

        foreach (var procedure in Program.statisticsService.GetProceduresStatisticsList(start, end))
        {
            procedureList.Add(new
            {
                Procedure = procedure.procedure.Name,
                Count = procedure.count,
                Sum = procedure.sum
            });
        }

        dgvProcedureStats.DataSource = procedureList;
    }
}