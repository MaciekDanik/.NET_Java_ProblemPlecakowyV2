using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemPlecakowyV2
{
    internal class Result
    {
        private int total_weight;
        private int total_value;
        private List<Item> final_items;

        public Result(int total_weight, int total_value, List<Item> final_items)
        {
            this.total_weight = total_weight;
            this.total_value = total_value;
            this.final_items = final_items;
        }

        public List<Item> getFinalItems()
        {
            return this.final_items;
        }

        public override string ToString()
        {
            string str = "Total weight: " + this.total_weight.ToString() + Environment.NewLine + "Total Value: " + this.total_value.ToString() + Environment.NewLine + Environment.NewLine + $"Items in backpack ({final_items.Count}): ";

            foreach (var item in final_items)
            {
                str += Environment.NewLine + item.ToString();
            }

            return str;
        }
    }
}