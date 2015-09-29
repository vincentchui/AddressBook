using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook3
{
    class AddressBookTester
    {
        static void Main(string[] args)
        {
            AddressBook ab = new AddressBook();

            ab.menu();
        }
    }
}
/*OUTPUT

add, delete, search or quit? add

What is the first name? Vincent

What is the last name? Chui

FIRST NAME: Vincent
LAST NAME: Chui
ID: 1001
HAS BEEN ADDED

add, delete, search or quit? add

What is the first name? v

What is the last name? c

FIRST NAME: v
LAST NAME: c
ID: 1002
HAS BEEN ADDED

add, delete, search or quit? search

search by first name, last name, id, or quit? Vincent

search by first name, last name, id, or quit? first name

What is the first name? Vincent

FIRST NAME: Vincent
LAST NAME: Chui
ID: 1001

search by first name, last name, id, or quit? last name

What is the last name? c

FIRST NAME: v
LAST NAME: c
ID: 1002

search by first name, last name, id, or quit? id

What is the id? 1001

FIRST NAME: Vincent
LAST NAME: Chui
ID: 1001

search by first name, last name, id, or quit? quit

GOODBYE

add, delete, search or quit? delete

delete by first name, last name, id, or quit? id

What is the id to delete? 1001

FIRST NAME: Vincent
LAST NAME: Chui
ID: 1001

Delete this person Y/N? y

DELETED

delete by first name, last name, id, or quit? quit

add, delete, search or quit? quit
*/
