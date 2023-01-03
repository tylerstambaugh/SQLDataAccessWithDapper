namespace FormUI
{
    partial class Dashboard
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
            this.employeesFoundListbox = new System.Windows.Forms.ListBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.firstNameInsLabel = new System.Windows.Forms.Label();
            this.firstNameInsInput = new System.Windows.Forms.TextBox();
            this.lastNameInsLabel = new System.Windows.Forms.Label();
            this.lastNameInsInput = new System.Windows.Forms.TextBox();
            this.genderInsLabel = new System.Windows.Forms.Label();
            this.genderInsInput = new System.Windows.Forms.TextBox();
            this.createRecordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeesFoundListbox
            // 
            this.employeesFoundListbox.FormattingEnabled = true;
            this.employeesFoundListbox.ItemHeight = 28;
            this.employeesFoundListbox.Location = new System.Drawing.Point(53, 205);
            this.employeesFoundListbox.Name = "employeesFoundListbox";
            this.employeesFoundListbox.Size = new System.Drawing.Size(514, 116);
            this.employeesFoundListbox.TabIndex = 0;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(162, 84);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(193, 34);
            this.lastNameText.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(53, 84);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(103, 28);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(142, 134);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(109, 33);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // firstNameInsLabel
            // 
            this.firstNameInsLabel.AutoSize = true;
            this.firstNameInsLabel.Location = new System.Drawing.Point(53, 410);
            this.firstNameInsLabel.Name = "firstNameInsLabel";
            this.firstNameInsLabel.Size = new System.Drawing.Size(106, 28);
            this.firstNameInsLabel.TabIndex = 5;
            this.firstNameInsLabel.Text = "First Name";
            // 
            // firstNameInsInput
            // 
            this.firstNameInsInput.Location = new System.Drawing.Point(162, 410);
            this.firstNameInsInput.Name = "firstNameInsInput";
            this.firstNameInsInput.Size = new System.Drawing.Size(193, 34);
            this.firstNameInsInput.TabIndex = 4;
            // 
            // lastNameInsLabel
            // 
            this.lastNameInsLabel.AutoSize = true;
            this.lastNameInsLabel.Location = new System.Drawing.Point(53, 447);
            this.lastNameInsLabel.Name = "lastNameInsLabel";
            this.lastNameInsLabel.Size = new System.Drawing.Size(103, 28);
            this.lastNameInsLabel.TabIndex = 7;
            this.lastNameInsLabel.Text = "Last Name";
            // 
            // lastNameInsInput
            // 
            this.lastNameInsInput.Location = new System.Drawing.Point(162, 447);
            this.lastNameInsInput.Name = "lastNameInsInput";
            this.lastNameInsInput.Size = new System.Drawing.Size(193, 34);
            this.lastNameInsInput.TabIndex = 6;
            // 
            // genderInsLabel
            // 
            this.genderInsLabel.AutoSize = true;
            this.genderInsLabel.Location = new System.Drawing.Point(53, 485);
            this.genderInsLabel.Name = "genderInsLabel";
            this.genderInsLabel.Size = new System.Drawing.Size(76, 28);
            this.genderInsLabel.TabIndex = 9;
            this.genderInsLabel.Text = "Gender";
            // 
            // genderInsInput
            // 
            this.genderInsInput.Location = new System.Drawing.Point(162, 485);
            this.genderInsInput.Name = "genderInsInput";
            this.genderInsInput.Size = new System.Drawing.Size(193, 34);
            this.genderInsInput.TabIndex = 8;
            // 
            // createRecordButton
            // 
            this.createRecordButton.Location = new System.Drawing.Point(162, 554);
            this.createRecordButton.Name = "createRecordButton";
            this.createRecordButton.Size = new System.Drawing.Size(101, 67);
            this.createRecordButton.TabIndex = 10;
            this.createRecordButton.Text = "Create";
            this.createRecordButton.UseVisualStyleBackColor = true;
            this.createRecordButton.Click += new System.EventHandler(this.createRecordButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 771);
            this.Controls.Add(this.createRecordButton);
            this.Controls.Add(this.genderInsLabel);
            this.Controls.Add(this.genderInsInput);
            this.Controls.Add(this.lastNameInsLabel);
            this.Controls.Add(this.lastNameInsInput);
            this.Controls.Add(this.firstNameInsLabel);
            this.Controls.Add(this.firstNameInsInput);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.employeesFoundListbox);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Dashboard";
            this.Text = "SQL Data Access Dapper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox employeesFoundListbox;
        private TextBox lastNameText;
        private Label lastNameLabel;
        private Button searchButton;
        private Label firstNameInsLabel;
        private TextBox firstNameInsInput;
        private Label lastNameInsLabel;
        private TextBox lastNameInsInput;
        private Label genderInsLabel;
        private TextBox genderInsInput;
        private Button createRecordButton;
    }
}