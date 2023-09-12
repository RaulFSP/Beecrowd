using System; 

class URI {

    static void Main(string[] args) { 

        string[] entrada = Console.ReadLine().Split(' ');
        int[] valores = Array.ConvertAll(entrada, int.Parse);
        Array.Sort(valores);
        foreach(int i in valores)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
        foreach(string i in entrada)
        {
            Console.WriteLine(i);
        }
    }

}