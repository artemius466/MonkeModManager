using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace MonkeModManager
{
    public partial class Form1 : Form
    {
        new readonly FormMain Parent;

        public Form1(FormMain parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (radioButtonRussian.Checked)
            {
                Parent.russian = true;
            }
            this.Close();
        }

        private void radioButtonRussian_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRussian.Checked) buttonConfirm.Text = "Принять"; else buttonConfirm.Text = "Confirm"; // Yeah, cool feature, blablabla. Why am i thinking that russians SOOOOO STUPID!? BUT I'M RUSSIAN! AM I STUPID?? YES!!
        }
    }
}
