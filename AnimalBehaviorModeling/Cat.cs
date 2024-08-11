using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalBehaviorModeling
{
    internal class Cat:Animal , Land
    {
        private int NumberOfLegs = 4;

        public Cat(int mood) : base(true, true, mood)
        {
        }

        #region methods
        public override void sayHello()
        {
            if(mood == MOOD_HAPPY)
            {
                Console.WriteLine("purr, purr");
            }
            else if(mood == MOOD_SCARE)
            {
                Console.WriteLine("hiss, hiss");
            }
            else
            {
                Console.WriteLine("meow~");
            }
        }
        public override void sayHello(int mood)
        {
            base.sayHello(mood);
        }

        public int getNumberOfLegs()
        {
           return NumberOfLegs;
        }


        #endregion
    }
}
