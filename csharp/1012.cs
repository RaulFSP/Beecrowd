using System; 

class URI {

    static void Main(string[] args) { 

        string[] entrada = Console.ReadLine().Split(' ');
        float[] numeros = Array.ConvertAll(entrada, float.Parse);
        float 
        triangulo = numeros[0]*numeros[2]/2.0f,
        circulo = (float)(Math.Pow(numeros[2],2)*3.14159),
        trapezio = ((numeros[0]+numeros[1])*numeros[2])/2.0f,
        quadrado = numeros[1]*numeros[1],
        retangulo = (float)(numeros[0]*numeros[1]);
        Console.WriteLine($"TRIANGULO: {triangulo:F3}");
        Console.WriteLine($"CIRCULO: {circulo:F3}");
        Console.WriteLine($"TRAPEZIO: {trapezio:F3}");
        Console.WriteLine($"QUADRADO: {quadrado:F3}");
        Console.WriteLine($"RETANGULO: {retangulo:F3}");

    }

}