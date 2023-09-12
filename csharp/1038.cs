using System; 

class URI {

    static void Main(string[] args) { 

        string[] entrada = Console.ReadLine().Split(' ');
        int[] numeros = Array.ConvertAll(entrada, int.Parse);
        
        int
        codigo = numeros[0],
        quantidade = numeros[1];
        
        float 
        valor = 0,
        resultado = 0;
        
        switch(codigo)
        {
            case 1: valor = 4.00f; break;
            case 2: valor = 4.50f; break;
            case 3: valor = 5.00f; break;
            case 4: valor = 2.00f; break;
            case 5: valor = 1.50f; break;
            default: Console.WriteLine("Fora do escopo"); break;
        }
        resultado = (float) (valor * quantidade);
        Console.WriteLine($"Total: R$ {resultado:F2}");
      

    }

}