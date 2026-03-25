namespace HotelManagementSystem.UI
{
    partial class Kitchen
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
            metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            TodoTabPage = new MetroFramework.Controls.MetroTabPage();
            onTheLineLabel = new MetroFramework.Controls.MetroLabel();
            updateButton = new MetroFramework.Controls.MetroButton();
            roomNLabel = new MetroFramework.Controls.MetroLabel();
            floorNLabel = new MetroFramework.Controls.MetroLabel();
            roomTypeLabel = new MetroFramework.Controls.MetroLabel();
            Todo = new GroupBox();
            dinnerQTLabel = new MetroFramework.Controls.MetroLabel();
            lunchQTLabel = new MetroFramework.Controls.MetroLabel();
            breakfastQTLabel = new MetroFramework.Controls.MetroLabel();
            breakfastTextBox = new MetroFramework.Controls.MetroTextBox();
            foodSelectionButton = new MetroFramework.Controls.MetroButton();
            supplyCheckBox = new MetroFramework.Controls.MetroCheckBox();
            lunchTextBox = new MetroFramework.Controls.MetroTextBox();
            towelCheckBox = new MetroFramework.Controls.MetroCheckBox();
            dinnerTextBox = new MetroFramework.Controls.MetroTextBox();
            cleaningCheckBox = new MetroFramework.Controls.MetroCheckBox();
            surpriseCheckBox = new MetroFramework.Controls.MetroCheckBox();
            floorNTextBox = new MetroFramework.Controls.MetroTextBox();
            roomNTextBox = new MetroFramework.Controls.MetroTextBox();
            roomTypeTextBox = new MetroFramework.Controls.MetroTextBox();
            phoneNTextBox = new MetroFramework.Controls.MetroTextBox();
            queueListBox = new ListBox();
            nameLabel = new MetroFramework.Controls.MetroLabel();
            phoneNLabel = new MetroFramework.Controls.MetroLabel();
            firstNameTextBox = new MetroFramework.Controls.MetroTextBox();
            lastNameTextBox = new MetroFramework.Controls.MetroTextBox();
            overviewTabPage = new MetroFramework.Controls.MetroTabPage();
            overviewDataGridView = new DataGridView();
            metroTabControl1.SuspendLayout();
            TodoTabPage.SuspendLayout();
            Todo.SuspendLayout();
            overviewTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)overviewDataGridView).BeginInit();
            SuspendLayout();
            // 
            // metroTabControl1
            // 
            metroTabControl1.Controls.Add(TodoTabPage);
            metroTabControl1.Controls.Add(overviewTabPage);
            metroTabControl1.Location = new Point(15, 97);
            metroTabControl1.Margin = new Padding(4, 5, 4, 5);
            metroTabControl1.Name = "metroTabControl1";
            metroTabControl1.Padding = new Point(6, 8);
            metroTabControl1.SelectedIndex = 1;
            metroTabControl1.Size = new Size(1311, 738);
            metroTabControl1.Style = MetroFramework.MetroColorStyle.Lime;
            metroTabControl1.TabIndex = 0;
            metroTabControl1.UseSelectable = true;
            metroTabControl1.SelectedIndexChanged += metroTabControl1_SelectedIndexChanged;
            // 
            // TodoTabPage
            // 
            TodoTabPage.Controls.Add(onTheLineLabel);
            TodoTabPage.Controls.Add(updateButton);
            TodoTabPage.Controls.Add(roomNLabel);
            TodoTabPage.Controls.Add(floorNLabel);
            TodoTabPage.Controls.Add(roomTypeLabel);
            TodoTabPage.Controls.Add(Todo);
            TodoTabPage.Controls.Add(floorNTextBox);
            TodoTabPage.Controls.Add(roomNTextBox);
            TodoTabPage.Controls.Add(roomTypeTextBox);
            TodoTabPage.Controls.Add(phoneNTextBox);
            TodoTabPage.Controls.Add(queueListBox);
            TodoTabPage.Controls.Add(nameLabel);
            TodoTabPage.Controls.Add(phoneNLabel);
            TodoTabPage.Controls.Add(firstNameTextBox);
            TodoTabPage.Controls.Add(lastNameTextBox);
            TodoTabPage.HorizontalScrollbarBarColor = true;
            TodoTabPage.HorizontalScrollbarHighlightOnWheel = false;
            TodoTabPage.HorizontalScrollbarSize = 15;
            TodoTabPage.Location = new Point(4, 38);
            TodoTabPage.Margin = new Padding(4, 5, 4, 5);
            TodoTabPage.Name = "TodoTabPage";
            TodoTabPage.Size = new Size(1303, 696);
            TodoTabPage.Style = MetroFramework.MetroColorStyle.Lime;
            TodoTabPage.TabIndex = 0;
            TodoTabPage.Text = "TODO*";
            TodoTabPage.VerticalScrollbarBarColor = true;
            TodoTabPage.VerticalScrollbarHighlightOnWheel = false;
            TodoTabPage.VerticalScrollbarSize = 13;
            // 
            // onTheLineLabel
            // 
            onTheLineLabel.AutoSize = true;
            onTheLineLabel.BackColor = Color.Transparent;
            onTheLineLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            onTheLineLabel.Location = new Point(943, 46);
            onTheLineLabel.Margin = new Padding(4, 0, 4, 0);
            onTheLineLabel.Name = "onTheLineLabel";
            onTheLineLabel.Size = new Size(81, 20);
            onTheLineLabel.TabIndex = 61;
            onTheLineLabel.Text = "On the line";
            onTheLineLabel.UseCustomBackColor = true;
            onTheLineLabel.UseCustomForeColor = true;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(943, 589);
            updateButton.Margin = new Padding(4, 5, 4, 5);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(299, 48);
            updateButton.Style = MetroFramework.MetroColorStyle.Green;
            updateButton.TabIndex = 60;
            updateButton.Text = "Update changes";
            updateButton.UseSelectable = true;
            updateButton.UseStyleColors = true;
            updateButton.Click += updateButton_Click;
            // 
            // roomNLabel
            // 
            roomNLabel.AutoSize = true;
            roomNLabel.BackColor = Color.Transparent;
            roomNLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            roomNLabel.Location = new Point(39, 392);
            roomNLabel.Margin = new Padding(4, 0, 4, 0);
            roomNLabel.Name = "roomNLabel";
            roomNLabel.Size = new Size(62, 20);
            roomNLabel.TabIndex = 58;
            roomNLabel.Text = "Room #";
            roomNLabel.UseCustomBackColor = true;
            roomNLabel.UseCustomForeColor = true;
            // 
            // floorNLabel
            // 
            floorNLabel.AutoSize = true;
            floorNLabel.BackColor = Color.Transparent;
            floorNLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            floorNLabel.Location = new Point(255, 297);
            floorNLabel.Margin = new Padding(4, 0, 4, 0);
            floorNLabel.Name = "floorNLabel";
            floorNLabel.Size = new Size(56, 20);
            floorNLabel.TabIndex = 57;
            floorNLabel.Text = "Floor #";
            floorNLabel.UseCustomBackColor = true;
            floorNLabel.UseCustomForeColor = true;
            // 
            // roomTypeLabel
            // 
            roomTypeLabel.AutoSize = true;
            roomTypeLabel.BackColor = Color.Transparent;
            roomTypeLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            roomTypeLabel.Location = new Point(39, 297);
            roomTypeLabel.Margin = new Padding(4, 0, 4, 0);
            roomTypeLabel.Name = "roomTypeLabel";
            roomTypeLabel.Size = new Size(82, 20);
            roomTypeLabel.TabIndex = 56;
            roomTypeLabel.Text = "Room type";
            roomTypeLabel.UseCustomBackColor = true;
            roomTypeLabel.UseCustomForeColor = true;
            // 
            // Todo
            // 
            Todo.BackColor = Color.Transparent;
            Todo.BackgroundImageLayout = ImageLayout.None;
            Todo.Controls.Add(dinnerQTLabel);
            Todo.Controls.Add(lunchQTLabel);
            Todo.Controls.Add(breakfastQTLabel);
            Todo.Controls.Add(breakfastTextBox);
            Todo.Controls.Add(foodSelectionButton);
            Todo.Controls.Add(supplyCheckBox);
            Todo.Controls.Add(lunchTextBox);
            Todo.Controls.Add(towelCheckBox);
            Todo.Controls.Add(dinnerTextBox);
            Todo.Controls.Add(cleaningCheckBox);
            Todo.Controls.Add(surpriseCheckBox);
            Todo.FlatStyle = FlatStyle.Flat;
            Todo.Location = new Point(469, 69);
            Todo.Margin = new Padding(4, 5, 4, 5);
            Todo.Name = "Todo";
            Todo.Padding = new Padding(4, 5, 4, 5);
            Todo.Size = new Size(465, 497);
            Todo.TabIndex = 55;
            Todo.TabStop = false;
            Todo.Text = "Todo";
            // 
            // dinnerQTLabel
            // 
            dinnerQTLabel.AutoSize = true;
            dinnerQTLabel.BackColor = Color.Transparent;
            dinnerQTLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            dinnerQTLabel.Location = new Point(23, 134);
            dinnerQTLabel.Margin = new Padding(4, 0, 4, 0);
            dinnerQTLabel.Name = "dinnerQTLabel";
            dinnerQTLabel.Size = new Size(93, 20);
            dinnerQTLabel.TabIndex = 63;
            dinnerQTLabel.Text = "Dinner [QTY]";
            dinnerQTLabel.UseCustomBackColor = true;
            dinnerQTLabel.UseCustomForeColor = true;
            // 
            // lunchQTLabel
            // 
            lunchQTLabel.AutoSize = true;
            lunchQTLabel.BackColor = Color.Transparent;
            lunchQTLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            lunchQTLabel.Location = new Point(239, 37);
            lunchQTLabel.Margin = new Padding(4, 0, 4, 0);
            lunchQTLabel.Name = "lunchQTLabel";
            lunchQTLabel.Size = new Size(87, 20);
            lunchQTLabel.TabIndex = 62;
            lunchQTLabel.Text = "Lunch [QTY]";
            lunchQTLabel.UseCustomBackColor = true;
            lunchQTLabel.UseCustomForeColor = true;
            // 
            // breakfastQTLabel
            // 
            breakfastQTLabel.AutoSize = true;
            breakfastQTLabel.BackColor = Color.Transparent;
            breakfastQTLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            breakfastQTLabel.Location = new Point(23, 37);
            breakfastQTLabel.Margin = new Padding(4, 0, 4, 0);
            breakfastQTLabel.Name = "breakfastQTLabel";
            breakfastQTLabel.Size = new Size(110, 20);
            breakfastQTLabel.TabIndex = 61;
            breakfastQTLabel.Text = "Breakfast [QTY]";
            breakfastQTLabel.UseCustomBackColor = true;
            breakfastQTLabel.UseCustomForeColor = true;
            // 
            // breakfastTextBox
            // 
            breakfastTextBox.BackColor = Color.White;
            breakfastTextBox.Enabled = false;
            breakfastTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            breakfastTextBox.Location = new Point(23, 71);
            breakfastTextBox.Margin = new Padding(4, 5, 4, 5);
            breakfastTextBox.MaxLength = 32767;
            breakfastTextBox.Name = "breakfastTextBox";
            breakfastTextBox.PasswordChar = '\0';
            breakfastTextBox.PromptText = "Breakfast";
            breakfastTextBox.ScrollBars = ScrollBars.None;
            breakfastTextBox.SelectedText = "";
            breakfastTextBox.Size = new Size(207, 45);
            breakfastTextBox.TabIndex = 47;
            breakfastTextBox.UseCustomBackColor = true;
            breakfastTextBox.UseSelectable = true;
            // 
            // foodSelectionButton
            // 
            foodSelectionButton.Location = new Point(23, 425);
            foodSelectionButton.Margin = new Padding(4, 5, 4, 5);
            foodSelectionButton.Name = "foodSelectionButton";
            foodSelectionButton.Size = new Size(423, 48);
            foodSelectionButton.Style = MetroFramework.MetroColorStyle.Green;
            foodSelectionButton.TabIndex = 59;
            foodSelectionButton.Text = "Change food selection?";
            foodSelectionButton.UseSelectable = true;
            foodSelectionButton.UseStyleColors = true;
            foodSelectionButton.Click += foodSelectionButton_Click;
            // 
            // supplyCheckBox
            // 
            supplyCheckBox.AutoSize = true;
            supplyCheckBox.BackColor = Color.Transparent;
            supplyCheckBox.Location = new Point(168, 366);
            supplyCheckBox.Margin = new Padding(4, 5, 4, 5);
            supplyCheckBox.Name = "supplyCheckBox";
            supplyCheckBox.Size = new Size(146, 17);
            supplyCheckBox.Style = MetroFramework.MetroColorStyle.Lime;
            supplyCheckBox.TabIndex = 42;
            supplyCheckBox.Text = "Food/Supply status ?";
            supplyCheckBox.UseCustomBackColor = true;
            supplyCheckBox.UseSelectable = true;
            supplyCheckBox.UseVisualStyleBackColor = false;
            supplyCheckBox.CheckedChanged += supplyCheckBox_CheckedChanged;
            // 
            // lunchTextBox
            // 
            lunchTextBox.BackColor = Color.White;
            lunchTextBox.Enabled = false;
            lunchTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            lunchTextBox.Location = new Point(239, 71);
            lunchTextBox.Margin = new Padding(4, 5, 4, 5);
            lunchTextBox.MaxLength = 32767;
            lunchTextBox.Name = "lunchTextBox";
            lunchTextBox.PasswordChar = '\0';
            lunchTextBox.PromptText = "Lunch";
            lunchTextBox.ScrollBars = ScrollBars.None;
            lunchTextBox.SelectedText = "";
            lunchTextBox.Size = new Size(207, 45);
            lunchTextBox.TabIndex = 48;
            lunchTextBox.UseCustomBackColor = true;
            lunchTextBox.UseSelectable = true;
            // 
            // towelCheckBox
            // 
            towelCheckBox.BackColor = Color.Transparent;
            towelCheckBox.Enabled = false;
            towelCheckBox.Location = new Point(180, 262);
            towelCheckBox.Margin = new Padding(4, 5, 4, 5);
            towelCheckBox.Name = "towelCheckBox";
            towelCheckBox.Size = new Size(103, 45);
            towelCheckBox.Style = MetroFramework.MetroColorStyle.Lime;
            towelCheckBox.TabIndex = 52;
            towelCheckBox.Text = "Towels";
            towelCheckBox.UseCustomBackColor = true;
            towelCheckBox.UseSelectable = true;
            towelCheckBox.UseVisualStyleBackColor = false;
            // 
            // dinnerTextBox
            // 
            dinnerTextBox.BackColor = Color.White;
            dinnerTextBox.Enabled = false;
            dinnerTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            dinnerTextBox.Location = new Point(23, 168);
            dinnerTextBox.Margin = new Padding(4, 5, 4, 5);
            dinnerTextBox.MaxLength = 32767;
            dinnerTextBox.Name = "dinnerTextBox";
            dinnerTextBox.PasswordChar = '\0';
            dinnerTextBox.PromptText = "Dinner";
            dinnerTextBox.ScrollBars = ScrollBars.None;
            dinnerTextBox.SelectedText = "";
            dinnerTextBox.Size = new Size(423, 45);
            dinnerTextBox.TabIndex = 49;
            dinnerTextBox.UseCustomBackColor = true;
            dinnerTextBox.UseSelectable = true;
            // 
            // cleaningCheckBox
            // 
            cleaningCheckBox.BackColor = Color.Transparent;
            cleaningCheckBox.Enabled = false;
            cleaningCheckBox.Location = new Point(29, 262);
            cleaningCheckBox.Margin = new Padding(4, 5, 4, 5);
            cleaningCheckBox.Name = "cleaningCheckBox";
            cleaningCheckBox.Size = new Size(103, 45);
            cleaningCheckBox.Style = MetroFramework.MetroColorStyle.Lime;
            cleaningCheckBox.TabIndex = 51;
            cleaningCheckBox.Text = "Cleaning";
            cleaningCheckBox.Theme = MetroFramework.MetroThemeStyle.Light;
            cleaningCheckBox.UseCustomBackColor = true;
            cleaningCheckBox.UseSelectable = true;
            cleaningCheckBox.UseVisualStyleBackColor = false;
            // 
            // surpriseCheckBox
            // 
            surpriseCheckBox.BackColor = Color.Transparent;
            surpriseCheckBox.Enabled = false;
            surpriseCheckBox.Location = new Point(291, 263);
            surpriseCheckBox.Margin = new Padding(4, 5, 4, 5);
            surpriseCheckBox.Name = "surpriseCheckBox";
            surpriseCheckBox.Size = new Size(161, 43);
            surpriseCheckBox.Style = MetroFramework.MetroColorStyle.Lime;
            surpriseCheckBox.TabIndex = 50;
            surpriseCheckBox.Text = "Sweetest Surprise";
            surpriseCheckBox.UseCustomBackColor = true;
            surpriseCheckBox.UseSelectable = true;
            surpriseCheckBox.UseVisualStyleBackColor = false;
            // 
            // floorNTextBox
            // 
            floorNTextBox.BackColor = Color.White;
            floorNTextBox.Enabled = false;
            floorNTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            floorNTextBox.Location = new Point(253, 331);
            floorNTextBox.Margin = new Padding(4, 5, 4, 5);
            floorNTextBox.MaxLength = 32767;
            floorNTextBox.Name = "floorNTextBox";
            floorNTextBox.PasswordChar = '\0';
            floorNTextBox.PromptText = "Floor #";
            floorNTextBox.ScrollBars = ScrollBars.None;
            floorNTextBox.SelectedText = "";
            floorNTextBox.Size = new Size(207, 45);
            floorNTextBox.TabIndex = 46;
            floorNTextBox.UseCustomBackColor = true;
            floorNTextBox.UseSelectable = true;
            // 
            // roomNTextBox
            // 
            roomNTextBox.BackColor = Color.White;
            roomNTextBox.Enabled = false;
            roomNTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            roomNTextBox.Location = new Point(41, 426);
            roomNTextBox.Margin = new Padding(4, 5, 4, 5);
            roomNTextBox.MaxLength = 32767;
            roomNTextBox.Name = "roomNTextBox";
            roomNTextBox.PasswordChar = '\0';
            roomNTextBox.PromptText = "Room #";
            roomNTextBox.ScrollBars = ScrollBars.None;
            roomNTextBox.SelectedText = "";
            roomNTextBox.Size = new Size(421, 45);
            roomNTextBox.TabIndex = 45;
            roomNTextBox.UseCustomBackColor = true;
            roomNTextBox.UseSelectable = true;
            // 
            // roomTypeTextBox
            // 
            roomTypeTextBox.BackColor = Color.White;
            roomTypeTextBox.Enabled = false;
            roomTypeTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            roomTypeTextBox.Location = new Point(39, 331);
            roomTypeTextBox.Margin = new Padding(4, 5, 4, 5);
            roomTypeTextBox.MaxLength = 32767;
            roomTypeTextBox.Name = "roomTypeTextBox";
            roomTypeTextBox.PasswordChar = '\0';
            roomTypeTextBox.PromptText = "Room type";
            roomTypeTextBox.ScrollBars = ScrollBars.None;
            roomTypeTextBox.SelectedText = "";
            roomTypeTextBox.Size = new Size(207, 45);
            roomTypeTextBox.TabIndex = 44;
            roomTypeTextBox.UseCustomBackColor = true;
            roomTypeTextBox.UseSelectable = true;
            // 
            // phoneNTextBox
            // 
            phoneNTextBox.BackColor = Color.White;
            phoneNTextBox.Enabled = false;
            phoneNTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            phoneNTextBox.Location = new Point(41, 237);
            phoneNTextBox.Margin = new Padding(4, 5, 4, 5);
            phoneNTextBox.MaxLength = 32767;
            phoneNTextBox.Name = "phoneNTextBox";
            phoneNTextBox.PasswordChar = '\0';
            phoneNTextBox.PromptText = "(999)-999-9999";
            phoneNTextBox.ScrollBars = ScrollBars.None;
            phoneNTextBox.SelectedText = "";
            phoneNTextBox.Size = new Size(421, 45);
            phoneNTextBox.Style = MetroFramework.MetroColorStyle.Lime;
            phoneNTextBox.TabIndex = 43;
            phoneNTextBox.UseCustomBackColor = true;
            phoneNTextBox.UseSelectable = true;
            // 
            // queueListBox
            // 
            queueListBox.FormattingEnabled = true;
            queueListBox.Location = new Point(943, 80);
            queueListBox.Margin = new Padding(4, 5, 4, 5);
            queueListBox.Name = "queueListBox";
            queueListBox.Size = new Size(297, 484);
            queueListBox.TabIndex = 40;
            queueListBox.SelectedIndexChanged += queueListBox_SelectedIndexChanged;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            nameLabel.Location = new Point(39, 106);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(49, 20);
            nameLabel.TabIndex = 23;
            nameLabel.Text = "Name";
            nameLabel.UseCustomBackColor = true;
            nameLabel.UseCustomForeColor = true;
            // 
            // phoneNLabel
            // 
            phoneNLabel.AutoSize = true;
            phoneNLabel.BackColor = Color.Transparent;
            phoneNLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            phoneNLabel.Location = new Point(40, 203);
            phoneNLabel.Margin = new Padding(4, 0, 4, 0);
            phoneNLabel.Name = "phoneNLabel";
            phoneNLabel.Size = new Size(105, 20);
            phoneNLabel.TabIndex = 30;
            phoneNLabel.Text = "Phone number";
            phoneNLabel.UseCustomBackColor = true;
            phoneNLabel.UseCustomForeColor = true;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BackColor = Color.White;
            firstNameTextBox.Enabled = false;
            firstNameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            firstNameTextBox.Location = new Point(40, 140);
            firstNameTextBox.Margin = new Padding(4, 5, 4, 5);
            firstNameTextBox.MaxLength = 32767;
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.PasswordChar = '\0';
            firstNameTextBox.PromptText = "First";
            firstNameTextBox.ScrollBars = ScrollBars.None;
            firstNameTextBox.SelectedText = "";
            firstNameTextBox.Size = new Size(207, 45);
            firstNameTextBox.Style = MetroFramework.MetroColorStyle.White;
            firstNameTextBox.TabIndex = 21;
            firstNameTextBox.UseCustomBackColor = true;
            firstNameTextBox.UseSelectable = true;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BackColor = Color.White;
            lastNameTextBox.Enabled = false;
            lastNameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            lastNameTextBox.Location = new Point(255, 140);
            lastNameTextBox.Margin = new Padding(4, 5, 4, 5);
            lastNameTextBox.MaxLength = 32767;
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.PasswordChar = '\0';
            lastNameTextBox.PromptText = "Last";
            lastNameTextBox.ScrollBars = ScrollBars.None;
            lastNameTextBox.SelectedText = "";
            lastNameTextBox.Size = new Size(207, 45);
            lastNameTextBox.TabIndex = 22;
            lastNameTextBox.UseCustomBackColor = true;
            lastNameTextBox.UseSelectable = true;
            // 
            // overviewTabPage
            // 
            overviewTabPage.Controls.Add(overviewDataGridView);
            overviewTabPage.HorizontalScrollbarBarColor = true;
            overviewTabPage.HorizontalScrollbarHighlightOnWheel = false;
            overviewTabPage.HorizontalScrollbarSize = 15;
            overviewTabPage.Location = new Point(4, 38);
            overviewTabPage.Margin = new Padding(4, 5, 4, 5);
            overviewTabPage.Name = "overviewTabPage";
            overviewTabPage.Size = new Size(1303, 696);
            overviewTabPage.TabIndex = 1;
            overviewTabPage.Text = "Overview";
            overviewTabPage.VerticalScrollbarBarColor = true;
            overviewTabPage.VerticalScrollbarHighlightOnWheel = false;
            overviewTabPage.VerticalScrollbarSize = 13;
            // 
            // overviewDataGridView
            // 
            overviewDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            overviewDataGridView.Location = new Point(0, 31);
            overviewDataGridView.Margin = new Padding(4, 5, 4, 5);
            overviewDataGridView.Name = "overviewDataGridView";
            overviewDataGridView.RowHeadersWidth = 51;
            overviewDataGridView.Size = new Size(1300, 526);
            overviewDataGridView.TabIndex = 2;
            // 
            // Kitchen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 846);
            Controls.Add(metroTabControl1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Kitchen";
            Padding = new Padding(27, 92, 27, 31);
            ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            Style = MetroFramework.MetroColorStyle.Lime;
            Text = "Room Service";
            FormClosing += kitchen_FormClosing;
            Load += kitchen_Load;
            metroTabControl1.ResumeLayout(false);
            TodoTabPage.ResumeLayout(false);
            TodoTabPage.PerformLayout();
            Todo.ResumeLayout(false);
            Todo.PerformLayout();
            overviewTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)overviewDataGridView).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage TodoTabPage;
        private MetroFramework.Controls.MetroTabPage overviewTabPage;
        private System.Windows.Forms.DataGridView overviewDataGridView;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroLabel phoneNLabel;
        private MetroFramework.Controls.MetroTextBox firstNameTextBox;
        private MetroFramework.Controls.MetroTextBox lastNameTextBox;
        private System.Windows.Forms.ListBox queueListBox;
        private MetroFramework.Controls.MetroTextBox phoneNTextBox;
        private MetroFramework.Controls.MetroCheckBox supplyCheckBox;
        private MetroFramework.Controls.MetroTextBox floorNTextBox;
        private MetroFramework.Controls.MetroTextBox roomNTextBox;
        private MetroFramework.Controls.MetroTextBox roomTypeTextBox;
        private MetroFramework.Controls.MetroCheckBox towelCheckBox;
        private MetroFramework.Controls.MetroCheckBox cleaningCheckBox;
        private MetroFramework.Controls.MetroCheckBox surpriseCheckBox;
        private MetroFramework.Controls.MetroTextBox dinnerTextBox;
        private MetroFramework.Controls.MetroTextBox lunchTextBox;
        private MetroFramework.Controls.MetroTextBox breakfastTextBox;
        private System.Windows.Forms.GroupBox Todo;
        private MetroFramework.Controls.MetroLabel roomNLabel;
        private MetroFramework.Controls.MetroLabel floorNLabel;
        private MetroFramework.Controls.MetroLabel roomTypeLabel;
        private MetroFramework.Controls.MetroButton foodSelectionButton;
        private MetroFramework.Controls.MetroButton updateButton;
        private MetroFramework.Controls.MetroLabel dinnerQTLabel;
        private MetroFramework.Controls.MetroLabel lunchQTLabel;
        private MetroFramework.Controls.MetroLabel breakfastQTLabel;
        private MetroFramework.Controls.MetroLabel onTheLineLabel;

    }
}