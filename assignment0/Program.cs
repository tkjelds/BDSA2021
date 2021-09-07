using System;

namespace assignment0
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public bool IsLeapYear(int year) {
            if(year % 4 == 0) {
                if(year % 100 == 0){
                    return year % 400 == 0;
                } else{
                    return true;
                }
            } else {
                return false;
            }
        }

        public void YayOrNay(string yearString){
            //Console.WriteLine("Please enter a year");

            int year;

            var success = int.TryParse(yearString, out year);

            if (success) 
            {
                if (IsLeapYear(year))  Console.WriteLine("Yay");
                else Console.WriteLine("Nay");
            } else
            {
                Console.WriteLine($"Failed conversion of: {yearString}");
            }

        }



    }
}
