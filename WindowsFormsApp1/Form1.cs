using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string content = "MR Akkarawat";
            string title = "Say my name";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(content, title, buttons);

            if (result == DialogResult.Yes)
            {
                //ถ้าตอบใช้จะเกิดอะไรขึ้น
                MessageBox.Show("ขอบคุณ", title, MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("ขออภัยนะครับ", title, MessageBoxButtons.OK);
            }
        }
    }
}
