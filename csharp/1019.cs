using System; 

class URI {

    static void Main(string[] args) { 

        int entrada, horas, minutos, segundos;
        int.TryParse(Console.ReadLine(), out entrada);
        horas = entrada/3600;
        minutos = entrada%3600/60;
        segundos = entrada%3600%60;
        Console.WriteLine($"{horas}:{minutos}:{segundos}");
    }

}