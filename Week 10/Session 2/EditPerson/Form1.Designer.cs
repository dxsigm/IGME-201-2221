namespace EditPerson
{
    partial class PersonEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.gpaText = new System.Windows.Forms.TextBox();
            this.specText = new System.Windows.Forms.TextBox();
            this.specialtyLabel = new System.Windows.Forms.Label();
            this.licText = new System.Windows.Forms.TextBox();
            this.licLabel = new System.Windows.Forms.Label();
            this.ageText = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.gpaLabel = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.awesomeRadioButton = new System.Windows.Forms.RadioButton();
            this.okRadioButton = new System.Windows.Forms.RadioButton();
            this.horribleRadioButton = new System.Windows.Forms.RadioButton();
            this.pizzaRadioButton = new System.Windows.Forms.RadioButton();
            this.broccoliRadioButton = new System.Windows.Forms.RadioButton();
            this.wingsRadioButton = new System.Windows.Forms.RadioButton();
            this.favFoodGroupBox = new System.Windows.Forms.GroupBox();
            this.qualGroupBox = new System.Windows.Forms.GroupBox();
            this.foodLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.favFoodGroupBox.SuspendLayout();
            this.qualGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.CausesValidation = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(754, 399);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(56, 24);
            this.cancelButton.TabIndex = 23;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(680, 399);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(56, 24);
            this.okButton.TabIndex = 21;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // gpaText
            // 
            this.gpaText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gpaText.Location = new System.Drawing.Point(81, 203);
            this.gpaText.Name = "gpaText";
            this.gpaText.Size = new System.Drawing.Size(60, 20);
            this.gpaText.TabIndex = 18;
            // 
            // specText
            // 
            this.specText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.specText.Location = new System.Drawing.Point(81, 203);
            this.specText.Name = "specText";
            this.specText.Size = new System.Drawing.Size(352, 20);
            this.specText.TabIndex = 19;
            // 
            // specialtyLabel
            // 
            this.specialtyLabel.BackColor = System.Drawing.Color.Transparent;
            this.specialtyLabel.Location = new System.Drawing.Point(10, 206);
            this.specialtyLabel.Name = "specialtyLabel";
            this.specialtyLabel.Size = new System.Drawing.Size(70, 13);
            this.specialtyLabel.TabIndex = 20;
            this.specialtyLabel.Text = "Specialty:";
            // 
            // licText
            // 
            this.licText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.licText.Location = new System.Drawing.Point(81, 165);
            this.licText.Name = "licText";
            this.licText.Size = new System.Drawing.Size(119, 20);
            this.licText.TabIndex = 16;
            // 
            // licLabel
            // 
            this.licLabel.BackColor = System.Drawing.Color.Transparent;
            this.licLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.licLabel.Location = new System.Drawing.Point(10, 167);
            this.licLabel.Name = "licLabel";
            this.licLabel.Size = new System.Drawing.Size(70, 13);
            this.licLabel.TabIndex = 17;
            this.licLabel.Text = "License Id:";
            // 
            // ageText
            // 
            this.ageText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ageText.Location = new System.Drawing.Point(81, 124);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(60, 20);
            this.ageText.TabIndex = 14;
            // 
            // ageLabel
            // 
            this.ageLabel.BackColor = System.Drawing.Color.Transparent;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ageLabel.Location = new System.Drawing.Point(10, 127);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(70, 13);
            this.ageLabel.TabIndex = 15;
            this.ageLabel.Text = "Age:";
            // 
            // emailText
            // 
            this.emailText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.emailText.Location = new System.Drawing.Point(81, 85);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(352, 20);
            this.emailText.TabIndex = 12;
            // 
            // emailLabel
            // 
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.emailLabel.Location = new System.Drawing.Point(10, 88);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(70, 13);
            this.emailLabel.TabIndex = 13;
            this.emailLabel.Text = "Email:";
            // 
            // nameText
            // 
            this.nameText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameText.Location = new System.Drawing.Point(81, 49);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(207, 20);
            this.nameText.TabIndex = 10;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nameLabel.Location = new System.Drawing.Point(10, 51);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(70, 13);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Name:";
            // 
            // typeComboBox
            // 
            this.typeComboBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.typeComboBox.Location = new System.Drawing.Point(81, 14);
            this.typeComboBox.MaxDropDownItems = 2;
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(119, 21);
            this.typeComboBox.TabIndex = 8;
            // 
            // typeLabel
            // 
            this.typeLabel.BackColor = System.Drawing.Color.Transparent;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.typeLabel.Location = new System.Drawing.Point(10, 16);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(70, 13);
            this.typeLabel.TabIndex = 9;
            this.typeLabel.Text = "Person type:";
            // 
            // gpaLabel
            // 
            this.gpaLabel.BackColor = System.Drawing.Color.Transparent;
            this.gpaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpaLabel.Location = new System.Drawing.Point(10, 206);
            this.gpaLabel.Name = "gpaLabel";
            this.gpaLabel.Size = new System.Drawing.Size(60, 13);
            this.gpaLabel.TabIndex = 22;
            this.gpaLabel.Text = "GPA:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // awesomeRadioButton
            // 
            this.awesomeRadioButton.AutoSize = true;
            this.awesomeRadioButton.Location = new System.Drawing.Point(30, 19);
            this.awesomeRadioButton.Name = "awesomeRadioButton";
            this.awesomeRadioButton.Size = new System.Drawing.Size(71, 17);
            this.awesomeRadioButton.TabIndex = 24;
            this.awesomeRadioButton.TabStop = true;
            this.awesomeRadioButton.Text = "Awesome";
            this.awesomeRadioButton.UseVisualStyleBackColor = true;
            // 
            // okRadioButton
            // 
            this.okRadioButton.AutoSize = true;
            this.okRadioButton.Location = new System.Drawing.Point(30, 52);
            this.okRadioButton.Name = "okRadioButton";
            this.okRadioButton.Size = new System.Drawing.Size(39, 17);
            this.okRadioButton.TabIndex = 25;
            this.okRadioButton.TabStop = true;
            this.okRadioButton.Text = "Ok";
            this.okRadioButton.UseVisualStyleBackColor = true;
            // 
            // horribleRadioButton
            // 
            this.horribleRadioButton.AutoSize = true;
            this.horribleRadioButton.Location = new System.Drawing.Point(30, 87);
            this.horribleRadioButton.Name = "horribleRadioButton";
            this.horribleRadioButton.Size = new System.Drawing.Size(124, 17);
            this.horribleRadioButton.TabIndex = 26;
            this.horribleRadioButton.TabStop = true;
            this.horribleRadioButton.Text = "Avoid like the plague";
            this.horribleRadioButton.UseVisualStyleBackColor = true;
            // 
            // pizzaRadioButton
            // 
            this.pizzaRadioButton.AutoSize = true;
            this.pizzaRadioButton.Location = new System.Drawing.Point(22, 22);
            this.pizzaRadioButton.Name = "pizzaRadioButton";
            this.pizzaRadioButton.Size = new System.Drawing.Size(50, 17);
            this.pizzaRadioButton.TabIndex = 27;
            this.pizzaRadioButton.TabStop = true;
            this.pizzaRadioButton.Text = "Pizza";
            this.pizzaRadioButton.UseVisualStyleBackColor = true;
            // 
            // broccoliRadioButton
            // 
            this.broccoliRadioButton.AutoSize = true;
            this.broccoliRadioButton.Location = new System.Drawing.Point(22, 56);
            this.broccoliRadioButton.Name = "broccoliRadioButton";
            this.broccoliRadioButton.Size = new System.Drawing.Size(63, 17);
            this.broccoliRadioButton.TabIndex = 28;
            this.broccoliRadioButton.TabStop = true;
            this.broccoliRadioButton.Text = "Broccoli";
            this.broccoliRadioButton.UseVisualStyleBackColor = true;
            // 
            // wingsRadioButton
            // 
            this.wingsRadioButton.AutoSize = true;
            this.wingsRadioButton.Location = new System.Drawing.Point(22, 88);
            this.wingsRadioButton.Name = "wingsRadioButton";
            this.wingsRadioButton.Size = new System.Drawing.Size(55, 17);
            this.wingsRadioButton.TabIndex = 29;
            this.wingsRadioButton.TabStop = true;
            this.wingsRadioButton.Text = "Wings";
            this.wingsRadioButton.UseVisualStyleBackColor = true;
            // 
            // favFoodGroupBox
            // 
            this.favFoodGroupBox.Controls.Add(this.foodLabel);
            this.favFoodGroupBox.Controls.Add(this.pizzaRadioButton);
            this.favFoodGroupBox.Controls.Add(this.wingsRadioButton);
            this.favFoodGroupBox.Controls.Add(this.broccoliRadioButton);
            this.favFoodGroupBox.Location = new System.Drawing.Point(465, 12);
            this.favFoodGroupBox.Name = "favFoodGroupBox";
            this.favFoodGroupBox.Size = new System.Drawing.Size(147, 156);
            this.favFoodGroupBox.TabIndex = 30;
            this.favFoodGroupBox.TabStop = false;
            this.favFoodGroupBox.Text = "Fav Food";
            // 
            // qualGroupBox
            // 
            this.qualGroupBox.Controls.Add(this.awesomeRadioButton);
            this.qualGroupBox.Controls.Add(this.okRadioButton);
            this.qualGroupBox.Controls.Add(this.horribleRadioButton);
            this.qualGroupBox.Location = new System.Drawing.Point(618, 14);
            this.qualGroupBox.Name = "qualGroupBox";
            this.qualGroupBox.Size = new System.Drawing.Size(192, 123);
            this.qualGroupBox.TabIndex = 30;
            this.qualGroupBox.TabStop = false;
            this.qualGroupBox.Text = "Teacher Quality";
            // 
            // foodLabel
            // 
            this.foodLabel.AutoSize = true;
            this.foodLabel.Location = new System.Drawing.Point(42, 119);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(63, 13);
            this.foodLabel.TabIndex = 30;
            this.foodLabel.Text = "XXXXXXXX";
            // 
            // PersonEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 435);
            this.Controls.Add(this.qualGroupBox);
            this.Controls.Add(this.favFoodGroupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.gpaText);
            this.Controls.Add(this.specText);
            this.Controls.Add(this.specialtyLabel);
            this.Controls.Add(this.licText);
            this.Controls.Add(this.licLabel);
            this.Controls.Add(this.ageText);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.gpaLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(842, 478);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(462, 319);
            this.Name = "PersonEditForm";
            this.Text = "Edit Person";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.favFoodGroupBox.ResumeLayout(false);
            this.favFoodGroupBox.PerformLayout();
            this.qualGroupBox.ResumeLayout(false);
            this.qualGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox gpaText;
        private System.Windows.Forms.TextBox specText;
        private System.Windows.Forms.Label specialtyLabel;
        private System.Windows.Forms.TextBox licText;
        private System.Windows.Forms.Label licLabel;
        private System.Windows.Forms.TextBox ageText;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label gpaLabel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.RadioButton wingsRadioButton;
        private System.Windows.Forms.RadioButton broccoliRadioButton;
        private System.Windows.Forms.RadioButton pizzaRadioButton;
        private System.Windows.Forms.RadioButton horribleRadioButton;
        private System.Windows.Forms.RadioButton okRadioButton;
        private System.Windows.Forms.RadioButton awesomeRadioButton;
        private System.Windows.Forms.GroupBox qualGroupBox;
        private System.Windows.Forms.GroupBox favFoodGroupBox;
        private System.Windows.Forms.Label foodLabel;
    }
}

