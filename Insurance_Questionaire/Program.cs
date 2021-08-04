using System;

namespace Insurance_Questionaire
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start of survey
            //Age of applicant
            Console.WriteLine("Welcome to Standard Car Insurance\nPlease answer the following questions\nto see if you're eligable");
            Console.WriteLine("What is your name?\n");
            string Name = Console.ReadLine();
            
            Console.WriteLine("What is your age?\n");
            byte Age = Convert.ToByte(Console.ReadLine());
            
            //DUI Violations
            Console.WriteLine("Have you ever had a DUI violation\nPlease answer true or false");
            Boolean DUI = Convert.ToBoolean(Console.ReadLine());

            //Tickets
            Console.WriteLine("How many tickets have you had?\n");
            byte Tickets = Convert.ToByte(Console.ReadLine());

            //Displaying the results
            if(Age >= 15 && DUI == false && Tickets <= 3) 
            {
                Console.WriteLine($"Congratulations {Name}, you're able to get car insurance with us");
            }
            
            else if (Age <= 15 && DUI == false && Tickets <= 3)
            {
                Console.WriteLine($"Sorry {Name}, you're to young to be insured with us");
            }
            
            else if (Age >= 15 && DUI == true && Tickets <= 3)
            {
                Console.WriteLine($"We cannot cover you {Name}, due to you're previous DUI's");
            }
            
            else if (Age >= 15 && DUI == false && Tickets >= 4)
            {
                Console.WriteLine($"We cannot cover you {Name}, due to you're {Tickets} speeding violations");
            }
            
            else if (Age >= 15 && DUI == true && Tickets >= 4)
            {
                Console.WriteLine($"We cannot cover you {Name}, due to you're previous DUI's and {Tickets} tickets.");
            }
            
            else if (Age <= 14 && DUI == true && Tickets >= 4)

            {
                Console.WriteLine($"We cannot cover you {Name}, because you're too young and also due to you're previous DUI's and {Tickets} tickets.");
            }

            //End the programme
            Console.WriteLine("\n\n\nPress ENTER to leave");
            Console.Read();


        }
    }
}
