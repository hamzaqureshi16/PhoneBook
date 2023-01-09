namespace LabTask_UserDeets
{
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddressInput = new System.Windows.Forms.TextBox();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.NumberInput = new System.Windows.Forms.TextBox();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.ToBeSearched = new System.Windows.Forms.TextBox();
            this.NewButton = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.EditButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddressInput);
            this.panel1.Controls.Add(this.EmailInput);
            this.panel1.Controls.Add(this.NameInput);
            this.panel1.Controls.Add(this.NumberInput);
            this.panel1.Controls.Add(this.AdressLabel);
            this.panel1.Controls.Add(this.EmailLabel);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.PhoneLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 194);
            this.panel1.TabIndex = 1;
            // 
            // AddressInput
            // 
            this.AddressInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressInput.Location = new System.Drawing.Point(115, 116);
            this.AddressInput.Multiline = true;
            this.AddressInput.Name = "AddressInput";
            this.AddressInput.Size = new System.Drawing.Size(383, 70);
            this.AddressInput.TabIndex = 7;
            // 
            // EmailInput
            // 
            this.EmailInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailInput.Location = new System.Drawing.Point(115, 82);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.PlaceholderText = "e.g johnsmith@domain.com";
            this.EmailInput.Size = new System.Drawing.Size(383, 23);
            this.EmailInput.TabIndex = 6;
            // 
            // NameInput
            // 
            this.NameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameInput.Location = new System.Drawing.Point(115, 47);
            this.NameInput.Name = "NameInput";
            this.NameInput.PlaceholderText = "e.g John Smith";
            this.NameInput.Size = new System.Drawing.Size(261, 23);
            this.NameInput.TabIndex = 5;
            // 
            // NumberInput
            // 
            this.NumberInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumberInput.Location = new System.Drawing.Point(115, 12);
            this.NumberInput.Name = "NumberInput";
            this.NumberInput.PlaceholderText = "E.g 03335037773";
            this.NumberInput.Size = new System.Drawing.Size(189, 23);
            this.NumberInput.TabIndex = 4;
            // 
            // AdressLabel
            // 
            this.AdressLabel.Location = new System.Drawing.Point(3, 116);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(71, 20);
            this.AdressLabel.TabIndex = 3;
            this.AdressLabel.Text = "Address:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.Location = new System.Drawing.Point(3, 82);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(71, 20);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "Email:";
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(3, 47);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(71, 20);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Full Name:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.Location = new System.Drawing.Point(3, 12);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(106, 20);
            this.PhoneLabel.TabIndex = 0;
            this.PhoneLabel.Text = "Phone Number:";
            this.PhoneLabel.Click += new System.EventHandler(this.PhoneLabel_Click);
            // 
            // SearchLabel
            // 
            this.SearchLabel.Location = new System.Drawing.Point(15, 223);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(77, 23);
            this.SearchLabel.TabIndex = 2;
            this.SearchLabel.Text = "Search:";
            this.SearchLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ToBeSearched
            // 
            this.ToBeSearched.Location = new System.Drawing.Point(127, 223);
            this.ToBeSearched.Name = "ToBeSearched";
            this.ToBeSearched.PlaceholderText = "Phone number";
            this.ToBeSearched.Size = new System.Drawing.Size(383, 23);
            this.ToBeSearched.TabIndex = 3;
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(220, 417);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(75, 23);
            this.NewButton.TabIndex = 6;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(15, 256);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 29;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(524, 155);
            this.dataGrid.TabIndex = 7;
            this.dataGrid.SelectionChanged += new System.EventHandler(this.dataGrid_SelectionChanged);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(301, 417);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 8;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(382, 417);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(459, 417);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.ToBeSearched);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.form_load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label AdressLabel;
        private Label EmailLabel;
        private Label NameLabel;
        private Label PhoneLabel;
        private TextBox AddressInput;
        private TextBox EmailInput;
        private TextBox NameInput;
        private TextBox NumberInput;
        private Label SearchLabel;
        private TextBox ToBeSearched;
        private Button NewButton;
        private DataGridView dataGrid;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn fullname;
        private DataGridViewTextBoxColumn address;
        private Button EditButton;
        private Button CancelButton;
        private Button SaveButton;
    }
}