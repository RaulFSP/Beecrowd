using System; 

class URI {

    static void Main(string[] args) { 

        string[] entrada = Console.ReadLine().Split(' ');
        int abasIniciais = int.Parse(entrada[0]);
        int atitudes = int.Parse(entrada[1]);
        int resultado = abasIniciais;
        for(int i = 0; i < atitudes; ++i)
        {
            string acao = Console.ReadLine();
            if(acao == "fechou")
            {
                ++resultado;
            }
            if(acao == "clicou")
            {
                --resultado;
            }
        }
        Console.WriteLine(resultado);
    }

}