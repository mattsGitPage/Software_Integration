using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callMyService
{
    class Program
    {
        //this program relies on the self hosting from the host console application
        // it implements the number guessing game in the homework as console application
        // again this whole solution must be ran in administator mode in order to work
        //!! RUN IN ADMIN MODE!!
        static void Main(string[] args)
        {
            //this creates our self hosting reference to call the functions
            ServiceReference1.ImyServiceClient client = new ServiceReference1.ImyServiceClient();

            //prompts the user for  lower bound for the secret number
            Console.WriteLine("please enter a lower bound for the secret number then press enter");
            string line = Console.ReadLine();
            int lower;

            //check to make sure the user entered in valid int prompt again until it is corrected
            while (!Int32.TryParse(line, out lower))
            {
                Console.WriteLine("not a valid int try again");
                line = Console.ReadLine();
            }
            
            //once entered store the int
            lower = Convert.ToInt32(line);
            
            //prompts for an upper bound for the secret number
            Console.WriteLine("please enter an upper bound for the secret number then press enter");
            string line1 = Console.ReadLine();
            int upper;

            //check to make sure valid int was enterd if not prompt until it is correct
           while (!Int32.TryParse(line1, out upper))
            {
                Console.WriteLine("not a valid int try again");
                line1 = Console.ReadLine();
            }

           // once valid int is recieved store it
            upper = Convert.ToInt32(line1);

            //computes the secret number via the self host function
            int secret = client.SecretNumber(lower, upper);

            //prompts the user for a guess
            Console.WriteLine("the secret number was generated via the self hosting client. Now please enter your guess ");

            string line2 = Console.ReadLine();
            int guess;

            //check to make sure valid int was enterd if not prompt until it is correct
            while (!Int32.TryParse(line2, out guess))
            {
                Console.WriteLine("not a valid int try again");
                line2 = Console.ReadLine();
            }

            //this gets the guess from the user once it is validated to be an int
             guess = Convert.ToInt32(line2);

            //this invokes the method via the self hosting service
            String check = client.checkNumber(guess, secret);


            // stay in the game while the guess is to big or to small
            while ((String.Compare(check, "too big") == 0) || (String.Compare(check, "too small") == 0))
            {

                //check if the entered guess is to high
                // if so ask user to enter a new guess then call the service to update
                //the guess and check it again
                if (String.Compare(check, "too big") == 0)
                {
                    Console.WriteLine("Your guess was too big, please enter a new number and try again ");

                    string line3 = Console.ReadLine();
                    int make;

                    //check to make sure valid int was enterd if not prompt until it is correct
                    while (!Int32.TryParse(line3, out make))
                    {
                        Console.WriteLine("not a valid int try again");
                        line3 = Console.ReadLine();
                    }

                    //once it is validated check the guess again
                    guess = Convert.ToInt32(line3);
                    check = client.checkNumber(guess, secret);
                }

                //check if the entered guess is to low
                // if so ask user to enter a new guess then call the service to update
                //the guess and check it again
                else if (String.Compare(check, "too small") == 0)
                {
                    Console.WriteLine("Your guess was too small, please enter a new number and try again ");

                    string line4 = Console.ReadLine();
                    int make;

                    //check to make sure valid int was enterd if not prompt until it is correct
                    while (!Int32.TryParse(line4, out make))
                    {
                        Console.WriteLine("not a valid int try again");
                        line4 = Console.ReadLine();
                    }
                    
                    //once it is validated check the guess again
                    guess = Convert.ToInt32(line4);
                    check = client.checkNumber(guess, secret);
                }

            }

            // the answer was neither to big or to small so it must be correct
            //tell the user the answer they entered was correct and close the app
            Console.WriteLine("the answer was corret! press enter to close");
            Console.ReadLine();

        }
    }
}
