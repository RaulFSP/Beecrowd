using System; 

class URI {

    static void Main(string[] args) { 

        string[] entrada = Console.ReadLine().Split(' ');
        double 
        a = double.Parse(entrada[0]),
        b = double.Parse(entrada[1]),
        c = double.Parse(entrada[2]);
        double delta = (Math.Pow(b,2) - 4 * a * c);
        double r1 = 0, r2 = 0;
        if (delta < 0 || a == 0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            r1 = (-b + Math.Sqrt(delta))/(2.0*a);
            r2 = (-b - Math.Sqrt(delta))/(2.0*a);
            Console.WriteLine($"R1 = {r1:F5}");
            Console.WriteLine($"R2 = {r2:F5}");
        }

    }

}