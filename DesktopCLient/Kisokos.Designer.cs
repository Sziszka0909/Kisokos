namespace DesktopCLient
{
    partial class Kisokos
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
            this.addContactButton = new System.Windows.Forms.Button();
            this.deleteContactButton = new System.Windows.Forms.Button();
            this.showAllContactButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.addContactName = new System.Windows.Forms.TextBox();
            this.addContactNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteContact = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addContactButton
            // 
            this.addContactButton.Location = new System.Drawing.Point(474, 30);
            this.addContactButton.Name = "addContactButton";
            this.addContactButton.Size = new System.Drawing.Size(101, 20);
            this.addContactButton.TabIndex = 0;
            this.addContactButton.Text = "Add contact";
            this.addContactButton.UseVisualStyleBackColor = true;
            this.addContactButton.Click += new System.EventHandler(this.addContactButton_Click);
            // 
            // deleteContactButton
            // 
            this.deleteContactButton.Location = new System.Drawing.Point(474, 71);
            this.deleteContactButton.Name = "deleteContactButton";
            this.deleteContactButton.Size = new System.Drawing.Size(101, 20);
            this.deleteContactButton.TabIndex = 1;
            this.deleteContactButton.Text = "Delete contact";
            this.deleteContactButton.UseVisualStyleBackColor = true;
            this.deleteContactButton.Click += new System.EventHandler(this.deleteContactButton_Click);
            // 
            // showAllContactButton
            // 
            this.showAllContactButton.Location = new System.Drawing.Point(473, 115);
            this.showAllContactButton.Name = "showAllContactButton";
            this.showAllContactButton.Size = new System.Drawing.Size(102, 20);
            this.showAllContactButton.TabIndex = 2;
            this.showAllContactButton.Text = "Show all contact";
            this.showAllContactButton.UseVisualStyleBackColor = true;
            this.showAllContactButton.Click += new System.EventHandler(this.showAllContactButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.Red;
            this.logOutButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logOutButton.Location = new System.Drawing.Point(66, 111);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(125, 29);
            this.logOutButton.TabIndex = 3;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(41, 176);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 13);
            this.message.TabIndex = 4;
            // 
            // addContactName
            // 
            this.addContactName.Location = new System.Drawing.Point(105, 30);
            this.addContactName.MaxLength = 20;
            this.addContactName.Name = "addContactName";
            this.addContactName.Size = new System.Drawing.Size(100, 20);
            this.addContactName.TabIndex = 5;
            // 
            // addContactNumber
            // 
            this.addContactNumber.Location = new System.Drawing.Point(327, 30);
            this.addContactNumber.MaxLength = 15;
            this.addContactNumber.Name = "addContactNumber";
            this.addContactNumber.Size = new System.Drawing.Size(100, 20);
            this.addContactNumber.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Contact name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contact number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Contact name";
            // 
            // deleteContact
            // 
            this.deleteContact.Location = new System.Drawing.Point(327, 71);
            this.deleteContact.Name = "deleteContact";
            this.deleteContact.Size = new System.Drawing.Size(100, 20);
            this.deleteContact.TabIndex = 10;
            // 
            // Kisokos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 218);
            this.Controls.Add(this.deleteContact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addContactNumber);
            this.Controls.Add(this.addContactName);
            this.Controls.Add(this.message);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.showAllContactButton);
            this.Controls.Add(this.deleteContactButton);
            this.Controls.Add(this.addContactButton);
            this.Name = "Kisokos";
            this.Text = "Kisokos";
            this.Load += new System.EventHandler(this.Kisokos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addContactButton;
        private System.Windows.Forms.Button deleteContactButton;
        private System.Windows.Forms.Button showAllContactButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.TextBox addContactName;
        private System.Windows.Forms.TextBox addContactNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox deleteContact;
    }
}