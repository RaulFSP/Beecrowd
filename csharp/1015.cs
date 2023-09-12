using System; 

class URI {

    static void Main(string[] args) { 

        string[] entrada1 = Console.ReadLine().Split(' ');
        float[] valores1 = Array.ConvertAll(entrada1, float.Parse);
        string[] entrada2 = Console.ReadLine().Split(' ');
        float[] valores2 = Array.ConvertAll(entrada2, float.Parse);
        float
        x1 = valores1[0],
        y1 = valores1[1],
        x2 = valores2[0],
        y2 = valores2[1],
        X =  (float) Math.Pow(x2-x1, 2),
        Y = (float) Math.Pow(y2-y1,2),
        distancia = (float) (Math.Sqrt(X+Y));
        Console.WriteLine($"{distancia:F4}");

    }

}