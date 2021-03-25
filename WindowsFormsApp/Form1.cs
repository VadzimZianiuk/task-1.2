using Library;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSayHello_Click(object sender, EventArgs e)
        {
            string name = this.textBoxName.Text;
            MessageBox.Show(string.IsNullOrEmpty(name)
                ? $"Please, enter your name at first."
                : HelloGenerator.GetHello(name));
        }
    }
}
