using System;
using phonebook;

namespace PhonebookConsoleApp
{
    public class PhoneBook
    {
        // METHODS
        //The entire list of contacts.
        private List<Contact> _contacts { get; set; } = new List<Contact>();
        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact: \t{contact.Name} - {contact.Number}");
        }
        private void DisplayContactDetails(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }


        //To add contacts to the contact list.
        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }

        //To display the contact by number.
        public void DisplayContact(string number)
        {
            var contact = _contacts.FirstOrDefault(c => c.Number == number); 
            if (contact == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Contact not found.");
            }
            else
            {
                Console.ResetColor();
                DisplayContactDetails(contact);
            }
        }
        //Display all contact methods.
        public void DisplayAllContacts()
        {
            DisplayContactDetails(_contacts);
        }

        //search for a contact for a given name
        public void DisplayMatchingContacts(string searchPhrase)
        {
            var matchingContacts = _contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
            DisplayContactDetails(matchingContacts);
        }
    }
}

