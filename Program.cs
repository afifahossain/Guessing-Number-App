using System;


namespace Newter
{
   
    class Program
    {
        
        static void Main(string[] args)
        {
            GetAppInfo(); 

            GreetUser(); 

            while (true)
            {

               
                Random random = new Random();

               
                int correctNumber = random.Next(1, 10);

                
                int guess = 0;

               
                Console.WriteLine("Guess a number between 1 and 10");

               
                while (guess != correctNumber)
                {
                    
                    string input = Console.ReadLine();

                   
                    if (!int.TryParse(input, out guess))
                    {
                    
                        PrintColorMessage(ConsoleColor.Red, "Please use a valid number");

                       
                        continue;
                    }

                    
                    guess = Int32.Parse(input);

                    
                    if (guess != correctNumber)
                    {
                        
                        PrintColorMessage(ConsoleColor.Red, "Wrong,try again");
                    }
                }

                
                PrintColorMessage(ConsoleColor.Green, "CORRECT!");

                
                Console.WriteLine("Play Again? [Y or N]");

                
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") {
                    continue;
                }
                else if (answer == "N") {
                    return;
                }
                else
                {
                    return;
                }
            }           

        }

        
        static void GetAppInfo() {
           
            string appName = "Newter";
            string appVersion = "1.0.0";
            

            
            Console.ForegroundColor = ConsoleColor.Blue;

            // Write out app info
            Console.WriteLine("{0}: Version {1}", appName, appVersion);

            
            Console.ResetColor();
        }

        
        static void GreetUser() {
            
            Console.WriteLine("Enter your name");

           
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's start", inputName);
        }

        
        static void PrintColorMessage(ConsoleColor color, string message) {
        
            Console.ForegroundColor = color;

            
            Console.WriteLine(message);

         
            Console.ResetColor();
        }
    }
}
