namespace Lektion_3_Debugging;

class Program
{
    static void Main(string[] args)
    {
        bool run = false;
        // ----------------------------  DEL 1  ----------------------------
        // Skapar en array med 30 element
        int[] nums = new int[30];
        
        //fyller vår array
        for (int i = 0; i < 30; i++)
        {
            nums[i] = i * 5;
        }
        // Skriv ut alla värden i arrayen med en foreach-loop
        
        
        
        
        // ----------------------------  DEL 2  ----------------------------
        // Vi vill summera alla tal som är 100 eller mer detta ska bli 1225
        
        // sum för att hålla totalen
        int sum = 0;
        
        if (run)
        {
            foreach (int j in nums)
            {
                if (j > 100)
                {
                    sum = j;
                }
            }
            Console.WriteLine(sum == 1225);
        }
        

    }
}