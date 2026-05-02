using System;
namespace Casher_System;

class Program
{
    static double taxRate = 0.14; // Global Variable

    static void Main(string[] args)
    {
        Console.WriteLine("----------------------------------------------------------------------------");
        PrintWelcome();
        Console.WriteLine("----------------------------------------------------------------------------");
        double price; // غيرناها لـ double عشان الفلوس
        int quantity;

        // بعتنا الرسالة اللي عايزينها تظهر كـ Parameter للميثود
        price = GetValidNumber("Enter Product Price: ");
        Console.WriteLine("----------------------------------------------------------------------------");
        quantity = (int)GetValidNumber("Enter Product Quantity: "); // عملنا cast لـ int لأن الكمية دايما رقم صحيح

        Console.WriteLine("----------------------------------------------------------------------------");

        // استقبلنا القيمة اللي راجعة من الميثود
        double subTotal = CalculateSubTotal(price, quantity);
        Console.WriteLine("Total Price (Before Tax): " + subTotal);

        // التعديل الرياضي: المجموع + (المجموع * نسبة الضريبة)
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

    // خلينا الميثود تاخد text كبارامتر عشان نطبع الرسالة الصح لكل حالة
    static double GetValidNumber(string promptMessage)
    {
        double number;
        bool isValid = false;

        do
        {
            Console.Write(promptMessage); // هيطبع الرسالة اللي اتبعتتله من الـ Main
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