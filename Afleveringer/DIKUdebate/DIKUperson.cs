namespace DIKUdebate;
using System;

public class DIKUperson
{
    private string name; //field
    private DIKUPreparation preparation;
    private int maxIntellect;
    private int intellect;
    private int strengthOfArgument;
    private int semester;
    private int counterArgument;
    private int criticalArgument;
    private Random rand = new Random();
    public DIKUperson (string sName, DIKUPreparation sPreparation) //constructor
    {
        name = sName;
        preparation = sPreparation;
        maxIntellect = 30;
        intellect = 30;
        strengthOfArgument = 3;
        semester = 1;
        counterArgument = 10;
        criticalArgument = 10;
    }
    
    public string Name //properties
    {
        get {return name;} //Remove set as it should not be possible to change a person name
    }
    public DIKUPreparation Preparation
    {
        get {return preparation;} //Remove set as it should not possible to change preparation
    }
    public int MaxIntellect
    {
        get {return maxIntellect;}
        set {maxIntellect = value;}
    }
    public int Intellect
    {
        get {return intellect;}
        set 
        {
            if(intellect > maxIntellect)
            {
                intellect = maxIntellect;
            }
            else
            {
                intellect = value;
            }

        }
    }
    public int StrengthOfArgument
    {
        get {return strengthOfArgument;}
        set {strengthOfArgument = value;}
    }
    public int Semester
    {
        get {return semester;}
        set {semester = value;}
    }
    public int CounterArgument
    {
        get {return counterArgument;}
        set {counterArgument = value;}
    }
    public int CriticalArgument
    {
        get {return criticalArgument;}
        set {criticalArgument = value;}
    }
    
    public override String ToString()
    { 
        return String.Format("Name: " + this.Name + "\nPreparation: " + this.Preparation + "\nMaxIntellect: " + this.MaxIntellect + "\nIntellect: " + this.Intellect + "\nStrengthOfArgument: " + this.StrengthOfArgument + "\nSemester: " + this.Semester + "\nCounterArgument: " + this.CounterArgument + "\nCriticalArgument: " + this.CriticalArgument);
    }
    public bool hasLost()
    {
        if(Intellect<=0)
        {
            return true;
        }
        return false;
    }
    public bool beDrained(int amount)
    {
        if (rand.Next(100)< CounterArgument)
        {
            Console.WriteLine(this.Name + " use a valid counter argument");
            return false;
        }
        else
        {
            Console.WriteLine(this.Name + "'s intellect is being drained by " + amount);
            Intellect = Intellect - amount;
            return true;
        }
    }
    public void Argue(DIKUperson opponent)
    {
        if (rand.Next(100) < CriticalArgument)
        {
            Console.WriteLine(this.Name + " strikes an argument at " + opponent.Name + " for " + (2*StrengthOfArgument) + " points of draining.");
            opponent.beDrained(2*StrengthOfArgument);
        }
        else
        {
            Console.WriteLine(this.Name + " strikes an argument at " + opponent.Name + " for " + StrengthOfArgument + " points of draining.");
            opponent.beDrained(StrengthOfArgument);
        }
    }
    public void GetExperience()
    {
        Semester += 1;
        StrengthOfArgument +=2;
        if(Preparation == DIKUPreparation.ReadingAll)
        {
            MaxIntellect += 20;
        }
        else
        {
            MaxIntellect += 10;
        }
        if(Preparation == (DIKUPreparation.ReadingSome | DIKUPreparation.ReadingAll))
        {
            CounterArgument += 6;
        }
        else
        {
            CounterArgument += 3;
        }
        if(Preparation == (DIKUPreparation.ReadingAll))
        {
            CriticalArgument += 6;
        }
        else
        {
            CriticalArgument += 3;
        }
        Intellect = MaxIntellect;
    }
}       