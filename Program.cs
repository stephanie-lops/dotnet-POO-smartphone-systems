using System;
using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Criando um Nokia
        Nokia nokia = new Nokia("1234-5678", "Nokia X", "111111111111");
        Console.WriteLine($"Nokia - Modelo: {nokia.Modelo}, Número: {nokia.Numero}, IMEI: {nokia.Imei}");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        // Criando um iPhone
        Iphone iphone = new Iphone("9876-5432", "iPhone 14", "222222222222");
        Console.WriteLine($"iPhone - Modelo: {iphone.Modelo}, Número: {iphone.Numero}, IMEI: {iphone.Imei}");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");

        Console.ReadKey();
    }
}
