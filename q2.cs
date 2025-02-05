//Bonus calculator

using System;

class BonusCalculator
{
    static void Main()
    {
        
        Console.Write("Enter the employee's salary: ");
        if (double.TryParse(Console.ReadLine(), out double salary))
        {
            
            Console.Write("Enter the employee's years of experience: ");
            if (int.TryParse(Console.ReadLine(), out int experience))
            {
                double bonusPercentage = 0;

               
                if (experience >= 5 && experience <= 10)
                {
                    bonusPercentage = 10;
                }
                else if (experience >= 11 && experience <= 15)
                {
                    bonusPercentage = 15;
                }
                else if (experience > 15)
                {
                    bonusPercentage = 20;
                }

            
                double bonusAmount = (salary * bonusPercentage) / 100;

                
                Console.WriteLine($"Bonus earned: ₹{bonusAmount:F2}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number for years of experience.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid salary amount.");
        }
    }
}
