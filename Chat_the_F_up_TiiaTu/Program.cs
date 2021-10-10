using System;

namespace Chat_the_F_up_TiiaTu
{
    
    class Program
    {
        static void Main()
        {
            while (true)
            {
                HelperClass.Menu();
                Console.Write("Ange siffra: ");
                int.TryParse(Console.ReadLine(), out int menuChoise);

                switch (menuChoise)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        // Or  System.Environment.Exit(0);
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
        }

        private static void ChooseSecondMenu()
        {
            Console.Write("Ange siffra: ");
            int.TryParse(Console.ReadLine(), out int secondMenuChoise);

            switch (secondMenuChoise)
            {
                case 1: break;
                case 2: break;
                case 3: break;
                default:
                    Console.Clear();
                    break;
            }
        }

        
    }




}

      
}
