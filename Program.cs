﻿using System;

namespace Coinflip
{
    class Program
    {
        static void Main(string[] args)
        {
            int coin;
            string userGuess;
            Random rng = new Random();

            //Querry the user
            Console.Write("Enter your guess Heads or Tales (H or T)");
            userGuess = Console.ReadLine();

            //Get a random number for the coin flip
            coin = rng.Next(0, 2);

            if(coin == 0  && userGuess == "T"){
                Console.WriteLine("The coin flip was tails, you win.");
            }
            else if (coin == 1 && userGuess == "H"){
                Console.WriteLine("The coin flip was Heads, you win!");
            }
            else {
                if( coin == 0){
               Console.WriteLine("The coin flip was tails, ou lose!");
            } 
            else
            {
                 Console.WriteLine("The coin flip was Heads, you lose!");

                
            }
        }
    }
}
}
