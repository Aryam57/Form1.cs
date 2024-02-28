using System;
using System.Windows.Forms;

namespace SimpleCSharpApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("مرحبًا بك في تطبيق C# البسيط!");
        }
    }
}
