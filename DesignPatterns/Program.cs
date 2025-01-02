using DesignPatterns.Creation_Design_Pattern;

enum EnumDesignPatterns
{
    None = 0,
    Singleton = 1
}


public class Program
{
    public static void Main(string[] args)
    {
        EnumDesignPatterns designPattern = EnumDesignPatterns.Singleton;

        switch (designPattern)
        {
            case EnumDesignPatterns.Singleton:
                Singleton singleton = Singleton.GetInstance();
                singleton.PrintMessage();
                break;
            default:
                Console.WriteLine("Invalid Pattern");
                break;
        }
    }
}

