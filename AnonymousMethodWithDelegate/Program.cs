using System;

namespace AnonymousMethodWithDelegate
{   //Anonymous Function
    class Program
    {
        public delegate void CompanyName(string Name);
        static void Main(string[] args)
        {   
            CompanyName c = delegate (string CName)
             {
                 Console.WriteLine("Our Company Name is: {0}", CName);
             };
            //user can assign this method to a variable of the delegate type
            c("IncubXperts");

                
        }
    }
}
