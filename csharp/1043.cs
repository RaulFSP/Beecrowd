using System; 

class URI {

    static void Main(string[] args) { 

        string[] entrada = Console.ReadLine().Split(' ');
        float[] numeros = Array.ConvertAll(entrada, float.Parse);
        float
        a = numeros[0],
        b = numeros[1],
        c = numeros[2],
        perimetro = 0;
        double area = 0;
        if(a >= b+c || b >= a+c || c >= a+b)
        {
            area = ((a+b)*c)/2.0;
            Console.WriteLine($"Area = {area:F1}");
        }
        else
        {
            perimetro = a+b+c;
            Console.WriteLine($"Perimetro = {perimetro:F1}");
        }    
    }

}