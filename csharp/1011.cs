using System; 

class URI {

    static void Main(string[] args) { 

        int numero; 
        double pi = 3.14159;
        int.TryParse(Console.ReadLine(), out numero);
        double volume = (4/3.0)*pi*Math.Pow(numero,3);
        Console.WriteLine($"VOLUME = {volume:F3}");

    }

}