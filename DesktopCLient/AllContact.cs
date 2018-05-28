using DesktopCLient.ServiceReference;
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
    public partial class AllContact : Form
    {
        //Set the controlbox false, because I dont want to somebody can exit with the X button.
        public AllContact()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        //When this window is loaded:
        //-I create a new MyServiceClient instance.
        //-Call the showContact method and the returned value I save it in a new Dictionary.
        //-Iterate over the Disctionary.
        //-In the iterate, I append each contact name and contact number to the ContactNames and ContactNumbers fields.
        private void AllContact_Load(object sender, EventArgs e)
        {
            MyServiceClient client = new MyServiceClient();
            string[] contacts = client.showContact();
            for(int i = 0; i < contacts.Length; i++)
            {
                ContactNames.Text += contacts.ElementAt(i) + "\n";
            }
        }
        //This is the OK button on the form.
        //When you clicked it, this window will hide, create a new Kisokos instance, and show it.
        private void okButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kisokos kisokos = new Kisokos();
            kisokos.Show();
        }
    }
}
