int choice = 0;
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
// Exercise 2
        System.Console.WriteLine("2");
    }
    if (choice == 3 || choice == 4)
    {
// Exercise 3
        System.Console.WriteLine("3");
    }



} while (choice != 5);
Console.WriteLine("Goodbye.");







