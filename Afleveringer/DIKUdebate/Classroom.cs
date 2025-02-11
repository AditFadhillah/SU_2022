namespace DIKUdebate;
using System;

public class Classroom
{
    public DIKUperson Discussion(DIKUperson person1 , DIKUperson person2)
    {
        Console.WriteLine("Debate til drained!");
        int round = 1;
        DIKUperson current = person1;
        DIKUperson inactive = person2;
        DIKUperson winner;
        while (!person1.hasLost() && !person2.hasLost ())
        {
            Console.WriteLine("ROUND: {0}", round);
            current.Argue(inactive);

            var temp = current;
            current = inactive;
            inactive = temp;
            current.Argue(inactive);
            round += 1;
        }
        if(person1.hasLost())
        {
            winner = person2;
            Console.WriteLine("The winner is: {0}", winner.Name);
            winner.GetExperience();
            person1.Intellect = person1.MaxIntellect; //Reset a losers intellect so they still have a chance to win. 
            return winner;
        }
        winner = person1;
        Console.WriteLine("The winner is: {0}", winner.Name);
        person2.Intellect = person2.MaxIntellect; 
        winner.GetExperience();
        return winner;
    }
}