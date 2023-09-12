using System; 

class URI {

    static void Main(string[] args) { 

        string[] diaInicial = Console.ReadLine().Split(' ');
        string[] horaInicial = Console.ReadLine().Split(' ');
        string[] diaFinal = Console.ReadLine().Split(' ');
        string[] horaFinal = Console.ReadLine().Split(' ');
        
        int 
        dia1 = int.Parse(diaInicial[1]),
        hora1 = int.Parse(horaInicial[0]),
        minuto1 = int.Parse(horaInicial[2]),
        segundo1 = int.Parse(horaInicial[4]),
        dia2 = int.Parse(diaFinal[1]),
        hora2 = int.Parse(horaFinal[0]),
        minuto2 = int.Parse(horaFinal[2]),
        segundo2 = int.Parse(horaFinal[4]),
        total1 = (dia1*86400)+(hora1*3600)+(minuto1*60)+segundo1,
        total2 = (dia2*86400)+(hora2*3600)+(minuto2*60)+segundo2,
        resultado = total2 - total1,
        totalDia = resultado/86400,
        totalHora = resultado%86400/3600,
        totalMinuto = resultado%86400%3600/60,
        totalSegundo = resultado%86400%3600%60;
        
        Console.WriteLine($"{totalDia} dia(s)");
        Console.WriteLine($"{totalHora} hora(s)");
        Console.WriteLine($"{totalMinuto} minuto(s)");
        Console.WriteLine($"{totalSegundo} segundo(s)");

    }

}