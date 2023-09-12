using System; 

class URI {

    static void Main(string[] args) { 

        string 
        animalSelecionado,
        animal1 = Console.ReadLine(),
        animal2 = Console.ReadLine(),
        animal3 = Console.ReadLine();
        if (animal1 == "vertebrado")
        {
            if (animal2 == "ave")
            {
                if (animal3 == "carnivoro")
                {
                    animalSelecionado = "aguia";
                }
                else
                {
                    animalSelecionado = "pomba";
                }
            }
            else
            {
                if (animal3 == "onivoro")
                {
                    animalSelecionado = "homem";
                }
                else
                {
                    animalSelecionado = "vaca";
                }
            }
        }
        else
        {
            if (animal2 == "inseto")
            {
                if (animal3 == "hematofago")
                {
                    animalSelecionado ="pulga";
                }
                else
                {
                    animalSelecionado = "lagarta";
                }
            }
            else
            {
                if (animal3 == "hematofago")
                {
                    animalSelecionado = "sanguessuga";
                }
                else
                {
                    animalSelecionado = "minhoca";
                }
            }
        }
        Console.WriteLine($"{animalSelecionado}");    

    }

}