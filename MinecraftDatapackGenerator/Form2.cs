using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftDatapackGenerator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Ensures that the window can't be resized
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void aboutScreenClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
