using DesignPatterns.Creation_Design_Pattern;

enum EnumDesignPatterns
{
    None = 0,
    Factory = 1,
    Singleton = 2
}


public class Program
{
    public static void Main(string[] args)
    {
        string designPatternString = "Enter the value of design pattern\n";
        foreach (EnumDesignPatterns enumDesignPatterns in Enum.GetValues(typeof(EnumDesignPatterns)))
        {
            designPatternString += $"{(int)enumDesignPatterns} - {enumDesignPatterns}\n";
        }
        Console.WriteLine(designPatternString);

        int val = Int32.TryParse(Console.ReadLine(), out int parsedVal) ? parsedVal : 0;
        EnumDesignPatterns designPattern = (EnumDesignPatterns)val;

        switch (designPattern)
        {
            case EnumDesignPatterns.Singleton:
                Singleton singleton = Singleton.GetInstance();
                singleton.PrintMessage();
                break;
            case EnumDesignPatterns.Factory:
                IProduct product = Factory.GetProduct("ColourPrinter");
                product.Printer();
                IProduct product2 = Factory.GetProduct("BlackWhitePrinter");
                product2.Printer();
                break;
            default:
                Console.WriteLine("Invalid Pattern");
                break;
        }
    }
}

