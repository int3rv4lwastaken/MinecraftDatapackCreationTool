namespace MDCTRevised
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            mainPanel = new Panel();
            errorNotif = new Label();
            selectFolderButton = new Button();
            label2 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label4 = new Label();
            packFormat = new NumericUpDown();
            label3 = new Label();
            datapackDescriptionText = new RichTextBox();
            datapackNamespaceField = new TextBox();
            datapackNameField = new TextBox();
            generateDatapack = new Button();
            label1 = new Label();
            closeButton = new Button();
            minimize = new Button();
            maximize = new Button();
            errorProvider1 = new ErrorProvider(components);
            toolTip1 = new ToolTip(components);
            settingsButton = new Button();
            mainPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)packFormat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BackColor = Color.FromArgb(64, 64, 64);
            mainPanel.Controls.Add(errorNotif);
            mainPanel.Controls.Add(selectFolderButton);
            mainPanel.Controls.Add(label2);
            mainPanel.Controls.Add(groupBox1);
            mainPanel.Controls.Add(generateDatapack);
            mainPanel.Location = new Point(12, 56);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(10);
            mainPanel.Size = new Size(842, 618);
            mainPanel.TabIndex = 1;
            // 
            // errorNotif
            // 
            errorNotif.AutoSize = true;
            errorNotif.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            errorNotif.ForeColor = Color.Red;
            errorNotif.Location = new Point(13, 578);
            errorNotif.Name = "errorNotif";
            errorNotif.Size = new Size(363, 21);
            errorNotif.TabIndex = 4;
            errorNotif.Text = "There were errors. Resolve them and try again.";
            errorNotif.Visible = false;
            // 
            // selectFolderButton
            // 
            selectFolderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            selectFolderButton.BackColor = Color.FromArgb(43, 43, 43);
            selectFolderButton.FlatAppearance.BorderSize = 0;
            selectFolderButton.FlatStyle = FlatStyle.Flat;
            selectFolderButton.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            selectFolderButton.ImageAlign = ContentAlignment.MiddleLeft;
            selectFolderButton.Location = new Point(437, 576);
            selectFolderButton.Name = "selectFolderButton";
            selectFolderButton.RightToLeft = RightToLeft.No;
            selectFolderButton.Size = new Size(146, 26);
            selectFolderButton.TabIndex = 3;
            selectFolderButton.Text = "Select Folder...";
            selectFolderButton.UseVisualStyleBackColor = false;
            selectFolderButton.Click += selectFolderButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 10);
            label2.Name = "label2";
            label2.Size = new Size(635, 21);
            label2.TabIndex = 2;
            label2.Text = "Fill out the information below and click Generate. A datapack folder will be created for you.";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(packFormat);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(datapackDescriptionText);
            groupBox1.Controls.Add(datapackNamespaceField);
            groupBox1.Controls.Add(datapackNameField);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(13, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(30);
            groupBox1.Size = new Size(816, 507);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datapack Information";
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
            button1.Location = new Point(739, 445);
            button1.Name = "button1";
            button1.Size = new Size(44, 29);
            button1.TabIndex = 6;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 447);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 5;
            label4.Text = "Pack Format";
            // 
            // packFormat
            // 
            packFormat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            packFormat.Location = new Point(134, 445);
            packFormat.Name = "packFormat";
            packFormat.Size = new Size(595, 29);
            packFormat.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 136);
            label3.Name = "label3";
            label3.Size = new Size(157, 21);
            label3.TabIndex = 3;
            label3.Text = "Datapack Description";
            // 
            // datapackDescriptionText
            // 
            datapackDescriptionText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datapackDescriptionText.BorderStyle = BorderStyle.None;
            datapackDescriptionText.Location = new Point(33, 164);
            datapackDescriptionText.Name = "datapackDescriptionText";
            datapackDescriptionText.Size = new Size(750, 268);
            datapackDescriptionText.TabIndex = 2;
            datapackDescriptionText.Text = "";
            // 
            // datapackNamespaceField
            // 
            datapackNamespaceField.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datapackNamespaceField.Location = new Point(33, 90);
            datapackNamespaceField.Name = "datapackNamespaceField";
            datapackNamespaceField.PlaceholderText = "Datapack Namespace";
            datapackNamespaceField.Size = new Size(750, 29);
            datapackNamespaceField.TabIndex = 1;
            // 
            // datapackNameField
            // 
            datapackNameField.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datapackNameField.Location = new Point(33, 55);
            datapackNameField.Name = "datapackNameField";
            datapackNameField.PlaceholderText = "Datapack Folder Name";
            datapackNameField.Size = new Size(750, 29);
            datapackNameField.TabIndex = 0;
            // 
            // generateDatapack
            // 
            generateDatapack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            generateDatapack.BackColor = Color.FromArgb(0, 192, 0);
            generateDatapack.FlatAppearance.BorderSize = 0;
            generateDatapack.FlatStyle = FlatStyle.Flat;
            generateDatapack.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            generateDatapack.ImageAlign = ContentAlignment.MiddleLeft;
            generateDatapack.Location = new Point(599, 570);
            generateDatapack.Name = "generateDatapack";
            generateDatapack.RightToLeft = RightToLeft.No;
            generateDatapack.Size = new Size(230, 35);
            generateDatapack.TabIndex = 0;
            generateDatapack.Text = "Generate";
            generateDatapack.UseVisualStyleBackColor = false;
            generateDatapack.Click += generateDatapack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(323, 30);
            label1.TabIndex = 2;
            label1.Text = "Minecraft Datapack Creation Tool";
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
            closeButton.Location = new Point(810, 9);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(44, 41);
            closeButton.TabIndex = 3;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // minimize
            // 
            minimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimize.BackColor = Color.Gray;
            minimize.FlatAppearance.BorderColor = Color.DimGray;
            minimize.FlatAppearance.BorderSize = 3;
            minimize.FlatStyle = FlatStyle.Flat;
            minimize.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minimize.ForeColor = Color.White;
            minimize.Location = new Point(710, 9);
            minimize.Name = "minimize";
            minimize.Size = new Size(44, 41);
            minimize.TabIndex = 4;
            minimize.Text = "_";
            minimize.UseVisualStyleBackColor = false;
            minimize.Click += minimize_Click;
            // 
            // maximize
            // 
            maximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maximize.BackColor = Color.Gray;
            maximize.FlatAppearance.BorderColor = Color.DimGray;
            maximize.FlatAppearance.BorderSize = 3;
            maximize.FlatStyle = FlatStyle.Flat;
            maximize.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            maximize.ForeColor = Color.White;
            maximize.Location = new Point(760, 9);
            maximize.Name = "maximize";
            maximize.Size = new Size(44, 41);
            maximize.TabIndex = 5;
            maximize.Text = "M";
            maximize.UseVisualStyleBackColor = false;
            maximize.Click += maximize_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // settingsButton
            // 
            settingsButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            settingsButton.BackColor = Color.Gray;
            settingsButton.FlatAppearance.BorderColor = Color.DimGray;
            settingsButton.FlatAppearance.BorderSize = 3;
            settingsButton.FlatStyle = FlatStyle.Flat;
            settingsButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            settingsButton.ForeColor = Color.White;
            settingsButton.Location = new Point(564, 9);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(140, 41);
            settingsButton.TabIndex = 6;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = false;
            settingsButton.Click += button2_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(866, 686);
            Controls.Add(settingsButton);
            Controls.Add(maximize);
            Controls.Add(minimize);
            Controls.Add(closeButton);
            Controls.Add(label1);
            Controls.Add(mainPanel);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)packFormat).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel mainPanel;
        private Label label1;
        private Button closeButton;
        private Button minimize;
        private Button maximize;
        private Button generateDatapack;
        private GroupBox groupBox1;
        private Label label2;
        private Label label4;
        private NumericUpDown packFormat;
        private Label label3;
        private RichTextBox datapackDescriptionText;
        private TextBox datapackNamespaceField;
        private TextBox datapackNameField;
        private Button button1;
        private Button selectFolderButton;
        private ErrorProvider errorProvider1;
        private Label errorNotif;
        private ToolTip toolTip1;
        private Button settingsButton;
    }
}
