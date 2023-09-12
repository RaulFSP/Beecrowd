using System; 

class URI {

    static void Main(string[] args) { 

        int horas, velocidadeMedia;
        int.TryParse(Console.ReadLine(), out horas);
        int.TryParse(Console.ReadLine(), out velocidadeMedia);
        float resultado = (horas*velocidadeMedia)/12.0f;
        Console.WriteLine($"{resultado:F3}");
    }

}