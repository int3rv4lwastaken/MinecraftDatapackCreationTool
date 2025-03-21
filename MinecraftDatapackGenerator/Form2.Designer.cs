namespace MinecraftDatapackGenerator
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            aboutScreenClose = new Button();
            strawpageSite = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // aboutScreenClose
            // 
            aboutScreenClose.Location = new Point(402, 167);
            aboutScreenClose.Name = "aboutScreenClose";
            aboutScreenClose.Size = new Size(75, 23);
            aboutScreenClose.TabIndex = 0;
            aboutScreenClose.Text = "Close";
            aboutScreenClose.UseVisualStyleBackColor = true;
            aboutScreenClose.Click += aboutScreenClose_Click;
            // 
            // strawpageSite
            // 
            strawpageSite.Location = new Point(231, 167);
            strawpageSite.Name = "strawpageSite";
            strawpageSite.Size = new Size(165, 23);
            strawpageSite.TabIndex = 1;
            strawpageSite.Text = "Open Strawpage Website";
            strawpageSite.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(124, 167);
            button1.Name = "button1";
            button1.Size = new Size(101, 23);
            button1.TabIndex = 2;
            button1.Text = "Report a Bug";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(465, 56);
            label1.TabIndex = 3;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(465, 36);
            label2.TabIndex = 4;
            label2.Text = "The project is open source, meaning anyone is allowed to take the source code for the project and use it to their needs.";
            // 
            // label3
            // 
            label3.Location = new Point(12, 111);
            label3.Name = "label3";
            label3.Size = new Size(465, 40);
            label3.TabIndex = 5;
            label3.Text = "Since this is my first ever software I have made and published, bugs are likely to occur. You can report bugs through this project's GitHub repository below!";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 202);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(strawpageSite);
            Controls.Add(aboutScreenClose);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            Text = "Datapack Creation Tool - About";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button aboutScreenClose;
        private Button strawpageSite;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}