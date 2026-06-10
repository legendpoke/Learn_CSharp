using System;
using System.Collections.Generic;
using System.Text;

class Guess {

    private int score = 0;
    private int score_one = 0;
    private int score_two = 0;
    private int score_three = 0;

    public void Objective() {
        Random random = new Random(); //it generates different number becaue it is outside the loop 
        while (true) {
            int player_one = random.Next(0, 101); // random number 0–100
            Console.WriteLine("Player_one Guess number is : " + player_one);
            int player_two = random.Next(0, 101);
            Console.WriteLine("Player_two Guess number is : " + player_two);
            int player_three = random.Next(0, 101);
            Console.WriteLine("Player_three Guess number is : " + player_three);
            int player;
            Console.Write("Enter a number between 0 to 100 : ");
            if (!int.TryParse(Console.ReadLine(), out player))
            {
                Console.WriteLine("Invalid input!");
                continue; // skip rest
            }
            Console.WriteLine("Player Guess number is : " + player);
            int add = player_one + player_two + player_three + player;
            float average = add / 4f; //to get float
            int result = Convert.ToInt32(((int)average) * 0.8);//80% of the average
            Console.WriteLine("Result:" + result);
            //do not use else if ,if we use it than others conditions are ignored
            if (player_one >= result - 2 && player_one <= result + 2)
            {
                score_one++;
                Console.WriteLine("Player_one Score:" + score_one);
                if (score_one == 10)
                {
                    Console.WriteLine("Player one is winner");
                    break;
                }
                
            }
            if (player_two >= result - 2 && player_two <= result + 2)
            {
                score_two++;
                Console.WriteLine("Player_two Score:" + score_two);
                if (score_two == 10)
                {
                    Console.WriteLine("Player two is winner");
                    break;
                }
                
            }
            if (player_three >= result - 2 && player_three <= result + 2)
            {            
                score_three++;
                Console.WriteLine("Player_three Score:" + score_three);
                if (score_three == 10)
                {
                    Console.WriteLine("Player three is winner");
                    break;
                }
                
            }
            if (player >= result - 2 && player <= result + 2)
            {
                score++;
                Console.WriteLine("Player Score:" + score);
                if (score == 10)
                {
                    Console.WriteLine("You win the game");
                    break;
                }
                
            }
            else { }
        }
    }
}


namespace C__Course
{
    class Game {
        static void Number_Guess(string[] args) {
            Guess guess = new Guess();
            guess.Objective();
        }
    }
}