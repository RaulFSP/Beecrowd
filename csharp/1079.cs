using System; 

class URI {

    static void Main(string[] args) { 

        int entrada; 
        double resultado = 0;
        int.TryParse(Console.ReadLine(), out entrada);
        for(int i = 0; i < entrada; ++i)
        {
            string[] valores = Console.ReadLine().Split(' ');
            double[] numeros = Array.ConvertAll(valores, double.Parse);
            resultado = (numeros[0]*2+numeros[1]*3+numeros[2]*5)/10.0;
            Console.WriteLine($"{resultado:F1}");
        }
    }

}