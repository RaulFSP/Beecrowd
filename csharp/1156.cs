using System; 

class URI {

    static void Main(string[] args) { 

        double soma = 0, contador = 1;
        for(int i = 1; i <= 39; i+=2)
        {
            soma = soma + (i/contador);
            contador*=2;
        }
        Console.WriteLine(soma.ToString("F2"));

    }

}