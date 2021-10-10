using System;
using System.Threading;
using System.Collections.Generic;

namespace Chat_the_F_up_TiiaTu
{
    class ContactList
    {
        public static List<Person> nameList = new()
        {
            new Person { Name = "Kalle", LastName = "Berg", Age = 23, Alias = "kllbrg", Email = "kalle.berg@gmail.com", FavoriteActor = "Angelina Jolie", FavoriteAnimal = "Horse" },
            new Person { Name = "Minna", LastName = "Nilsson", Age = 30, Alias = "minski", Email= "minna.nilsson@gmail.com", FavoriteFilmGenre = "Skräk" }
        };
      
       

        public static void ChooseAction()
        {           
            int.TryParse(Console.ReadLine(), out int menuChoise);
 
            if(menuChoise>0 && menuChoise<7)
            {
                switch (menuChoise)
                {
                    case 1: AddPerson(); break;
                    case 2: UpdatePerson(); break;
                    case 3: DeletePerson(); break; 
                    case 4: ShowList(); break;

                    default:
                        Environment.Exit(0); break;
                }
            }
            else
            {
                Console.WriteLine("Incorrect input!");
                Thread.Sleep(500);
                Console.Clear();
            }
        }

        

        private static void DeletePerson()
        {
            ShowList();
            Console.Write("\nEnter the alias of the person you want to delete: ");

            Person deletePerson = new(); //skapa en ny instans av Person

            string givenAlias = Console.ReadLine();
            
            nameList.RemoveAll(x => x.Alias == Console.ReadLine());

            if (givenAlias == deletePerson.Alias)
            {
                nameList.Remove(deletePerson);
            }
            ShowList();

            //do
            //{


            //} 
            //ShowList();

            //if (nameList.Contains(deletePerson))
            //{
                
            //}

            //-------------------------------------------------------------
            //Person deletePerson = new();            
            //deletePerson.Alias = Console.ReadLine().ToLower();
            //
            //ShowList();
            //---------------------------------------------------------------

            //    foreach (var delete in nameList)
            //    {
            //        string removePerson = Console.ReadLine().ToLower();
            //        if (delete.Alias is removePerson) 
            //            nameList.Remove(delete);
            //    }
        }

        private static void UpdatePerson()
        {
            ShowList();
            Console.Write("Enter the alias of the person you want to update: ");
        }

        private static void ShowList()
        {
            foreach (Person item in nameList)
            {
                Console.WriteLine($"{item.Name} {item.LastName}\t| [{item.Alias}]\t| ({item.Age})\t| { item.Email}");               
            }
        }

        public static void AddPerson()
        {
            Person newPerson = new();
            nameList.Add(newPerson);
            
            Console.Write("Name: ");
            newPerson.Name = Console.ReadLine();

            Console.Write("Last name: ");
            newPerson.LastName = Console.ReadLine();

            Console.Write("Alias: ");
            newPerson.Alias = Console.ReadLine().ToLower();
            
            Console.Write("Age: ");
            int.TryParse(Console.ReadLine(), out int age);
            newPerson.Age = age;

            Console.Write("Email: ");
            newPerson.Email = Console.ReadLine();

            //Console.Write("LinkedIn: ");
            //newPerson.LinkedIn = Console.ReadLine();
            //newPerson.Facebook = Console.ReadLine();
            //newPerson.Instagram = Console.ReadLine();
            //newPerson.Twitter = Console.ReadLine();
            //newPerson.GitHub = Console.ReadLine();
            //newPerson.FavoriteFood = Console.ReadLine();
            //newPerson.YuckyFood = Console.ReadLine();
            //newPerson.FavoriteAnimal = Console.ReadLine();
            //newPerson.FavoriteFilmGenre = Console.ReadLine();
            //newPerson.FavoriteActor = Console.ReadLine();     
        }

        
        static string ReturnToMenu()
        {
            Console.WriteLine();
            Console.Write("Press any key to return to MENU ");
            string input = Console.ReadLine();
            return input;
        }
    }
}

