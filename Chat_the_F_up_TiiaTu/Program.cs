using System;

namespace Chat_the_F_up_TiiaTu
{
    class Program : Person
    {
        static void Main()
        {

            ContactList.Menu();
            ContactList contacts = new ContactList();

          

        }
        static string ReadInput(string input)
        {
            input = Console.ReadLine();          
            return input;
        }
    }
}
