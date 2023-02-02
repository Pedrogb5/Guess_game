namespace Guess.Classes;
using System;

public class Machine
{

    public static void NumberGuessed_Display(int number)
    {

        Console.WriteLine(@$"

 ---> {number}                       
            ");

    }


    public static void Machine_Guessing()
    {

        Console.Write("Machine tries to guess a number between 1 to 20");

        for (int contador = 0; contador < 4; contador++)
        {
            Thread.Sleep(600);
            Console.Write(".");
        }

        Random Random_Instance = new Random();

        string response;
        int x = 1;
        int y = 20;

        int Random_Number = Random_Instance.Next(x, y);
        do{

            NumberGuessed_Display(Random_Number);

            Console.Write($"enter 'YES' if the number guessed is correct , 'HIGHER' if your number is higher , 'LOWER' if your number is lower: ");
            response = Console.ReadLine().ToUpper();

            if (response == "HIGHER"){

                Console.Clear();
                x = Random_Number + 1;

                Random_Number = Random_Instance.Next(x , y);

            }

            else if (response == "LOWER") {

                Console.Clear();
                y = Random_Number - 1;

                Random_Number = Random_Instance.Next(x, y);
            }

            else if (response == "YES") {

                Console.Clear();
                Console.WriteLine("The Computer Guessed the Number!");
                
            }

            else {

                Console.Clear();
                Console.WriteLine("Your response was invalid");
            }

        } while (response != "YES");

        

    }
}
