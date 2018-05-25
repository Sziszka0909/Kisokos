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
    public partial class Form1 : Form
    {
        //Declare a static Username variable, because I want to use this value an another class, so this is a public field.
        public static string Username;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UsernameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordField_TextChanged(object sender, EventArgs e)
        {

        }

        //This is the Login button
        //Initialize a MyServiceClient, with this instance I can use the servers method's.
        //Create a new PopUpForm, maybe I will use this later.
        //From the UsernameField I read the value, and save this in the Username field.
        //Same with the PasswordField.
        //I call the Login method from server side, and save the returned value in a boolean field.
        //If this boolean is false I show a popUpForm and clear the UsernameField and PasswordField.
        //Else the login is successfully, hide this window, initialize a new Kisokos instance and show it.
        private void loginButton_Click(object sender, EventArgs e)
        {
            MyServiceClient client = new MyServiceClient();
            PopUpForm popUpForm = new PopUpForm();
            Username = UsernameField.Text;
            string Password = PasswordField.Text;
            bool Login = client.Login(Username, Password);
            if (Login == false)
            {
                popUpForm.Show();
                UsernameField.Text = "";
                PasswordField.Text = "";
            }
            else
            {
                this.Hide();
                Kisokos kisokos = new Kisokos();
                kisokos.Show();
            }
        }
    }
}
