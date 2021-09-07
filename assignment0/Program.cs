using System;

namespace assignment0
{
    public class Program
    {


        public interface IGetInput{
            string getInput();
        }

        public class getUserInput : IGetInput
        {
            string IGetInput.getInput()
            {
                return Console.ReadLine().Trim();
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public bool isLeapYear(int year) {
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

        public void yayOrNay(IGetInput input){
            //Console.WriteLine("Please enter a year");
            var yearString = input.getInput();

            int year;

            var success = int.TryParse(yearString, out year);

            if (success) 
            {
                if (isLeapYear(year))  Console.WriteLine("Yay");
                else Console.WriteLine("Nay");
            } else
            {
                Console.WriteLine($"Failed conversion of: {yearString}");
            }

        }


    }
}
