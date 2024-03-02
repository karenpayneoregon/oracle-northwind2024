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
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(329, 266);
        Controls.Add(AddEmployeeButton);
        Controls.Add(FixSupplierRegionButton);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        ResumeLayout(false);
    }

    #endregion

    private Button FixSupplierRegionButton;
    private Button AddEmployeeButton;
}
