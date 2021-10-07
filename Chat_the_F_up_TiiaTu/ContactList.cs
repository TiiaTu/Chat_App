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
            Console.WriteLine("MENU");
            Console.WriteLine("[ 1 ]- Show the list \n[ 2 ] - Add a person to the list \n[ 3 ] - Update the list \n[ 4 ] - Delete a person from the list \n[ 5 ] - Sort the list");
            Console.Write("\nSelect an option: ");
            ChooseAction();
        }

        public static void ChooseAction()
        {
            string input = Console.ReadLine();
            if (input is "1")
            {
                ShowList();
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
            foreach (var item in nameList)
            {
                Console.WriteLine();
            }
        }

        public void AddPerson(Person personAdd)
        {
            nameList.Add(personAdd);
            Console.ReadLine();
        }
    }
}

