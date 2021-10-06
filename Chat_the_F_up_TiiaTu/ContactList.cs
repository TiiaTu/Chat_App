using System;
using System.Collections.Generic;

namespace Chat_the_F_up_TiiaTu
{
    class ContactList : Person
    {
        List<string> nameList = new List<string>
        {
            Person.
        }

        public static void Menu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("Choose the number that indicates the option");
            Console.WriteLine("1 - Show the list \n2 - Add a person to the list \n3 - Update the list \n4 - Delete a person from the list \n5 - Sort the list");
            Console.ReadKey();
            Console.WriteLine("You chose");
        }
        static void ChooseAction()
        {
            switch (true)
            {
                case "1":
                    Console.WriteLine("Show the list");
                    nameList
                default:
                    break;
            }
        }
    }
}
