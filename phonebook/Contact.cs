using System;
namespace phonebook
{
    public class Contact
    {
        public string Name { get; set; }
        public string Number { get; set; }
        
        //Constructor to set the name and number of contact.
        public Contact(string name, string number)
        {
            Name = name;
            Number = number;
        }
    }
}

