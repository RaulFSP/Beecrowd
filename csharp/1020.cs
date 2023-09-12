using System; 

class URI {

    static void Main(string[] args) { 

        int entrada, ano, mes, dia;
        int.TryParse(Console.ReadLine(), out entrada);
        ano = entrada/365;
        mes = entrada%365/30;
        dia = entrada%365%30;
        Console.WriteLine($"{ano} ano(s)");
        Console.WriteLine($"{mes} mes(es)");
        Console.WriteLine($"{dia} dia(s)");
    }

}