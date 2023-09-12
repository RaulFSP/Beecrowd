using System; 

class URI {

    static void Main(string[] args) { 

        int
        entrada = 0,
        valorPassado = 0,
        valorAtual = 0,
        contador = 0;
        entrada = int.Parse(Console.ReadLine());
        for(int i = 0; i < entrada; ++i)
        {
            valorAtual = int.Parse(Console.ReadLine());
            if(valorAtual != valorPassado)
            {
                ++contador;
                valorPassado=valorAtual;
            }
        }
        Console.WriteLine(contador);

    }

}