using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;

namespace ThirdWcfService
{
    //I want to use only one contactlist for all request, so I set InstanceContextMode to Single.
    [ServiceBehaviorAttribute(InstanceContextMode = InstanceContextMode.Single)]
    public class MyService : IMyService
    {
        //This dictionary contains the logged in users.
        Dictionary<string, Guid> ids = new Dictionary<string, Guid>();
        //This dictionary contains the registered users.
        Dictionary<string, string> users = new Dictionary<string, string>()
        {
            {"Jim", "Jimpass" },
            {"John", "Johnpass" }
        };
        //This list contains the contacts in the contactlist.
        List<string> contacts = new List<string>();

        //Concatenate the name and the phonenumber to one variable with an "-" character.
        //Check the contactList.txt is exists or not.
        //If exist lock the contacts list and read all lines from that txt file and saved it to that list.
        //Check the phonenumber is valid or not.
        //If contacts contains the contact that I want to add that list, I return an error message.
        //Else if the phonenumber is valid I append that contact to the txt file.
        //Else I return error message.
        //If txt file not exists, I check the phonenumber is valid or not.
        //If the phonenumber is ok, I create a txt file, and append the contact to it.
        //Else I return error message.
        public string addContact(string name, string phonenumber)
        {
            string addContact = name + "-" + phonenumber;

            if (File.Exists("contactList.txt"))
            {
                lock (contacts)
                {
                    contacts = File.ReadAllLines("contactList.txt").ToList();
                    int errorCounter = Regex.Matches(phonenumber, @"[a-zA-Z]").Count;
                    if (contacts.Contains(addContact))
                    {
                        return "Contactlist already contains this name.";

                    }
                    else if (errorCounter == 0 && phonenumber.Length > 8)
                    {
                        using (StreamWriter sw = File.AppendText("contactList.txt"))
                        {
                            sw.WriteLine(addContact);
                        }
                        return "Contact added to contactlist.";
                    }
                    else
                    {
                        return "Invalid phonenumber.";
                    }
                }
            } else
            {
                int errorCounter = Regex.Matches(phonenumber, @"[a-zA-Z]").Count;
                if (errorCounter == 0 && phonenumber.Length > 8)
                {
                    using (StreamWriter sw = File.AppendText("contactList.txt"))
                    {
                        sw.WriteLine(addContact);
                    }
                    return "Contact added to contactlist.";
                }
                else
                {
                    return "Invalid phonenumber.";
                }
            }
        }

        //Concatenae the name and the phonenumber to one variable with an "-" character.
        //Lock the contacts.
        //Try to read all lines to contacts list.
        //If contacts not contains the contact that I want to delete, I return with a nerror message.
        //Else I delete the whole file, than I create it again and append all contact to it, except the number that I want to delete.
        //Return a message.
        //Catch FileNotFoundException is File is not exists and return error message.
        public string deleteContact(string username, string phonenumber)
        {
            string deleteContact = username + "-" + phonenumber;
            lock (contacts)
            {
                try
                {
                    contacts = File.ReadAllLines("contactList.txt").ToList();
                    if (!contacts.Contains(deleteContact))
                    {
                        return "Contactlist doesn't contains this contact.";
                    }
                    else
                    {
                        File.Delete("contactList.txt");
                        foreach (var contact in contacts)
                        {
                            if (!contact.Equals(deleteContact))
                            {
                                using (StreamWriter sw = File.AppendText("contactList.txt"))
                                {
                                    sw.WriteLine(contact);
                                }
                            }
                        }
                        return "Contact deleted";
                    }
                }
                catch (FileNotFoundException)
                {
                    return "Contactlist doesn't contains this contact.";
                }
            }
        }

        //I check that the user is in the registered users or not.
        //After then I check the given user's password is right or not.
        //If everything is ok, I add the user to the logged in users dictionary and return true.
        //Else return true.
        public bool Login(string username, string password)
        {
            if (users.ContainsKey(username))
            {
                string pass = users[username];
                if (pass.Equals(password))
                {
                    try
                    {
                    ids.Add(username, Guid.NewGuid());
                    return true;
                    } catch (ArgumentException)
                    {
                        return false;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        //Remove the user from the logged in users dictionary.
        public void Logout(string username)
        {
            ids.Remove(username);
        }

        //I lock the contacts list, because I want to restricts code from being executed by more than one thread at the same time.
        //Try to return a contacts list.
        //Catch if it not exist, and return an empty list.
        public List<string> showContact()
        {
            lock (contacts)
            {
                try
                {
                    contacts = File.ReadAllLines("contactList.txt").ToList();
                    return contacts;
                }
                catch (FileNotFoundException)
                {
                    return new List<string>();
                }
            }
        }
    }
}
