namespace OracleWinFormsApp2024;

partial class CategoriesForm
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
        dataGridView1 = new DataGridView();
        ColumnId = new DataGridViewTextBoxColumn();
        ColumnCategoryName = new DataGridViewTextBoxColumn();
        ColumnDescription = new DataGridViewTextBoxColumn();
        ColumnPicture = new DataGridViewImageColumn();
        panel1 = new Panel();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.AllowUserToDeleteRows = false;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnCategoryName, ColumnDescription, ColumnPicture });
        dataGridView1.Dock = DockStyle.Fill;
        dataGridView1.Location = new Point(0, 0);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.ReadOnly = true;
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
        dataGridView1.RowTemplate.Height = 130;
        dataGridView1.Size = new Size(800, 348);
        dataGridView1.TabIndex = 0;
        // 
        // ColumnId
        // 
        ColumnId.DataPropertyName = "CategoryId";
        ColumnId.HeaderText = "Id";
        ColumnId.MinimumWidth = 6;
        ColumnId.Name = "ColumnId";
        ColumnId.ReadOnly = true;
        ColumnId.Width = 125;
        // 
        // ColumnCategoryName
        // 
        ColumnCategoryName.DataPropertyName = "CategoryName";
        ColumnCategoryName.HeaderText = "Name";
        ColumnCategoryName.MinimumWidth = 6;
        ColumnCategoryName.Name = "ColumnCategoryName";
        ColumnCategoryName.ReadOnly = true;
        ColumnCategoryName.Width = 125;
        // 
        // ColumnDescription
        // 
        ColumnDescription.DataPropertyName = "Description";
        ColumnDescription.HeaderText = "Description";
        ColumnDescription.MinimumWidth = 6;
        ColumnDescription.Name = "ColumnDescription";
        ColumnDescription.ReadOnly = true;
        ColumnDescription.Width = 125;
        // 
        // ColumnPicture
        // 
        ColumnPicture.DataPropertyName = "Picture";
        ColumnPicture.HeaderText = "Image";
        ColumnPicture.MinimumWidth = 6;
        ColumnPicture.Name = "ColumnPicture";
        ColumnPicture.ReadOnly = true;
        ColumnPicture.Width = 125;
        // 
        // panel1
        // 
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 348);
        panel1.Name = "panel1";
        panel1.Size = new Size(800, 70);
        panel1.TabIndex = 1;
        // 
        // CategoriesForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 418);
        Controls.Add(dataGridView1);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "CategoriesForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Categories";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView dataGridView1;
    private Panel panel1;
    private DataGridViewTextBoxColumn ColumnId;
    private DataGridViewTextBoxColumn ColumnCategoryName;
    private DataGridViewTextBoxColumn ColumnDescription;
    private DataGridViewImageColumn ColumnPicture;
}
