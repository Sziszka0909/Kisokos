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
    public partial class Kisokos : Form
    {
        //Set the controlbox false, because I dont want to somebody can exit with the X button.
        public Kisokos()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void Kisokos_Load(object sender, EventArgs e)
        {

        }

        //This is the Add button.
        //I clear the message field every click.
        //Initialize a MyServiceClient.
        //Get the contactName and contactNumber from the addContactName field and addContactNumber field and saved it in 2 variable.
        //Message field will equals with the addContact method returned value.
        private void addContactButton_Click(object sender, EventArgs e)
        {
            message.Text = "";
            MyServiceClient client = new MyServiceClient();
            string contactName = addContactName.Text;
            string contactNumber = addContactNumber.Text;
            message.Text = client.addContact(contactName, contactNumber);
        }

        //This is the Delete button.
        //I clear the message field every click.
        //Initialize a MyServiceClient.
        //Get the deleteName from the deleteContact field and saved it in the variable.
        //Message field will equals with the deleteContact method returned value.
        private void deleteContactButton_Click(object sender, EventArgs e)
        {
            message.Text = "";
            MyServiceClient client = new MyServiceClient();
            string deleteName = deleteContact.Text;
            message.Text = client.deleteContact(deleteName);
        }

        //This is the Show all contact button.
        //Create a new allContact instance, hide this window, and show the allContact window.
        private void showAllContactButton_Click(object sender, EventArgs e)
        {
            AllContact allContact = new AllContact();
            this.Hide();
            allContact.Show();
        }

        //This is the Log Out button.
        //Initialize a MyServiceClient.
        //Call the LogOut method with the Form1 static variable.
        //Hide this window.
        //Create a new Form1 instance, and show it.
        private void logOutButton_Click(object sender, EventArgs e)
        {
            MyServiceClient client = new MyServiceClient();
            client.Logout(Form1.Username);
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
