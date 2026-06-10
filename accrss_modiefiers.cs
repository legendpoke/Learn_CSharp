using System;
using System.Collections.Generic;
using System.Text;

class Player
{
    private int score = 0;

    public void AddScore(int points)
    {
        score += points;
    }

    public void ShowScore()
    {
        Console.WriteLine("Score: " + score);
    }
}

namespace C__Course
{
    class Program_seven {
        static void access_modifiers(string[] args) {
            Player p = new Player();

            p.AddScore(10);   // increase score
            p.AddScore(20);

            p.ShowScore();    // access value safely
        }
    }
}
