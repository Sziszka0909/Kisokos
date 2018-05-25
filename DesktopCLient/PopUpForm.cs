using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopCLient
{
    public partial class PopUpForm : Form
    {
        //This form show if you type invalid password or username or both.
        public PopUpForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //This is the OK button on the form.
        //If you clicked it, this window will hide.
        private void okButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
