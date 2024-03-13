using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("TestyJednostkowe"), InternalsVisibleTo("Okienko")]

namespace ProblemPlecakowyV2
{
    internal class Problem
    {
        private int N; //nr of items
        public List<Item> items = new List<Item>();

        public Problem(int n, int seed)
        {
            this.N = n;

            Random random = new Random(seed);
            for (int i = 0; i < N; i++)
            {
                int weight = random.Next(1, 10);
                int value = random.Next(1, 100);

                Item item = new Item(i, weight, value);
                items.Add(item);
            }
        }

        public Result Solve(int capacity)
        {
            items = items.OrderByDescending(item => item.getRatio()).ToList();

            int total_weight = 0;
            int total_value = 0;
            List<Item> fianal_item = new List<Item>();

            foreach (Item item in items)
            {
                if (total_weight + item.getWeight() <= capacity)
                {
                    fianal_item.Add(item);
                    total_weight += item.getWeight();
                    total_value += item.getValue();

                    //Console.Write("Weight: " + item.getWeight());
                    //Console.Write(" Value: " + item.getValue());
                    //Console.Write(" Ratio: " + item.getRatio() + "\n");

                    //Console.WriteLine(item.ToString());
                }
                Console.WriteLine(item.ToString());
            }

            Result result = new Result(total_weight, total_value, fianal_item);
            Console.WriteLine(result.ToString());
            return result;
        }
    }
}