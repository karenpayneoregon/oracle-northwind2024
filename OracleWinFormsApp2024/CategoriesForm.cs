
using OracleWinFormsApp2024.Classes;

namespace OracleWinFormsApp2024;

public partial class CategoriesForm : Form
{
    public CategoriesForm()
    {
        InitializeComponent();
        dataGridView1.AutoGenerateColumns = false;
        Shown += MainForm_Shown;
    }

    private void MainForm_Shown(object? sender, EventArgs e)
    {
        dataGridView1.DataSource = CategoriesOperations.GetAll();
        dataGridView1.ExpandColumns();
    }
}
