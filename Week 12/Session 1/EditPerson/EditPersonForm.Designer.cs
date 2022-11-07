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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.editPersonTabControl = new System.Windows.Forms.TabControl();
            this.detailsTabPage = new System.Windows.Forms.TabPage();
            this.homepageLabel = new System.Windows.Forms.Label();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.photoGroupBox = new System.Windows.Forms.GroupBox();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.qualGroupBox = new System.Windows.Forms.GroupBox();
            this.awesomeRadioButton = new System.Windows.Forms.RadioButton();
            this.okRadioButton = new System.Windows.Forms.RadioButton();
            this.horribleRadioButton = new System.Windows.Forms.RadioButton();
            this.favFoodGroupBox = new System.Windows.Forms.GroupBox();
            this.foodLabel = new System.Windows.Forms.Label();
            this.pizzaRadioButton = new System.Windows.Forms.RadioButton();
            this.wingsRadioButton = new System.Windows.Forms.RadioButton();
            this.broccoliRadioButton = new System.Windows.Forms.RadioButton();
            this.homepageTextBox = new System.Windows.Forms.TextBox();
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
            this.homepageTabPage = new System.Windows.Forms.TabPage();
            this.homepageWebBrowser = new System.Windows.Forms.WebBrowser();
            this.coursesTabPage = new System.Windows.Forms.TabPage();
            this.selectedCoursesGroupBox = new System.Windows.Forms.GroupBox();
            this.selectedCoursesListView = new System.Windows.Forms.ListView();
            this.codeHdr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descHdr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.instructorName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dowHdr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeHdr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.allCoursesGroupBox = new System.Windows.Forms.GroupBox();
            this.courseSearchLabel = new System.Windows.Forms.Label();
            this.courseSearchTextBox = new System.Windows.Forms.TextBox();
            this.allCoursesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scheduleTabPage = new System.Windows.Forms.TabPage();
            this.scheduleWebBrowser = new System.Windows.Forms.WebBrowser();
            this.schContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.editPersonTabControl.SuspendLayout();
            this.detailsTabPage.SuspendLayout();
            this.photoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.qualGroupBox.SuspendLayout();
            this.favFoodGroupBox.SuspendLayout();
            this.homepageTabPage.SuspendLayout();
            this.coursesTabPage.SuspendLayout();
            this.selectedCoursesGroupBox.SuspendLayout();
            this.allCoursesGroupBox.SuspendLayout();
            this.scheduleTabPage.SuspendLayout();
            this.schContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // editPersonTabControl
            // 
            this.editPersonTabControl.Controls.Add(this.detailsTabPage);
            this.editPersonTabControl.Controls.Add(this.homepageTabPage);
            this.editPersonTabControl.Controls.Add(this.coursesTabPage);
            this.editPersonTabControl.Controls.Add(this.scheduleTabPage);
            this.editPersonTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editPersonTabControl.Location = new System.Drawing.Point(0, 0);
            this.editPersonTabControl.Name = "editPersonTabControl";
            this.editPersonTabControl.SelectedIndex = 0;
            this.editPersonTabControl.Size = new System.Drawing.Size(822, 435);
            this.editPersonTabControl.TabIndex = 0;
            // 
            // detailsTabPage
            // 
            this.detailsTabPage.Controls.Add(this.homepageLabel);
            this.detailsTabPage.Controls.Add(this.birthdateLabel);
            this.detailsTabPage.Controls.Add(this.birthDateTimePicker);
            this.detailsTabPage.Controls.Add(this.photoGroupBox);
            this.detailsTabPage.Controls.Add(this.qualGroupBox);
            this.detailsTabPage.Controls.Add(this.favFoodGroupBox);
            this.detailsTabPage.Controls.Add(this.homepageTextBox);
            this.detailsTabPage.Controls.Add(this.cancelButton);
            this.detailsTabPage.Controls.Add(this.okButton);
            this.detailsTabPage.Controls.Add(this.gpaText);
            this.detailsTabPage.Controls.Add(this.specText);
            this.detailsTabPage.Controls.Add(this.specialtyLabel);
            this.detailsTabPage.Controls.Add(this.licText);
            this.detailsTabPage.Controls.Add(this.licLabel);
            this.detailsTabPage.Controls.Add(this.ageText);
            this.detailsTabPage.Controls.Add(this.ageLabel);
            this.detailsTabPage.Controls.Add(this.emailText);
            this.detailsTabPage.Controls.Add(this.emailLabel);
            this.detailsTabPage.Controls.Add(this.nameText);
            this.detailsTabPage.Controls.Add(this.nameLabel);
            this.detailsTabPage.Controls.Add(this.typeComboBox);
            this.detailsTabPage.Controls.Add(this.typeLabel);
            this.detailsTabPage.Controls.Add(this.gpaLabel);
            this.detailsTabPage.Location = new System.Drawing.Point(4, 22);
            this.detailsTabPage.Name = "detailsTabPage";
            this.detailsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.detailsTabPage.Size = new System.Drawing.Size(814, 409);
            this.detailsTabPage.TabIndex = 0;
            this.detailsTabPage.Text = "Details";
            this.detailsTabPage.UseVisualStyleBackColor = true;
            // 
            // homepageLabel
            // 
            this.homepageLabel.AutoSize = true;
            this.homepageLabel.Location = new System.Drawing.Point(6, 229);
            this.homepageLabel.Name = "homepageLabel";
            this.homepageLabel.Size = new System.Drawing.Size(62, 13);
            this.homepageLabel.TabIndex = 59;
            this.homepageLabel.Text = "Homepage:";
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.AutoSize = true;
            this.birthdateLabel.Location = new System.Drawing.Point(8, 264);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(52, 13);
            this.birthdateLabel.TabIndex = 57;
            this.birthdateLabel.Text = "Birthdate:";
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.CustomFormat = "MMM d, yyyy";
            this.birthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDateTimePicker.Location = new System.Drawing.Point(78, 258);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(119, 20);
            this.birthDateTimePicker.TabIndex = 56;
            // 
            // photoGroupBox
            // 
            this.photoGroupBox.Controls.Add(this.photoPictureBox);
            this.photoGroupBox.Location = new System.Drawing.Point(608, 190);
            this.photoGroupBox.Name = "photoGroupBox";
            this.photoGroupBox.Size = new System.Drawing.Size(200, 179);
            this.photoGroupBox.TabIndex = 55;
            this.photoGroupBox.TabStop = false;
            this.photoGroupBox.Text = "Photo";
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BackColor = System.Drawing.Color.Gray;
            this.photoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.photoPictureBox.Location = new System.Drawing.Point(3, 16);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(194, 160);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoPictureBox.TabIndex = 31;
            this.photoPictureBox.TabStop = false;
            // 
            // qualGroupBox
            // 
            this.qualGroupBox.Controls.Add(this.awesomeRadioButton);
            this.qualGroupBox.Controls.Add(this.okRadioButton);
            this.qualGroupBox.Controls.Add(this.horribleRadioButton);
            this.qualGroupBox.Location = new System.Drawing.Point(616, 1);
            this.qualGroupBox.Name = "qualGroupBox";
            this.qualGroupBox.Size = new System.Drawing.Size(192, 123);
            this.qualGroupBox.TabIndex = 54;
            this.qualGroupBox.TabStop = false;
            this.qualGroupBox.Text = "Teacher Quality";
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
            // favFoodGroupBox
            // 
            this.favFoodGroupBox.Controls.Add(this.foodLabel);
            this.favFoodGroupBox.Controls.Add(this.pizzaRadioButton);
            this.favFoodGroupBox.Controls.Add(this.wingsRadioButton);
            this.favFoodGroupBox.Controls.Add(this.broccoliRadioButton);
            this.favFoodGroupBox.Location = new System.Drawing.Point(463, -1);
            this.favFoodGroupBox.Name = "favFoodGroupBox";
            this.favFoodGroupBox.Size = new System.Drawing.Size(147, 156);
            this.favFoodGroupBox.TabIndex = 53;
            this.favFoodGroupBox.TabStop = false;
            this.favFoodGroupBox.Text = "Fav Food";
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
            // homepageTextBox
            // 
            this.homepageTextBox.Location = new System.Drawing.Point(79, 226);
            this.homepageTextBox.Name = "homepageTextBox";
            this.homepageTextBox.Size = new System.Drawing.Size(352, 20);
            this.homepageTextBox.TabIndex = 58;
            // 
            // cancelButton
            // 
            this.cancelButton.CausesValidation = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(752, 386);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(56, 24);
            this.cancelButton.TabIndex = 52;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(678, 386);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(56, 24);
            this.okButton.TabIndex = 50;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // gpaText
            // 
            this.gpaText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gpaText.Location = new System.Drawing.Point(79, 190);
            this.gpaText.Name = "gpaText";
            this.gpaText.Size = new System.Drawing.Size(60, 20);
            this.gpaText.TabIndex = 47;
            // 
            // specText
            // 
            this.specText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.specText.Location = new System.Drawing.Point(79, 190);
            this.specText.Name = "specText";
            this.specText.Size = new System.Drawing.Size(352, 20);
            this.specText.TabIndex = 48;
            // 
            // specialtyLabel
            // 
            this.specialtyLabel.BackColor = System.Drawing.Color.Transparent;
            this.specialtyLabel.Location = new System.Drawing.Point(8, 193);
            this.specialtyLabel.Name = "specialtyLabel";
            this.specialtyLabel.Size = new System.Drawing.Size(70, 13);
            this.specialtyLabel.TabIndex = 49;
            this.specialtyLabel.Text = "Specialty:";
            // 
            // licText
            // 
            this.licText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.licText.Location = new System.Drawing.Point(79, 152);
            this.licText.Name = "licText";
            this.licText.Size = new System.Drawing.Size(119, 20);
            this.licText.TabIndex = 45;
            // 
            // licLabel
            // 
            this.licLabel.BackColor = System.Drawing.Color.Transparent;
            this.licLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.licLabel.Location = new System.Drawing.Point(8, 154);
            this.licLabel.Name = "licLabel";
            this.licLabel.Size = new System.Drawing.Size(70, 13);
            this.licLabel.TabIndex = 46;
            this.licLabel.Text = "License Id:";
            // 
            // ageText
            // 
            this.ageText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ageText.Location = new System.Drawing.Point(79, 111);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(60, 20);
            this.ageText.TabIndex = 43;
            // 
            // ageLabel
            // 
            this.ageLabel.BackColor = System.Drawing.Color.Transparent;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ageLabel.Location = new System.Drawing.Point(8, 114);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(70, 13);
            this.ageLabel.TabIndex = 44;
            this.ageLabel.Text = "Age:";
            // 
            // emailText
            // 
            this.emailText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.emailText.Location = new System.Drawing.Point(79, 72);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(352, 20);
            this.emailText.TabIndex = 41;
            // 
            // emailLabel
            // 
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.emailLabel.Location = new System.Drawing.Point(8, 75);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(70, 13);
            this.emailLabel.TabIndex = 42;
            this.emailLabel.Text = "Email:";
            // 
            // nameText
            // 
            this.nameText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameText.Location = new System.Drawing.Point(79, 36);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(207, 20);
            this.nameText.TabIndex = 39;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nameLabel.Location = new System.Drawing.Point(8, 38);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(70, 13);
            this.nameLabel.TabIndex = 40;
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
            this.typeComboBox.Location = new System.Drawing.Point(79, 1);
            this.typeComboBox.MaxDropDownItems = 2;
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(119, 21);
            this.typeComboBox.TabIndex = 37;
            // 
            // typeLabel
            // 
            this.typeLabel.BackColor = System.Drawing.Color.Transparent;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.typeLabel.Location = new System.Drawing.Point(8, 3);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(70, 13);
            this.typeLabel.TabIndex = 38;
            this.typeLabel.Text = "Person type:";
            // 
            // gpaLabel
            // 
            this.gpaLabel.BackColor = System.Drawing.Color.Transparent;
            this.gpaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpaLabel.Location = new System.Drawing.Point(8, 193);
            this.gpaLabel.Name = "gpaLabel";
            this.gpaLabel.Size = new System.Drawing.Size(60, 13);
            this.gpaLabel.TabIndex = 51;
            this.gpaLabel.Text = "GPA:";
            // 
            // homepageTabPage
            // 
            this.homepageTabPage.Controls.Add(this.homepageWebBrowser);
            this.homepageTabPage.Location = new System.Drawing.Point(4, 22);
            this.homepageTabPage.Name = "homepageTabPage";
            this.homepageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.homepageTabPage.Size = new System.Drawing.Size(814, 409);
            this.homepageTabPage.TabIndex = 1;
            this.homepageTabPage.Text = "Homepage";
            this.homepageTabPage.UseVisualStyleBackColor = true;
            // 
            // homepageWebBrowser
            // 
            this.homepageWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homepageWebBrowser.Location = new System.Drawing.Point(3, 3);
            this.homepageWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.homepageWebBrowser.Name = "homepageWebBrowser";
            this.homepageWebBrowser.ScriptErrorsSuppressed = true;
            this.homepageWebBrowser.Size = new System.Drawing.Size(808, 403);
            this.homepageWebBrowser.TabIndex = 0;
            // 
            // coursesTabPage
            // 
            this.coursesTabPage.Controls.Add(this.selectedCoursesGroupBox);
            this.coursesTabPage.Controls.Add(this.allCoursesGroupBox);
            this.coursesTabPage.Location = new System.Drawing.Point(4, 22);
            this.coursesTabPage.Name = "coursesTabPage";
            this.coursesTabPage.Size = new System.Drawing.Size(814, 409);
            this.coursesTabPage.TabIndex = 2;
            this.coursesTabPage.Text = "Courses";
            this.coursesTabPage.UseVisualStyleBackColor = true;
            // 
            // selectedCoursesGroupBox
            // 
            this.selectedCoursesGroupBox.Controls.Add(this.selectedCoursesListView);
            this.selectedCoursesGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectedCoursesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.selectedCoursesGroupBox.Name = "selectedCoursesGroupBox";
            this.selectedCoursesGroupBox.Size = new System.Drawing.Size(814, 152);
            this.selectedCoursesGroupBox.TabIndex = 2;
            this.selectedCoursesGroupBox.TabStop = false;
            this.selectedCoursesGroupBox.Text = "Selected Courses";
            // 
            // selectedCoursesListView
            // 
            this.selectedCoursesListView.BackColor = System.Drawing.SystemColors.Window;
            this.selectedCoursesListView.BackgroundImageTiled = true;
            this.selectedCoursesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codeHdr,
            this.descHdr,
            this.instructorName,
            this.dowHdr,
            this.timeHdr});
            this.selectedCoursesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedCoursesListView.FullRowSelect = true;
            this.selectedCoursesListView.HideSelection = false;
            this.selectedCoursesListView.Location = new System.Drawing.Point(3, 16);
            this.selectedCoursesListView.Margin = new System.Windows.Forms.Padding(2);
            this.selectedCoursesListView.Name = "selectedCoursesListView";
            this.selectedCoursesListView.Size = new System.Drawing.Size(808, 133);
            this.selectedCoursesListView.TabIndex = 11;
            this.selectedCoursesListView.UseCompatibleStateImageBehavior = false;
            this.selectedCoursesListView.View = System.Windows.Forms.View.Details;
            // 
            // codeHdr
            // 
            this.codeHdr.Text = "Code";
            this.codeHdr.Width = 180;
            // 
            // descHdr
            // 
            this.descHdr.Text = "Description";
            this.descHdr.Width = 250;
            // 
            // instructorName
            // 
            this.instructorName.Text = "Instructor";
            this.instructorName.Width = 175;
            // 
            // dowHdr
            // 
            this.dowHdr.Text = "Days";
            this.dowHdr.Width = 100;
            // 
            // timeHdr
            // 
            this.timeHdr.Text = "Time";
            this.timeHdr.Width = 300;
            // 
            // allCoursesGroupBox
            // 
            this.allCoursesGroupBox.Controls.Add(this.courseSearchLabel);
            this.allCoursesGroupBox.Controls.Add(this.courseSearchTextBox);
            this.allCoursesGroupBox.Controls.Add(this.allCoursesListView);
            this.allCoursesGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.allCoursesGroupBox.Location = new System.Drawing.Point(0, 161);
            this.allCoursesGroupBox.Name = "allCoursesGroupBox";
            this.allCoursesGroupBox.Size = new System.Drawing.Size(814, 248);
            this.allCoursesGroupBox.TabIndex = 3;
            this.allCoursesGroupBox.TabStop = false;
            this.allCoursesGroupBox.Text = "All Courses";
            // 
            // courseSearchLabel
            // 
            this.courseSearchLabel.AutoSize = true;
            this.courseSearchLabel.Location = new System.Drawing.Point(134, 23);
            this.courseSearchLabel.Name = "courseSearchLabel";
            this.courseSearchLabel.Size = new System.Drawing.Size(44, 13);
            this.courseSearchLabel.TabIndex = 14;
            this.courseSearchLabel.Text = "Search:";
            // 
            // courseSearchTextBox
            // 
            this.courseSearchTextBox.Location = new System.Drawing.Point(184, 20);
            this.courseSearchTextBox.Name = "courseSearchTextBox";
            this.courseSearchTextBox.Size = new System.Drawing.Size(451, 20);
            this.courseSearchTextBox.TabIndex = 13;
            // 
            // allCoursesListView
            // 
            this.allCoursesListView.BackColor = System.Drawing.SystemColors.Window;
            this.allCoursesListView.BackgroundImageTiled = true;
            this.allCoursesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.allCoursesListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.allCoursesListView.FullRowSelect = true;
            this.allCoursesListView.HideSelection = false;
            this.allCoursesListView.Location = new System.Drawing.Point(3, 44);
            this.allCoursesListView.Margin = new System.Windows.Forms.Padding(2);
            this.allCoursesListView.Name = "allCoursesListView";
            this.allCoursesListView.Size = new System.Drawing.Size(808, 201);
            this.allCoursesListView.TabIndex = 12;
            this.allCoursesListView.UseCompatibleStateImageBehavior = false;
            this.allCoursesListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Code";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Instructor";
            this.columnHeader3.Width = 175;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Days";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Time";
            this.columnHeader5.Width = 300;
            // 
            // scheduleTabPage
            // 
            this.scheduleTabPage.Controls.Add(this.scheduleWebBrowser);
            this.scheduleTabPage.Location = new System.Drawing.Point(4, 22);
            this.scheduleTabPage.Name = "scheduleTabPage";
            this.scheduleTabPage.Size = new System.Drawing.Size(814, 409);
            this.scheduleTabPage.TabIndex = 3;
            this.scheduleTabPage.Text = "Schedule";
            this.scheduleTabPage.UseVisualStyleBackColor = true;
            // 
            // scheduleWebBrowser
            // 
            this.scheduleWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scheduleWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.scheduleWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.scheduleWebBrowser.Name = "scheduleWebBrowser";
            this.scheduleWebBrowser.ScriptErrorsSuppressed = true;
            this.scheduleWebBrowser.Size = new System.Drawing.Size(814, 409);
            this.scheduleWebBrowser.TabIndex = 0;
            // 
            // schContextMenuStrip
            // 
            this.schContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.schContextMenuStrip.Name = "schContextMenuStrip";
            this.schContextMenuStrip.Size = new System.Drawing.Size(118, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "&Remove";
            // 
            // PersonEditForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(822, 435);
            this.Controls.Add(this.editPersonTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(842, 478);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(462, 319);
            this.Name = "PersonEditForm";
            this.Text = "Edit Person";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.editPersonTabControl.ResumeLayout(false);
            this.detailsTabPage.ResumeLayout(false);
            this.detailsTabPage.PerformLayout();
            this.photoGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.qualGroupBox.ResumeLayout(false);
            this.qualGroupBox.PerformLayout();
            this.favFoodGroupBox.ResumeLayout(false);
            this.favFoodGroupBox.PerformLayout();
            this.homepageTabPage.ResumeLayout(false);
            this.coursesTabPage.ResumeLayout(false);
            this.selectedCoursesGroupBox.ResumeLayout(false);
            this.allCoursesGroupBox.ResumeLayout(false);
            this.allCoursesGroupBox.PerformLayout();
            this.scheduleTabPage.ResumeLayout(false);
            this.schContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabControl editPersonTabControl;
        private System.Windows.Forms.TabPage detailsTabPage;
        private System.Windows.Forms.Label homepageLabel;
        private System.Windows.Forms.Label birthdateLabel;
        private System.Windows.Forms.DateTimePicker birthDateTimePicker;
        private System.Windows.Forms.GroupBox photoGroupBox;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.GroupBox qualGroupBox;
        private System.Windows.Forms.RadioButton awesomeRadioButton;
        private System.Windows.Forms.RadioButton okRadioButton;
        private System.Windows.Forms.RadioButton horribleRadioButton;
        private System.Windows.Forms.GroupBox favFoodGroupBox;
        private System.Windows.Forms.Label foodLabel;
        private System.Windows.Forms.RadioButton pizzaRadioButton;
        private System.Windows.Forms.RadioButton wingsRadioButton;
        private System.Windows.Forms.RadioButton broccoliRadioButton;
        private System.Windows.Forms.TextBox homepageTextBox;
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
        private System.Windows.Forms.TabPage homepageTabPage;
        private System.Windows.Forms.WebBrowser homepageWebBrowser;
        private System.Windows.Forms.TabPage coursesTabPage;
        private System.Windows.Forms.GroupBox selectedCoursesGroupBox;
        private System.Windows.Forms.ListView selectedCoursesListView;
        private System.Windows.Forms.ColumnHeader codeHdr;
        private System.Windows.Forms.ColumnHeader descHdr;
        private System.Windows.Forms.ColumnHeader instructorName;
        private System.Windows.Forms.ColumnHeader dowHdr;
        private System.Windows.Forms.ColumnHeader timeHdr;
        private System.Windows.Forms.GroupBox allCoursesGroupBox;
        private System.Windows.Forms.Label courseSearchLabel;
        private System.Windows.Forms.TextBox courseSearchTextBox;
        private System.Windows.Forms.ListView allCoursesListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TabPage scheduleTabPage;
        private System.Windows.Forms.WebBrowser scheduleWebBrowser;
        private System.Windows.Forms.ContextMenuStrip schContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolTip schToolTip;
    }
}

