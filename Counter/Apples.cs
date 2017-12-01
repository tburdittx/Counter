using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    public class Apples : ICountable
    {
        public int Apple { get; set; }
        public int Counter = 0;
        public int Count()
        {
            var Apple = 1;
            return Apple;





        }
        public int List()
        {
            List<int> fruit = new List<int>();
            fruit.Add(Apple); fruit.Add(Apple); fruit.Add(Apple); fruit.Add(Apple); fruit.Add(Apple); fruit.Add(Apple);
            fruit.Add(Apple); fruit.Add(Apple); fruit.Add(Apple); fruit.Add(Apple); fruit.Add(Apple); fruit.Add(Apple);
            fruit.Add(Apple); fruit.Add(Apple); fruit.Add(Apple); fruit.Add(Apple); fruit.Add(Apple); fruit.Add(Apple);

            Counter = fruit.Count();
            return Counter;

        }


    }
}
