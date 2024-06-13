namespace TimeToSell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] jour1 = { 7, 1, 5, 3, 6, 4 };
            //int[] jour2 = { 1, 2, 3, 4, 5 };
            //int[] jour3 = { 7, 6 , 4, 3, 1 };
            var jour1 = new List<int> { 7, 1, 5, 3, 6, 4 };
            var jour2 = new List<int> { 1, 2, 3, 4, 5 };
            var jour3 = new List<int> { 7, 6, 4, 3, 1 };

            Console.WriteLine($"Profit = {Profit(jour1)}");
            Console.WriteLine($"Profit = {Profit(jour2)}");
            Console.WriteLine($"Profit = {Profit(jour3)}");
         
        }
        static int Profit(List<int> action)
        {
            int profit = 0;
            for (int i = 0; i < (action.Count - 1); i++)
            {
                if (action[i] < action[i + 1])
                {
                    profit = profit + (action[i + 1] - action[i]);
                }
            }

            return profit;
        }
    }
}
