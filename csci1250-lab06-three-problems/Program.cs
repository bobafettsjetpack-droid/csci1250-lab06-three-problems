using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

int choice = 0;
Random rng = new Random(4000);
// do while ensures that the menu is presented each time the question is asked, then it gives the out if the choice is 5
do
{
    choice = 0;
    System.Console.WriteLine("=== CSCI 1250 Lab 06 ===");
    System.Console.WriteLine("1. The Grade Checker");
    System.Console.WriteLine("2. The Dice Table");
    System.Console.WriteLine("3. The Score Report");
    System.Console.WriteLine("4. All three");
    System.Console.WriteLine("5. Quit");
    System.Console.Write("Choose 1 through 5: ");

    choice = Convert.ToInt32(Console.ReadLine());

// ensures number 1-5
// while continually checks if the input is in the valid number range
    while (choice != 1 && choice != 2 && choice !=3 && choice !=4 && choice !=5)
    {
        System.Console.WriteLine("Choose a number from 1 to 5.");
        System.Console.Write("Choose 1 through 5: ");
        choice = Convert.ToInt32(Console.ReadLine());
    
    }
// else if allows to check for multiple different inputs and gives a response based on each.  This one is very easy to use when checking for 
// a range of numbers that could be inputed
    if (choice == 1 || choice == 4)
    {
        int score = 0;
        System.Console.WriteLine("=== Exercise 1: The Grade Checker ===");
        System.Console.Write("Score: ");
        score = Convert.ToInt32(Console.ReadLine());
        
        // continually checks if input is valid
        while (score > 100 || score < 0)
        {
            System.Console.WriteLine("A score must be between 0 and 100.");
            System.Console.Write("Score: ");
            score = Convert.ToInt32(Console.ReadLine());
        }


        if (score >= 90)
        {
            System.Console.WriteLine($"{score} earns an A.");
        }
        else if (score >= 80)
        {
            System.Console.WriteLine($"{score} earns a B.");
        }
        else if (score >= 70)
        {
            System.Console.WriteLine($"{score} earns a C.");
        }
        else if (score >= 60)
        {
            System.Console.WriteLine($"{score} earns a D.");
        }
        else if (score < 60)
        {
            System.Console.WriteLine($"{score} earns an F.");
        }
    }





    if (choice == 2 || choice == 4)
    {
        string doRoll = "y";
        System.Console.WriteLine("=== Exercise 2: The Dice Table ===");
        int count = 0;
        int wins = 0;

        // do when is useful because I want an action repeated until a certain input is given
        do
        {
            int roll1 = rng.Next(1, 7);
            int roll2 = rng.Next(1, 7);
            int total = roll1 + roll2;
            System.Console.Write($"Roll {++count}: {roll1} and {roll2}, total {total}. ");

            if (roll1 == 1 && roll2 == 1)
            {
                System.Console.Write("Snake eyes.");
        
            }
            else if (total == 7 || total == 11)
            {
                System.Console.Write("A winner.");
                wins +=1;
            }
            else if (roll1 == roll2)
            {
                System.Console.Write("Doubles!");
        
            }
            System.Console.WriteLine();
        


            //again adding !; because it fixes the error, idk what it actually does
            System.Console.Write("Roll again? (y/n): ");
            doRoll = Console.ReadLine()!;

        }while(doRoll.Trim().ToLower() != "n");

        System.Console.WriteLine($"You rolled {count} times and won {wins}.");
    

    }






    if (choice == 3 || choice == 4)
    {
        double[] scores = new double[5];
        System.Console.WriteLine("=== Exercise 3: The Score Report ===");
        
        //inserts the scores into the array for each slot
        for (int i = 0; i < scores.Length; i++)
        {
            System.Console.Write($"Score {i + 1}: ");
            scores[i] = Convert.ToDouble(Console.ReadLine());
        }

        int total = 0;
        double average = 0;
        int highest = 0;
        int passing = 0;


        // foreach lets me look at each score in scores and do someting with it.  It is looking at each one and doing something with the numbers
        foreach (int score in scores)
        {
            total += score;

            if (score > highest)
            {
                highest = score;
            }

            if (score >= 60)
            {
                passing++;
            }

        }

        average = Convert.ToDouble(total) / scores.Length;

        System.Console.WriteLine($"Scores entered: {scores.Length}");
        System.Console.WriteLine($"Total: {total}");
        System.Console.WriteLine($"Average: {average}");
        System.Console.WriteLine($"Highest: {highest}");
        System.Console.WriteLine($"Passing {passing} of {scores.Length}");



    }

    


System.Console.WriteLine();
} while (choice != 5);
Console.WriteLine("Goodbye.");







