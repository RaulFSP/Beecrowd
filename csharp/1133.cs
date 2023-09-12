using System; 

class URI {

    static void Main(string[] args) { 

        int 
        x = int.Parse(Console.ReadLine()),
        y = int.Parse(Console.ReadLine()),
        min,
        max;
        
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
        for(int i = min+1; i < max; ++i)
        {
            if (i % 5 == 2 || i % 5 == 3)
            {
                Console.WriteLine(i);
            }
        }

    }

}