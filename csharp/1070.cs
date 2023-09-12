using System; 

class URI {

    static void Main(string[] args) { 

        int 
        contador = 6,
        i = 0;
        int.TryParse(Console.ReadLine(), out i);
        do
        {
            if(i%2!=0)
            {
                --contador;
                Console.WriteLine(i);
            }
            ++i;
        } while (contador > 0);

    }

}