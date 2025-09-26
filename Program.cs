using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Smartphone Nokia:");
        Smartphone nokia = new Nokia("123456", "Nokia Tijolão", "111111111111111", 32);
        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\n-----------------------------\n");

        Console.WriteLine("Smartphone iPhone:");
        Smartphone iphone = new Iphone("654321", "iPhone 15 Pro", "222222222222222", 256);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
