using System; 

class URI {

    static void Main(string[] args) { 

        int entrada;
        int.TryParse(Console.ReadLine(), out entrada);
        string ddd = "";
        switch(entrada)
        {
            case 61: ddd = "Brasilia"; break;
            case 71: ddd = "Salvador"; break;
            case 11: ddd = "Sao Paulo"; break;
            case 21: ddd = "Rio de Janeiro"; break;
            case 32: ddd = "Juiz de Fora"; break;
            case 19: ddd = "Campinas"; break;
            case 27: ddd = "Vitoria"; break;
            case 31: ddd = "Belo Horizonte"; break;
            default: ddd = "DDD nao cadastrado"; break; 
        }
        Console.WriteLine(ddd);

    }

}