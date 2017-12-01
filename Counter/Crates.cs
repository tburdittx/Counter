using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    public class Crates : ICountable
    {
        

        private int apple = 0;
        private int orange = 0;
        private int pear = 0;
        private int ball = 0;
        private int bubble = 0;
        private int grape = 0;

        private int counting = 0;

        public void List()
        {
            {

                List<int> Items = new List<int>();

                Items.Add(apple); Items.Add(apple); Items.Add(apple); Items.Add(apple); Items.Add(apple);
                Items.Add(apple); Items.Add(apple); Items.Add(apple); Items.Add(apple); Items.Add(apple);
                Items.Add(orange); Items.Add(grape); Items.Add(bubble); Items.Add(apple); Items.Add(ball);
                Items.Add(apple); Items.Add(apple); Items.Add(apple); Items.Add(apple); Items.Add(apple);
                Items.Add(apple); Items.Add(apple); Items.Add(apple); Items.Add(apple); Items.Add(apple);

                counting = Items.Count(x => x == apple); ++counting;
            }


        }

        public int Count()
        {
            List();
            return counting;
        }
    }
}
