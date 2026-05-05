using System;
namespace Casher_System;

class Program
{
    static double taxRate = 0.14; 

    static void Main(string[] args)
    {
        Console.WriteLine("----------------------------------------------------------------------------");
        PrintWelcome();
        Console.WriteLine("----------------------------------------------------------------------------");
        double price; 
        int quantity;

        
        price = GetValidNumber("Enter Product Price: ");
        Console.WriteLine("----------------------------------------------------------------------------");
        quantity = (int)GetValidNumber("Enter Product Quantity: "); 

        Console.WriteLine("----------------------------------------------------------------------------");

       
        double subTotal = CalculateSubTotal(price, quantity);
        Console.WriteLine("Total Price (Before Tax): " + subTotal);

        double finalTotal = subTotal + (subTotal * taxRate);
        Console.WriteLine("Final Total (After Tax): " + finalTotal);
        Console.WriteLine("----------------------------------------------------------------------------");
    }

    static void PrintWelcome()
    {
        Console.WriteLine("Welcome to our Supermarket!");
    }

    static double CalculateSubTotal(double ProductPrice, int ProductQuantity)
    {
        double TotalPrice = ProductPrice * ProductQuantity;
        return TotalPrice;
    }

    
    static double GetValidNumber(string promptMessage)
    {
        double number;
        bool isValid = false;

        do
        {
            Console.Write(promptMessage); 
            number = double.Parse(Console.ReadLine());

            if (number > 0)
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine("Invalid input, number must be greater than 0. Try again.\n");
            }
        } while (isValid == false);

        return number;
    }
}