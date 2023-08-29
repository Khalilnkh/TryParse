using System;

namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool IsSuccessful = CustomTryParse("Salam", out int num);
            if (IsSuccessful)
            {
                Console.WriteLine($"Result is succesful. VAlue is {num}");
            }
            else
            {
                Console.WriteLine($"Result is unsuccesfull {num} ");
            }
        }
        public static bool CustomTryParse(string word, out int num)
        {
            
               
            try
            {
                num = int.Parse("5s5asa");
                Console.WriteLine(num);
                Console.WriteLine(true);
                return true;

            }
            catch (Exception ex)
            {

                num=0;
                Console.WriteLine(false);
                return false;
            }
            


        }
    }
}
