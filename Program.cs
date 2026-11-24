namespace Lektion_3_Debugging;

class Program
{
    static void Main(string[] args)
    {
        
        List<string> names = new List<string>();
        
        names.Add("Ada");
        names.Add("Linus");
        names.Add("Grace");
        names.Add("Margaret");


        Console.WriteLine(names.Count); 
        Console.WriteLine(names[3]);
        Console.WriteLine(names.Count);
        

        //loopar igenom listan och skriver ut alla namn...//...med en for-loop
       
        for (int i = 0; i < names.Count; i++) 
        {
            Console.WriteLine("I for-loopen:");
            Console.WriteLine(names[i]);

        }
        
        
        //...med en foreach-loopforeach (string name in names)
        foreach (string name in names)
        {
            Console.WriteLine("foreach-loop");
            Console.WriteLine(name);

        }

        Console.WriteLine("Press any key for next part");
        Console.ReadKey();

        
        
        
        bool run = true;
        // ----------------------------  DEL 1  ----------------------------
        // Skapar en array med 30 element
        int[] nums = new int[30];

        //fyller vår array
        for (int i = 0; i < 30; i++)
        {
            nums[i] = i * 5;
        }

        // ----------------------------  DEL 2  ----------------------------
        // Vi vill summera alla tal som är 100 eller mer detta ska bli 1225

        // sum för att hålla totalen
        int sum = 0;

        if (run)
        {
            foreach (int j in nums)
            {
                if (j >= 100)
                {
                    sum += j;
                }
            }
            Console.WriteLine(sum == 1225);
        }
        
    }
}