using System; 

class URI {

    static void Main(string[] args) { 

        string[] entrada = Console.ReadLine().Split(' ');
        int
        metrosDesejados = int.Parse(entrada[0]),
        comprimentoPista = int.Parse(entrada[1]),
        lugarGarrafa = metrosDesejados % comprimentoPista;
        Console.WriteLine(lugarGarrafa);

    }

}