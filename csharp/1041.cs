using System; 

class URI {

    static void Main(string[] args) { 

        string[] entrada = Console.ReadLine().Split(' ');
        float
        q1 = float.Parse(entrada[0]),
        q2 = float.Parse(entrada[1]);
        if(q1 == 0 && q2 == 0)
        {
            Console.WriteLine("Origem");
        }
        else if (q1 == 0 && (q2 > 0 || q2 < 0))
        {
            Console.WriteLine("Eixo Y");
        }
        else if (q2 == 0 && (q1 > 0 || q1 < 0))
        {
            Console.WriteLine("Eixo X");
        }
        else if (q1 > 0 && q2 > 0)
        {
            Console.WriteLine("Q1");
        }
        else if (q1 > 0 && q2 < 0)
        {
            Console.WriteLine("Q4");
        }
        else if (q1 < 0 && q2 > 0)
        {
            Console.WriteLine("Q2");
        }
        else 
        {
            Console.WriteLine("Q3");
        }
    }

}