using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creation_Design_Pattern
{
    public interface IProduct
    {
        void Printer();
    }

    public class BlackWhitePrinter : IProduct
    {
        public void Printer()
        {
            Console.WriteLine("Black White Printer");
        }
    }

    public class ColourPrinter : IProduct
    {
        public void Printer()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Colour Printer");
            Console.ResetColor();
        }
    }

    public class Factory
    {
        public static IProduct GetProduct(string type)
        {
            if(type == "BlackWhitePrinter")
                return new BlackWhitePrinter();
            else
                return new ColourPrinter();
        }

    }
}
