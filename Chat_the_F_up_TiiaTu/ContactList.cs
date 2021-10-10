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
            new Person { Name = "Minna", LastName = "Nilsson", Age = 30, Alias = "minski", Email = "minna.nilsson@gmail.com", FavoriteFilmGenre = "Skräk" }
        };

        public static void CheckAction(int menuChoise) //metod för att läsa av 
        {
            if (menuChoise > 0 && menuChoise < 6)
            {
                switch (menuChoise)
                {
                    case 1:
                        AddPerson();
                        break;
                    case 2:
                        UpdatePerson();
                        break;
                    case 3:
                        DeletePerson();
                        break;
                    case 4:
                        Console.Clear();
                        HelperClass.SecondMenu();
                        ChooseSecondMenu();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Incorrect input!");
                Thread.Sleep(500);
                Console.Clear();
            }
        }

        private static void ChooseSecondMenu()
        {
            Console.Write("Enter number: ");
            int.TryParse(Console.ReadLine(), out int secondMenuChoise);

            switch (secondMenuChoise)
            {
                case 1: ShowList(); break;
                case 2: break;
                case 3: break;
                default:
                    break;
            }
            Console.Clear();
        }

        private static void ShowList()
        {
            foreach (Person item in nameList)
            {
                Console.WriteLine($"{item.Name} {item.LastName}\t| [{item.Alias}]\t| ({item.Age})\t| { item.Email}");
            }
            Console.ReadLine();
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

            Console.WriteLine("\nNew person added succesfully!");
            Thread.Sleep(500);
            Console.Clear();
        }

        public static void DeletePerson()
        {
            ShowList();
            Console.Write("\nEnter the alias of the person you want to delete: ");

            string givenAlias = Console.ReadLine();

            foreach (var item in nameList)
            {
                if (item.Alias == givenAlias)
                {
                    nameList.Remove(item);
                    Console.WriteLine("Person deleted succesfully!");
                    Thread.Sleep(1000);
                    Console.Clear();
                    return;
                }              
            } 
        }

        private static void UpdatePerson()
        {
            ShowList();
            Console.Write("\nEnter the alias of the person you want to update: ");

            string givenAlias = Console.ReadLine();

            foreach (var item in nameList)
            {
                if (item.Alias == givenAlias)
                {
                    Console.WriteLine(item.Name);
                    Console.Write("\nEnter new name: ");
                    string newName = Console.ReadLine();
                    item.Name = newName;
                    Console.WriteLine("Updated information");
                    Console.WriteLine($"{item.Name} {item.LastName}");
                    Console.ReadLine();
                    Thread.Sleep(1000);
                    Console.Clear();
                    return;
                }
            }
            //contactlist[index].firstname = console.readline()
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

