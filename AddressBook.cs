using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook3
{
    class AddressBook
    {
        private string fname;
        private string lname;
        private string id;

        public string fName
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }
        }

        public string lName
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }

        public string iD
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        static int ID = 1000;

        public void menu()
        {
            string choice;
            int position = 0;

            AddressBook[] ab = new AddressBook[10];

            for (int i = 0; i < ab.Length; i++)
            {
                ab[i] = new AddressBook();
                ab[i].fname = "";
                ab[i].lname = "";
                ab[i].id = "";
            }

            do
            {
                Console.Write("\nadd, delete, search or quit? ");
                choice = Console.ReadLine();

                choice = choice.ToLower();

                switch (choice)
                {
                    case "add":
                        ab[position] = add();
                        
                        Console.WriteLine("\nFIRST NAME: " + ab[position].fname +
                            "\nLAST NAME: " + ab[position].lname +
                            "\nID: " + ab[position].id +
                            "\nHAS BEEN ADDED");

                        position++;
                        break;
                    case "delete":
                        ab = delete(ab);
                        break;
                    case "search":
                        search(ab);
                        break;
                    default:
                        Console.WriteLine("\nINVALID OPTION");
                        break;
                }
            } while (choice != "quit");
        }

        public AddressBook add()
        {
            AddressBook ab = new AddressBook();

            Console.Write("\nWhat is the first name? ");
            ab.fname = Console.ReadLine();

            Console.Write("\nWhat is the last name? ");
            ab.lname = Console.ReadLine();

            ID++;

            ab.id = Convert.ToString(ID);
            return ab;
        }

        public AddressBook[] delete(AddressBook[] ab)
        {
            string choice;
            string choice2;
            string fname;
            string lname;
            string id;
            int deletePlace;

            Console.Write("\ndelete by first name, last name, id, or quit? ");
            choice = Console.ReadLine();

            choice = choice.ToLower();

            do
            {
                switch (choice)
                {
                    case "first name":
                        Console.Write("\nWhat is the first name to delete? ");
                        fname = Console.ReadLine();

                        for(int i = 0; i < ab.Length; i++)
                        {
                            if (fname == ab[i].fname)
                            {
                                Console.WriteLine("\nFIRST NAME: " + ab[i].fname +
                                    "\nLAST NAME: " + ab[i].lname +
                                    "\nID: " + ab[i].id);

                                deletePlace = i;


                                Console.Write("\nDelete this person Y/N? ");
                                choice2 = Console.ReadLine();

                                choice2 = choice2.ToUpper();

                                if (choice2 == "Y")
                                {
                                    ab[deletePlace].fname = "";
                                    ab[deletePlace].lname = "";
                                    ab[deletePlace].id = "";
                                    choice = null;
                                    Console.WriteLine("\nDELETED");
                                    delete(ab);
                                    break;     
                                } else
                                {
                                    Console.WriteLine("\nGOODBYE");
                                    break;
                                }
                            }
                        }
                        break;
                    case "last name":
                        Console.Write("\nWhat is the last name to delete? ");
                        lname = Console.ReadLine();

                        for (int i = 0; i < ab.Length; i++)
                        {
                            if (lname == ab[i].lname)
                            {
                                Console.WriteLine("\nFIRST NAME: " + ab[i].fname +
                                    "\nLAST NAME: " + ab[i].lname +
                                    "\nID: " + ab[i].id);

                                deletePlace = i;


                                Console.Write("\nDelete this person Y/N? ");
                                choice2 = Console.ReadLine();

                                choice2 = choice2.ToUpper();

                                if (choice2 == "Y")
                                {
                                    ab[deletePlace].fname = "";
                                    ab[deletePlace].lname = "";
                                    ab[deletePlace].id = "";
                                }
                                else
                                {
                                    Console.WriteLine("\nGOODBYE");
                                    break;
                                }
                            }
                        }
                        break;
                    case "id":
                        Console.Write("\nWhat is the id to delete? ");
                        id = Console.ReadLine();

                        for (int i = 0; i < ab.Length; i++)
                        {
                            if (id == ab[i].id)
                            {
                                Console.WriteLine("\nFIRST NAME: " + ab[i].fname +
                                    "\nLAST NAME: " + ab[i].lname +
                                    "\nID: " + ab[i].id);

                                deletePlace = i;


                                Console.Write("\nDelete this person Y/N? ");
                                choice2 = Console.ReadLine();

                                choice2 = choice2.ToUpper();

                                if (choice2 == "Y")
                                {
                                    ab[deletePlace].fname = "";
                                    ab[deletePlace].lname = "";
                                    ab[deletePlace].id = "";
                                }
                                else
                                {
                                    Console.WriteLine("\nGOODBYE");
                                    break;
                                }
                            }
                        }
                        break;
                    case "quit":
                        Console.WriteLine("\nGOODBYE");
                        break;
                    default:
                        Console.WriteLine("\nINVALID OPTION");
                        break;
                }
            } while (choice != "quit");
            return ab;
        }

        void search(AddressBook[] ab)
        {
            string choice;
            string fname;
            string lname;
            string id;

            do
            {
                Console.Write("\nsearch by first name, last name, id, or quit? ");
                choice = Console.ReadLine();

                choice = choice.ToLower();

                switch (choice)
                {
                    case "first name":
                        Console.Write("\nWhat is the first name? ");
                        fname = Console.ReadLine();

                        for (int i = 0; i < ab.Length; i++)
                        {
                            if (fname == ab[i].fname)
                            {
                                Console.WriteLine("\nFIRST NAME: " + ab[i].fname +
                                    "\nLAST NAME: " + ab[i].lname +
                                    "\nID: " + ab[i].id);
                            }
                        }
                        break;
                    case "last name":
                        Console.Write("\nWhat is the last name? ");
                        lname = Console.ReadLine();

                        for (int i = 0; i < ab.Length; i++)
                        {
                            if (lname == ab[i].lname)
                            {
                                Console.WriteLine("\nFIRST NAME: " + ab[i].fname +
                                    "\nLAST NAME: " + ab[i].lname +
                                    "\nID: " + ab[i].id);
                            }
                        }
                        break;
                    case "id":
                        Console.Write("\nWhat is the id? ");
                        id = Console.ReadLine();

                        for (int i = 0; i < ab.Length; i++)
                        {
                            if (id == ab[i].id)
                            {
                                Console.WriteLine("\nFIRST NAME: " + ab[i].fname +
                                    "\nLAST NAME: " + ab[i].lname +
                                    "\nID: " + ab[i].id);
                            }
                        }
                        break;
                    case "quit":
                        Console.WriteLine("\nGOODBYE");
                        break;
                }
            } while (choice != "quit");
        }
    }
}
