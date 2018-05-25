using System;
using System.Collections.Generic;
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
        //This dictionary contains the contacts in the contactlist.
        Dictionary<string, string> contacts = new Dictionary<string, string>()
        {
            {"Lakatos Bendegúz", "06602343129" },
            {"Tolmács Tamás", "06961265876" },
            {"Belucci Black", "06902354123" }
        };

        //I try to add new contact to the contact list.
        //I lock the contacts dictionary, because I want to restricts code from being executed by more than one thread at the same time.
        //In error counter I examine the phonenumber contains letter or not.
        //I examine the contactlist contains the name that I want to be added or not.
        //If the phonenumber is valid and at least 9 character I add the contact to the contactlist.
        //Else return error message.
        //Catch the exception if it generated and return error message.
        public string addContact(string name, string phonenumber)
        {
            try
            {
                lock (contacts)
                {
                    int errorCounter = Regex.Matches(phonenumber, @"[a-zA-Z]").Count;
                    if (contacts.ContainsKey(name))
                    {
                        return "Contactlist already contains this name.";

                    }
                    else if (errorCounter == 0 && phonenumber.Length > 8)
                    {
                        contacts.Add(name, phonenumber);
                        return "Contact added to contactlist.";
                    }
                    else
                    {
                        return "Invalid phonenumber.";
                    }
                }
            } catch (Exception e)
            {
                return "Our servers are temporarily down. Please try again later.";
            }
        }

        //I try to add new contact to the contact list.
        //I lock the contacts dictionary, because I want to restricts code from being executed by more than one thread at the same time.
        //Examine the contactlist contains the contact or not.
        //If contains I delete the contact from the dictionary.
        //Else return error message.
        //Catch the exception if it generated and return error message.
        public string deleteContact(string username)
        {
            try
            {
                lock (contacts)
                {

                    if (contacts.ContainsKey(username))
                    {
                        contacts.Remove(username);
                        return "Contact deleted.";
                    }
                    else
                    {
                        return "Contactlist doesn't contains this contact.";
                    }
                }
            } catch (Exception e)
            {
                return "Our servers are temporarily down. Please try again later.";
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
                    ids.Add(username, Guid.NewGuid());
                    return true;
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

        //I lock the contacts dictionary, because I want to restricts code from being executed by more than one thread at the same time.
        //Return with the contactlist(Dictionary).
        public Dictionary<string, string> showContact()
        {
            lock (contacts)
            {
                return contacts;
            }
        }
    }
}
