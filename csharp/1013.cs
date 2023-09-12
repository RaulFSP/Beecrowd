using System; 

class URI {

    static void Main(string[] args) { 

        string[] entrada = Console.ReadLine().Split(' ');
        int[] valores = Array.ConvertAll(entrada, int.Parse);
        int a = valores[0], b = valores[1], c = valores[2];
        int resultado = (a+b+Math.Abs(a-b))/2;
        int resultadoFinal = (resultado+c+Math.Abs(resultado-c))/2;
        Console.WriteLine($"{resultadoFinal} eh o maior");

    }

}