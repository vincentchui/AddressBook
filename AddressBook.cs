using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook2
{
    class AddressBook
    {
        public class Person
        {
            public string firstName
            {
                get
                {
                    return firstName;
                }
                set
                {
                    firstName = value;
                }
            }

            public string lastName
            {
                get
                {
                    return lastName;
                }
                set
                {
                    lastName = value;
                }
            }

            public int uID
            {
                get
                {
                    return uID;
                }
                set
                {
                    uID = value;
                }
            }
        }

        private int size = 10;
        private int index = 0;

        public Person[] addPerson(Person[] p)
        {
            Console.Write("\nWhat is the first name? ");
            p[index].firstName = Console.ReadLine();

            Console.Write("\nWhat is the last name? ");
            p[index].lastName = Console.ReadLine();

            index++;

            return p;
        }

        public Person[] delPerson(Person[] p)
        {
            int index;
            char option;

            do
            {
                Console.Write("\nWhich index do want to delete");
                index = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nFirst Name: " + p[index].firstName +
                    "\nLast Name: " + p[index].lastName +
                    "\nID: " + p[index].uID +
                    "\nDo you want to delete this person? (y/n): ");
                option = Convert.ToChar(Console.ReadLine());
            } while (option != 'y');


            p[index].firstName = "";
            p[index].lastName = "";
            p[index].uID = 0;

            return p;
        }

        public void searchPerson(Person[] p)
        {
            int x;

            Console.Write("\nChoose search method" +
                "\n1. First Name" +
                "\n2. Last Name" +
                "\n3. ID" +
                "\n4. Quit");

            x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("\nSearching by first name");
                    break;
                case 2:
                    Console.WriteLine("\nSearching by last name");
                    break;
                case 3:
                    Console.WriteLine("\nSearching by ID");
                    break;
                case 4:
                    menu();
                    break;
                default:
                    Console.WriteLine("\nInvalid choice");
                    break;
            }
        }

        public void searchByFN(Person[] p, int size)
        {
            string firstName = "";

            Console.Write("\nEnter the first name: ");
            firstName = Console.ReadLine();

            for (int i = 0; i < size; i++)
            {
                if (p[i].firstName == firstName)
                {
                    Console.WriteLine("\nName: " + p[i].firstName +
                        " " + p[i].lastName +
                        "\nID: " + p[i].uID);
                }
            }

        }

        public void searchByLN(Person[] p, int size)
        {
            string lastName = "";

            Console.Write("\nEnter the last name: ");
            lastName = Console.ReadLine();

            for (int i = 0; i < size; i++)
            {
                if (p[i].lastName == lastName)
                {
                    Console.WriteLine("\nName: " + p[i].firstName +
                        " " + p[i].lastName +
                        "\nID: " + p[i].uID);
                }
            }
        }

        public void searchByID(Person[] p, int size)
        {
            int id;

            Console.Write("\nWhat is the ID? ");
            id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                if (p[i].uID == id)
                {
                    Console.WriteLine("\nNAME: " + p[i].firstName +
                        " " + p[i].lastName +
                        "\nID: " + p[i].uID);
                }
            }
        }

        public void menu()
        {
            int x = 0;

            Person[] p = new Person[10];

            do
            {
                Console.Write("\n1.Add Person" +
                    "\n2. Delete Person" +
                    "\n3. Search Person" +
                    "\n4. Quit" +
                    "\nChoose a method: ");
                switch (x)
                {
                    case 1:
                        addPerson(p);
                        break;
                    case 2:
                        delPerson(p);
                        break;
                    case 3:
                        searchPerson(p);
                        break;
                    case 4:
                        Console.WriteLine("\nGoodbye");
                        break;
                    default:
                        break;
                }
            } while (x != 4);
        }

        public Person[] initArray(Person[] p, int size)
        {
            for (int i = 0; i < size; i++)
            {
                p[i].firstName = "";
                p[i].lastName = "";
                p[i].uID = 0;
            }
            return p;
        }
    }
}
