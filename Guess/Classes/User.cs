namespace Guess.Classes
{
    public class User
    {
        public static void User_Guessing() {

            Random Random_Instance = new Random();
            int Correct_Number = Random_Instance.Next(1, 20);

            Console.Write("Guess the number that is between 1 and 20: ");
            int answer = int.Parse(Console.ReadLine());
           
            do
            {
                

                if (answer < Correct_Number) {

                    Console.Clear();
                    Console.Write("The correct number is higher...Try again: ");
                    answer = int.Parse(Console.ReadLine());
                }

                else if (answer > Correct_Number) {

                    Console.Clear();
                    Console.Write("The correct number is lower...Try again: ");
                    answer = int.Parse(Console.ReadLine());
                }

            } while (answer != Correct_Number );

            Console.WriteLine("You guessed the number!");

            
            
            

            
        }
    }
}