/*
Choose 1 through 5: 7
Choose a number from 1 to 5.
Choose 1 through 5: 3*/


using System.Diagnostics;

System.Console.WriteLine("=== CSCI 1250 Lab 06 ===");
System.Console.WriteLine("1. The Grade Checker");
System.Console.WriteLine("2. The Dice Table");
System.Console.WriteLine("3. The Score Report");
System.Console.WriteLine("4. All three");
System.Console.WriteLine("5. Quit");
System.Console.Write("Choose 1 through 5: ");

int choice = Convert.ToInt32(Console.ReadLine());

if (choice != 1 || choice != 2 || choice !=3 || choice !=4 || choice !=5)
{
    System.Console.WriteLine("Choose a number from 1 to 5.");
    System.Console.WriteLine("Choose 1 through 5: ");
    choice = Convert.ToInt32(Console.ReadLine());
    
}




if (choice == 1 || choice == 4)
{
// Exercise 1
}
if (choice == 2 || choice == 4)
{
// Exercise 2
}
if (choice == 3 || choice == 4)
{
// Exercise 3
}