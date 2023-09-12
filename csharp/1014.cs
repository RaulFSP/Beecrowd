using System; 

class URI {

    static void Main(string[] args) { 

        int km;
        int.TryParse(Console.ReadLine(), out km);
        float combustivel;
        float.TryParse(Console.ReadLine(), out combustivel);
        float media = km/combustivel;
        Console.WriteLine($"{media:F3} km/l");
    }

}