using System;
using System.Collections.Generic;

namespace Chat_the_F_up_TiiaTu
{
    class ContactList
    {
        public static List<Person> nameList = new()
        {
            new Person { Name = "Kalle Berg", Age = 23, Alias = "Kllbrg", Email = "kalle.berg@gmail.com", FavoriteActor = "Angelina Jolie", FavoriteAnimal = "Horse" },
            new Person { Name = "Minna Nilsson", Age = 30, Alias = "Minski", FavoriteFilmGenre = "Skräk" }
        };
        
        

        public static void Menu()
        {
            Console.WriteLine(" _______________________________________");
            Console.WriteLine("|               MENU                    |");
            Console.WriteLine("|---------------------------------------|");
            Console.WriteLine("| [ 1 ] - Show the list                 |");
            Console.WriteLine("| [ 2 ] - Add a person to the list      |");
            Console.WriteLine("| [ 3 ] - Update the list               |");
            Console.WriteLine("| [ 4 ] - Delete a person from the list |");
            Console.WriteLine("| [ 5 ] - Sort the list                 |");
            Console.WriteLine("| [ 6 ] - Exit                          |");
            Console.WriteLine("|_______________________________________|");
            Console.Write("\nSelect an option: ");
            ChooseAction();
        }

        public static void ChooseAction()
        {
            while (true)
            {
                string menuChoise = Console.ReadLine();
                if (menuChoise is "1")
                {
                    ShowList();
                }
                ReturnToMenu();

                if (menuChoise is "2")
                {

                }
                if (menuChoise is "3")
                {

                }
                if(menuChoise is "4")
                {

                }
                if (menuChoise is "5")
                {

                }
                else
                {
                    break;
                }
            }
            //else if (input is "2")
            //{
            //    AddPerson();
            //}

            //switch (Console.ReadLine())
            //{
            //    case "1":
            //        ShowList();
            //        break;
            //    //case "2":
            //    //    this.AddPerson();
            //    //    break;
            //    case "3":
            //        UpdateList();
            //        break;
            //    case "4":
            //        DeletePerson();
            //        break;
            //    case "5":
            //        SortList();
            //        break;
            //    default:
            //        return;
        }

        private static void ShowList()
        {
            foreach (Person item in nameList)
            {
                Console.WriteLine(item.Name+ " "+ item.Age+" "+item.Alias+" "+item.Email+" "+item.FavoriteActor+" "+item.FavoriteFilmGenre);
                Console.WriteLine();
            }
        }

        public void AddPerson(Person personAdd)
        {
            nameList.Add(personAdd);
            Console.ReadLine();
        }
        static string ReturnToMenu()
        {
            Console.Write("Press any key to return to MENU ");
            string input = Console.ReadLine();
            return input;
            

        }
    }
}

