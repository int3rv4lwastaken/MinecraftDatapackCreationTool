namespace MDCTRevised
{
    partial class SettingsForm
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
            closeButton = new Button();
            mainPanel = new Panel();
            debugGroup = new GroupBox();
            exceptionSelect = new ComboBox();
            label7 = new Label();
            reportBug = new Button();
            triggerErrorHandler = new Button();
            saveChangesButton = new Button();
            selectFolderButton = new Button();
            label2 = new Label();
            groupBox1 = new GroupBox();
            selectLaunchDirectory = new Button();
            themeSelect = new ComboBox();
            toggleCloseAlert = new CheckBox();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            button1 = new Button();
            label4 = new Label();
            packFormat = new NumericUpDown();
            generateDatapack = new Button();
            label6 = new Label();
            label8 = new Label();
            mainPanel.SuspendLayout();
            debugGroup.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)packFormat).BeginInit();
            SuspendLayout();
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeButton.BackColor = Color.IndianRed;
            closeButton.FlatAppearance.BorderColor = Color.FromArgb(183, 60, 60);
            closeButton.FlatAppearance.BorderSize = 3;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(902, 12);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(44, 41);
            closeButton.TabIndex = 4;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BackColor = Color.FromArgb(64, 64, 64);
            mainPanel.Controls.Add(debugGroup);
            mainPanel.Controls.Add(saveChangesButton);
            mainPanel.Controls.Add(selectFolderButton);
            mainPanel.Controls.Add(label2);
            mainPanel.Controls.Add(groupBox1);
            mainPanel.Controls.Add(generateDatapack);
            mainPanel.Location = new Point(12, 70);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(10);
            mainPanel.Size = new Size(934, 574);
            mainPanel.TabIndex = 5;
            // 
            // debugGroup
            // 
            debugGroup.Controls.Add(exceptionSelect);
            debugGroup.Controls.Add(label7);
            debugGroup.Controls.Add(reportBug);
            debugGroup.Controls.Add(triggerErrorHandler);
            debugGroup.FlatStyle = FlatStyle.Flat;
            debugGroup.Font = new Font("Segoe UI", 12F);
            debugGroup.ForeColor = Color.White;
            debugGroup.Location = new Point(13, 204);
            debugGroup.Name = "debugGroup";
            debugGroup.Padding = new Padding(12);
            debugGroup.Size = new Size(908, 310);
            debugGroup.TabIndex = 5;
            debugGroup.TabStop = false;
            debugGroup.Text = "Debug Options";
            // 
            // exceptionSelect
            // 
            exceptionSelect.FormattingEnabled = true;
            exceptionSelect.Location = new Point(15, 68);
            exceptionSelect.Name = "exceptionSelect";
            exceptionSelect.Size = new Size(429, 29);
            exceptionSelect.TabIndex = 8;
            exceptionSelect.Text = "Exception (for triggering the error handler from here)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 34);
            label7.Name = "label7";
            label7.Size = new Size(370, 21);
            label7.TabIndex = 7;
            label7.Text = "Only use these tools if you know what you're doing!";
            // 
            // reportBug
            // 
            reportBug.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            reportBug.BackColor = Color.Red;
            reportBug.FlatAppearance.BorderSize = 0;
            reportBug.FlatStyle = FlatStyle.Flat;
            reportBug.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            reportBug.ImageAlign = ContentAlignment.MiddleLeft;
            reportBug.Location = new Point(513, 260);
            reportBug.Name = "reportBug";
            reportBug.Padding = new Padding(5);
            reportBug.RightToLeft = RightToLeft.No;
            reportBug.Size = new Size(187, 35);
            reportBug.TabIndex = 6;
            reportBug.Text = "Report Bug";
            reportBug.UseVisualStyleBackColor = false;
            reportBug.Click += reportBug_Click;
            // 
            // triggerErrorHandler
            // 
            triggerErrorHandler.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            triggerErrorHandler.BackColor = Color.Red;
            triggerErrorHandler.FlatAppearance.BorderSize = 0;
            triggerErrorHandler.FlatStyle = FlatStyle.Flat;
            triggerErrorHandler.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            triggerErrorHandler.ImageAlign = ContentAlignment.MiddleLeft;
            triggerErrorHandler.Location = new Point(706, 260);
            triggerErrorHandler.Name = "triggerErrorHandler";
            triggerErrorHandler.Padding = new Padding(5);
            triggerErrorHandler.RightToLeft = RightToLeft.No;
            triggerErrorHandler.Size = new Size(187, 35);
            triggerErrorHandler.TabIndex = 5;
            triggerErrorHandler.Text = "Trigger Error Handler";
            triggerErrorHandler.UseVisualStyleBackColor = false;
            triggerErrorHandler.Click += triggerErrorHandler_Click;
            // 
            // saveChangesButton
            // 
            saveChangesButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveChangesButton.BackColor = Color.FromArgb(43, 43, 43);
            saveChangesButton.FlatAppearance.BorderSize = 0;
            saveChangesButton.FlatStyle = FlatStyle.Flat;
            saveChangesButton.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            saveChangesButton.ImageAlign = ContentAlignment.MiddleLeft;
            saveChangesButton.Location = new Point(716, 520);
            saveChangesButton.Name = "saveChangesButton";
            saveChangesButton.RightToLeft = RightToLeft.No;
            saveChangesButton.Size = new Size(205, 41);
            saveChangesButton.TabIndex = 4;
            saveChangesButton.Text = "Save Settings";
            saveChangesButton.UseVisualStyleBackColor = false;
            saveChangesButton.Click += saveChangesButton_Click;
            // 
            // selectFolderButton
            // 
            selectFolderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            selectFolderButton.BackColor = Color.FromArgb(43, 43, 43);
            selectFolderButton.FlatAppearance.BorderSize = 0;
            selectFolderButton.FlatStyle = FlatStyle.Flat;
            selectFolderButton.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            selectFolderButton.ImageAlign = ContentAlignment.MiddleLeft;
            selectFolderButton.Location = new Point(1161, 1040);
            selectFolderButton.Name = "selectFolderButton";
            selectFolderButton.RightToLeft = RightToLeft.No;
            selectFolderButton.Size = new Size(146, 26);
            selectFolderButton.TabIndex = 3;
            selectFolderButton.Text = "Select Folder...";
            selectFolderButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 20);
            label2.Name = "label2";
            label2.Size = new Size(444, 21);
            label2.TabIndex = 2;
            label2.Text = "Configure your Minecraft Datapack Creation Tool settings here.";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(selectLaunchDirectory);
            groupBox1.Controls.Add(themeSelect);
            groupBox1.Controls.Add(toggleCloseAlert);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(packFormat);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(13, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(12);
            groupBox1.Size = new Size(908, 142);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "General Settings";
            // 
            // selectLaunchDirectory
            // 
            selectLaunchDirectory.BackColor = Color.FromArgb(43, 43, 43);
            selectLaunchDirectory.FlatAppearance.BorderSize = 0;
            selectLaunchDirectory.FlatStyle = FlatStyle.Flat;
            selectLaunchDirectory.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            selectLaunchDirectory.ImageAlign = ContentAlignment.MiddleLeft;
            selectLaunchDirectory.Location = new Point(203, 66);
            selectLaunchDirectory.Name = "selectLaunchDirectory";
            selectLaunchDirectory.RightToLeft = RightToLeft.No;
            selectLaunchDirectory.Size = new Size(197, 35);
            selectLaunchDirectory.TabIndex = 13;
            selectLaunchDirectory.Text = "Select Folder...";
            selectLaunchDirectory.UseVisualStyleBackColor = false;
            selectLaunchDirectory.Click += selectLaunchDirectory_Click;
            // 
            // themeSelect
            // 
            themeSelect.FormattingEnabled = true;
            themeSelect.Items.AddRange(new object[] { "Dark", "Light", "System Default" });
            themeSelect.Location = new Point(144, 31);
            themeSelect.Name = "themeSelect";
            themeSelect.Size = new Size(303, 29);
            themeSelect.TabIndex = 12;
            themeSelect.SelectedValueChanged += themeSelect_SelectedValueChanged;
            // 
            // toggleCloseAlert
            // 
            toggleCloseAlert.Location = new Point(271, 105);
            toggleCloseAlert.Name = "toggleCloseAlert";
            toggleCloseAlert.Size = new Size(70, 27);
            toggleCloseAlert.TabIndex = 11;
            toggleCloseAlert.UseVisualStyleBackColor = true;
            toggleCloseAlert.CheckedChanged += toggleCloseAlert_CheckedChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 105);
            label5.Name = "label5";
            label5.Size = new Size(250, 21);
            label5.TabIndex = 9;
            label5.Text = "Show Alert when Closing Software";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 74);
            label3.Name = "label3";
            label3.Size = new Size(182, 21);
            label3.TabIndex = 8;
            label3.Text = "Default Launch Directory";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 34);
            label1.Name = "label1";
            label1.Size = new Size(123, 21);
            label1.TabIndex = 7;
            label1.Text = "Software Theme";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Gray;
            button1.FlatAppearance.BorderColor = Color.DimGray;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1438, 478);
            button1.Name = "button1";
            button1.Size = new Size(44, 29);
            button1.TabIndex = 6;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 480);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 5;
            label4.Text = "Pack Format";
            // 
            // packFormat
            // 
            packFormat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            packFormat.Location = new Point(143, 478);
            packFormat.Name = "packFormat";
            packFormat.Size = new Size(1285, 29);
            packFormat.TabIndex = 4;
            // 
            // generateDatapack
            // 
            generateDatapack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            generateDatapack.BackColor = Color.FromArgb(0, 192, 0);
            generateDatapack.FlatAppearance.BorderSize = 0;
            generateDatapack.FlatStyle = FlatStyle.Flat;
            generateDatapack.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            generateDatapack.ImageAlign = ContentAlignment.MiddleLeft;
            generateDatapack.Location = new Point(1323, 1034);
            generateDatapack.Name = "generateDatapack";
            generateDatapack.RightToLeft = RightToLeft.No;
            generateDatapack.Size = new Size(230, 35);
            generateDatapack.TabIndex = 0;
            generateDatapack.Text = "Generate";
            generateDatapack.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 17);
            label6.Name = "label6";
            label6.Size = new Size(87, 30);
            label6.TabIndex = 14;
            label6.Text = "Settings";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(453, 34);
            label8.Name = "label8";
            label8.Size = new Size(165, 21);
            label8.TabIndex = 14;
            label8.Text = "Doesn't function yet";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(958, 656);
            Controls.Add(label6);
            Controls.Add(mainPanel);
            Controls.Add(closeButton);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += SettingsForm_Load;
            MouseDown += SettingsForm_MouseDown;
            MouseMove += SettingsForm_MouseMove;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            debugGroup.ResumeLayout(false);
            debugGroup.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)packFormat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button closeButton;
        private Panel mainPanel;
        private Button selectFolderButton;
        private Label label2;
        private GroupBox groupBox1;
        private Button button1;
        private Label label4;
        private NumericUpDown packFormat;
        private Button generateDatapack;
        private Label label5;
        private Label label3;
        private Label label1;
        private ComboBox themeSelect;
        private CheckBox toggleCloseAlert;
        private Button saveChangesButton;
        private Button selectLaunchDirectory;
        private Label label6;
        private GroupBox debugGroup;
        private Button reportBug;
        private Button triggerErrorHandler;
        private ComboBox exceptionSelect;
        private Label label7;
        private Label label8;
    }
}