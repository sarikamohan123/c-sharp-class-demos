using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contact_list
{

    class Contact 
    {
        private string FirstName { get; set; }
        private string LastName {  get; set; }
        private string Email {  get; set; }
        private string Phone {  get; set; }

        // Constructor
        public Contact(string firstName, string lastName, string email, string phone)
        { 
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;

        }

        //Method to display contact information
        public string displaycontact()
        { 
            return $"---------------------------------------------------\n"+
                   $"------------------- Current Contact-----------------\n"+
                   $"----------------------------------------------------\n"+
                   $"Name:         {FirstName} {LastName}\nEmail ;   {Email}\nPhone: {Phone}";


        }
    }
        
    
}
