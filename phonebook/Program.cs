using phonebook;
using PhonebookConsoleApp;
using static phonebook.Contact;


Console.WriteLine(" Welcome to my PhoneBook Console Application. ");
Console.WriteLine("______________________________________________");
Console.WriteLine("Choose an option:");
Console.WriteLine("\t\t1 : Add contact.");
Console.WriteLine("\t\t2 : Search for contact by number.");
Console.WriteLine("\t\t3 : Display all contacts.");
Console.WriteLine("\t\t4 : Search for contact by name.");
Console.WriteLine("\t\tx : Exit Application.");

var option = Console.ReadLine();

var phoneBook = new PhoneBook();

while (true)
{
    switch (option)
    {
        case "1":
            Console.WriteLine("Add contact name:");
            var name = Console.ReadLine();
            Console.WriteLine("Add contact number:");
            var number = Console.ReadLine();

            var newContact = new Contact(name, number);
            phoneBook.AddContact(newContact);

            break;

        case "2":
            Console.WriteLine("Search for contact by number:");
            var searchNumber = Console.ReadLine();
            phoneBook.DisplayContact(searchNumber);

            break;

        case "3":
            phoneBook.DisplayAllContacts();
            break;

        case "4":
            Console.WriteLine("Search for contact by name:");
            var searchPhrase = Console.ReadLine();

            phoneBook.DisplayMatchingContacts(searchPhrase);
            break;

        case "x":
            return;

        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Select a valid option.");
            break;
    }
    Console.ResetColor();
    Console.WriteLine("Choose an option:");
    option = Console.ReadLine();
}