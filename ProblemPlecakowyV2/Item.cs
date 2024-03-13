using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemPlecakowyV2
{
    internal class Item
    {
        private int _id;
        private int weight;
        private int value;
        private double ratio;

        public Item(int id, int weight, int value)
        {
            this._id = id;
            this.weight = weight;
            this.value = value;
            this.ratio = value / weight;
        }

        public int Id
        { get { return _id; } }

        public double getRatio()
        {
            return this.ratio;
        }

        public int getWeight()
        {
            return this.weight;
        }

        public int getValue()
        {
            return this.value;
        }

        public override string ToString()
        {
            return "ID: " + this.Id.ToString() + "\tWeight: " + this.weight.ToString() + "\tValue: " + this.value.ToString() + "\tRatio: " + this.ratio.ToString();
        }
    }
}