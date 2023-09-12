using System; 

class URI {

    static void Main(string[] args) { 

        int
        pressaoDesejada = int.Parse(Console.ReadLine()),
        pressaoLida = int.Parse(Console.ReadLine());
        Console.WriteLine($"{pressaoDesejada-pressaoLida}");
    }

}