namespace PracticeApp;

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
        FixSupplierRegionButton = new Button();
        AddEmployeeButton = new Button();
        CountriesComboBox = new ComboBox();
        label1 = new Label();
        CurrentCountryButton = new Button();
        IterateEmployeesButton = new Button();
        SuspendLayout();
        // 
        // FixSupplierRegionButton
        // 
        FixSupplierRegionButton.Location = new Point(12, 34);
        FixSupplierRegionButton.Name = "FixSupplierRegionButton";
        FixSupplierRegionButton.Size = new Size(272, 29);
        FixSupplierRegionButton.TabIndex = 0;
        FixSupplierRegionButton.Text = "Fix Suppliers region";
        FixSupplierRegionButton.UseVisualStyleBackColor = true;
        FixSupplierRegionButton.Click += FixSupplierRegionButton_Click;
        // 
        // AddEmployeeButton
        // 
        AddEmployeeButton.Location = new Point(12, 82);
        AddEmployeeButton.Name = "AddEmployeeButton";
        AddEmployeeButton.Size = new Size(272, 29);
        AddEmployeeButton.TabIndex = 1;
        AddEmployeeButton.Text = "Add Employee";
        AddEmployeeButton.UseVisualStyleBackColor = true;
        AddEmployeeButton.Click += AddEmployeeButton_Click;
        // 
        // CountriesComboBox
        // 
        CountriesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        CountriesComboBox.FormattingEnabled = true;
        CountriesComboBox.Location = new Point(305, 35);
        CountriesComboBox.Name = "CountriesComboBox";
        CountriesComboBox.Size = new Size(307, 28);
        CountriesComboBox.TabIndex = 2;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(305, 9);
        label1.Name = "label1";
        label1.Size = new Size(71, 20);
        label1.TabIndex = 4;
        label1.Text = "Countries";
        // 
        // CurrentCountryButton
        // 
        CurrentCountryButton.Location = new Point(635, 34);
        CurrentCountryButton.Name = "CurrentCountryButton";
        CurrentCountryButton.Size = new Size(94, 29);
        CurrentCountryButton.TabIndex = 5;
        CurrentCountryButton.Text = "Current";
        CurrentCountryButton.UseVisualStyleBackColor = true;
        CurrentCountryButton.Click += CurrentCountryButton_Click;
        // 
        // IterateEmployeesButton
        // 
        IterateEmployeesButton.Location = new Point(12, 135);
        IterateEmployeesButton.Name = "IterateEmployeesButton";
        IterateEmployeesButton.Size = new Size(272, 29);
        IterateEmployeesButton.TabIndex = 6;
        IterateEmployeesButton.Text = "Iterate Employees";
        IterateEmployeesButton.UseVisualStyleBackColor = true;
        IterateEmployeesButton.Click += IterateEmployeesButton_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(757, 189);
        Controls.Add(IterateEmployeesButton);
        Controls.Add(CurrentCountryButton);
        Controls.Add(label1);
        Controls.Add(CountriesComboBox);
        Controls.Add(AddEmployeeButton);
        Controls.Add(FixSupplierRegionButton);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button FixSupplierRegionButton;
    private Button AddEmployeeButton;
    private ComboBox CountriesComboBox;
    private Label label1;
    private Button CurrentCountryButton;
    private Button IterateEmployeesButton;
}
