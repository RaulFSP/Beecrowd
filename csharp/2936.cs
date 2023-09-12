using System; 

class URI {

    static void Main(string[] args) { 
        
        int
        curupira = int.Parse(Console.ReadLine()),
        boitata = int.Parse(Console.ReadLine()),
        boto = int.Parse(Console.ReadLine()),
        mapinguari = int.Parse(Console.ReadLine()),
        iara = int.Parse(Console.ReadLine()),
        resultado = curupira*300+boitata*1500+boto*600+mapinguari*1000+iara*150+225;
        Console.WriteLine(resultado);
    }

}