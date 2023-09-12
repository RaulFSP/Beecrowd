using System; 

class URI {

    static void Main(string[] args) { 

        int 
        x = int.Parse(Console.ReadLine()),
        y = int.Parse(Console.ReadLine()),
        max = 0, 
        min = 0,
        soma = 0;
        if(x > y)
        {
            max = x;
            min = y;
        }
        else
        {
            max = y;
            min = x;
        }
        for(int i = max-1; i > min; --i)
        {
            if(i%2!=0)
            {
                soma+=i;
            }
        }
        Console.WriteLine(soma);
    }

}