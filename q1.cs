//An e commerce website provides cashback based on purchase amount below (1k)no cashback is offer (1001 to 5000) 5% cashback will be provided
//(5001 to 10k)is 10% and above 10k have 15% purchase amount 
//Take as a input

using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter the purchase amount: ");

        
        double purchaseAmount = Convert.ToDouble(Console.ReadLine());

       
        double cashback = 0;

        
        if (purchaseAmount <= 1000)
        {
            cashback = 0; // No cashback for amounts below or equal to 1000
        }
        else if (purchaseAmount > 1000 && purchaseAmount <= 5000)
        {
            cashback = purchaseAmount * 0.05; // 5% cashback
        }
        else if (purchaseAmount > 5000 && purchaseAmount <= 10000)
        {
            cashback = purchaseAmount * 0.10; // 10% cashback
        }
        else if (purchaseAmount > 10000)
        {
            cashback = purchaseAmount * 0.15; // 15% cashback
        }

        Console.WriteLine($"The cashback amount is: {cashback:C}");
    }
}
