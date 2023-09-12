using System; 

class URI {

    static void Main(string[] args) { 

            string[] entrada = Console.ReadLine().Split(' ');
            float[] numeros = Array.ConvertAll(entrada, float.Parse);
            
            float
            n1 = numeros[0],
            n2 = numeros[1],
            n3 = numeros[2],
            n4 = numeros[3],
            resultado = (float)((n1*2+n2*3+n3*4+n4)/10.0f),
            notaArred = (float)Math.Round(resultado*10)/10.0f,
            notaExame = 0,
            mediaFinal = 0;
            
            Console.WriteLine($"Media: {notaArred:F1}");
            if (notaArred >= 7)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (notaArred < 5)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                notaExame = float.Parse(Console.ReadLine());
                Console.WriteLine($"Nota do exame: {notaExame:F1}");
                mediaFinal = ((notaExame+notaArred)/2.0f);
                if(mediaFinal >= 5)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine($"Media final: {mediaFinal:F1}");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine($"Media final: {mediaFinal:F1}");
                }
            }

    }

}