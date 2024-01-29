using System;

namespace GreaterThanAndLessThanOperatorsChallenge
{
    class Program
    {
       static void Main()
        {
            //Utilize the greater than operator and display output to the console.
            int discountAge = 56;
            if (discountAge > 60)
            {
                Console.WriteLine("Customer qualifies for a Senior Discount.");
            }
            else
                Console.WriteLine("Customer does not qualify for a Senior Discount.");
            {

                //Utilize the lesser than or equal to operator and display output to the console.
                int lifeguardAge = 15;
                if (lifeguardAge <= 16)
                {
                    Console.WriteLine("You are not eligible to be a lifeguard at the pool.");
                }
                else
                {
                    Console.WriteLine("You should apply to be a lifeguard at the pool!");
                }
            }
        }
    }
}
    

