using System; 

class URI {

    static void Main(string[] args) { 

            int 
            x = int.Parse(Console.ReadLine()),
            y = int.Parse(Console.ReadLine()),
            min,
            max,
            resultado = 0;
            if (x > y)
            {
                min = y;
                max = x;
            }
            else
            {
                min = x;
                max = y;
            }
            for(int i = min; i <= max; ++i)
            {
                if ( i%13!= 0)
                {
                    resultado+=i;
                }
            }
            Console.WriteLine(resultado);

    }

}