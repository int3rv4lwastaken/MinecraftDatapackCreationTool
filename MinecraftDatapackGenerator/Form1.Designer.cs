namespace MinecraftDatapackGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            label3 = new Label();
            selectDestination = new Button();
            datapackNameField = new TextBox();
            descriptionField = new RichTextBox();
            generateButton = new Button();
            packFormatField = new TextBox();
            datapackTagField = new TextBox();
            linkLabel1 = new LinkLabel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Location = new Point(12, 33);
            label2.Name = "label2";
            label2.Size = new Size(532, 53);
            label2.TabIndex = 0;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(416, 23);
            label3.TabIndex = 1;
            label3.Text = "No destination selected.";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // selectDestination
            // 
            selectDestination.Location = new Point(434, 86);
            selectDestination.Name = "selectDestination";
            selectDestination.Size = new Size(110, 23);
            selectDestination.TabIndex = 2;
            selectDestination.Text = "Select Folder";
            selectDestination.UseVisualStyleBackColor = true;
            selectDestination.MouseClick += selectDestination_MouseClick;
            // 
            // datapackNameField
            // 
            datapackNameField.Location = new Point(12, 115);
            datapackNameField.Name = "datapackNameField";
            datapackNameField.PlaceholderText = "Enter a name for your datapack folder.";
            datapackNameField.Size = new Size(532, 23);
            datapackNameField.TabIndex = 3;
            // 
            // descriptionField
            // 
            descriptionField.Location = new Point(12, 144);
            descriptionField.Name = "descriptionField";
            descriptionField.Size = new Size(532, 108);
            descriptionField.TabIndex = 4;
            descriptionField.Text = "Replace this text with a brief description of what your datapack is about. It'll appear in your datapack's \"pack.mcmeta\" file.";
            // 
            // generateButton
            // 
            generateButton.Location = new Point(434, 316);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(110, 29);
            generateButton.TabIndex = 5;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.MouseClick += generateButton_MouseClick;
            // 
            // packFormatField
            // 
            packFormatField.Location = new Point(12, 287);
            packFormatField.Name = "packFormatField";
            packFormatField.PlaceholderText = "Enter the format number. You can find it through the web. (Example: 61 (1.21.4))";
            packFormatField.Size = new Size(532, 23);
            packFormatField.TabIndex = 6;
            // 
            // datapackTagField
            // 
            datapackTagField.Location = new Point(12, 258);
            datapackTagField.Name = "datapackTagField";
            datapackTagField.PlaceholderText = "Enter a tag that will be used to call functions. (Example: minecraft:tick)";
            datapackTagField.Size = new Size(532, 23);
            datapackTagField.TabIndex = 7;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 323);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(230, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Report problems via the GitHub repository";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientInactiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(556, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(180, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 357);
            Controls.Add(linkLabel1);
            Controls.Add(datapackTagField);
            Controls.Add(packFormatField);
            Controls.Add(generateButton);
            Controls.Add(descriptionField);
            Controls.Add(datapackNameField);
            Controls.Add(selectDestination);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Minecraft Datapack Creation Tool";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button selectDestination;
        private TextBox datapackNameField;
        private RichTextBox descriptionField;
        private Button generateButton;
        private TextBox packFormatField;
        private TextBox datapackTagField;
        private LinkLabel linkLabel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
    }
}
