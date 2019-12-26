using System;

namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Trying to understand the Decorator Design Pattern

            /*
             * Problem Statement: 
             *  1. Microsoft allows booking of an exam at a regular price.
             *  2. If you are Rebooking the exam, you get a discount of 10% on base price
             *  3. Later they offered additional discount for Premium Account 
             *      which means if you are Premium Customer but are re-appearing both the discounts are applicable to you.
             * 
             * You could have modified Rebooking Exam to add additional discount based on a flag if IsPremium
             *  but that way you will breach the OPEN CLOSED principle
             */

            var bookRegularExam = new NewMicrosoftExamBookingConcreteComponent
            {
                VoucherCount = 1,
                VoucherPrice = 4000
            };

            Console.WriteLine(bookRegularExam.CalculateTotalInvoice());

            var reBookExam = new MicrosoftExamReBookingDecoratorComponent(bookRegularExam);
            Console.WriteLine(reBookExam.CalculateTotalInvoice());

            var premiumBookingExam = new MicrosoftExamPremiumBookingDecoratorComponent(bookRegularExam);
            Console.WriteLine(premiumBookingExam.CalculateTotalInvoice());

            var premiumReBookingExam = new MicrosoftExamPremiumBookingDecoratorComponent(reBookExam);
            Console.WriteLine(premiumReBookingExam.CalculateTotalInvoice());

            Console.ReadLine();
        }
    }
}
