using System; 

class URI {

    static void Main(string[] args) { 
        
        string[] entrada = Console.ReadLine().Split(' ');
        float[] numeros = Array.ConvertAll(entrada, float.Parse);
        Array.Sort(numeros);
        string
        trianguloForma = "",
        trianguloLado = "";
        float
        c = numeros[0],
        b = numeros[1],
        a = numeros[2];
        if (a >= b+c)
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else
        {
            if (Math.Pow(a,2) == Math.Pow(b,2)+Math.Pow(c,2)){
                trianguloForma = "TRIANGULO RETANGULO";
            }
            else if (Math.Pow(a,2) > Math.Pow(b,2)+Math.Pow(c,2))
            {
                trianguloForma = "TRIANGULO OBTUSANGULO";
            }
            else if (Math.Pow(a,2) < Math.Pow(b,2)+Math.Pow(c,2))
            {
                trianguloForma = "TRIANGULO ACUTANGULO";
            }
            if (a == b && b == c)
            {
                trianguloLado = "TRIANGULO EQUILATERO";
            }
            else if (a==b || b==c || c==a)
            {
                trianguloLado = "TRIANGULO ISOSCELES";
            }
            else
            {
                trianguloLado = "";
            }
            Console.WriteLine(trianguloForma);
            if(trianguloLado.Length == 0)
            {
                trianguloLado = "vazio";
            }
            else{
                Console.WriteLine(trianguloLado);
            }
        }
    }

}