using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalBehaviorModeling
{
    internal class Frog: Animal, Land, Water
    {
        private int NumberOfLegs = 4;

        public Frog(int mood) : base(false, false, mood)
        {
        }

        #region methods
        public override void sayHello()
        {
            if (mood == MOOD_HAPPY)
            {
                Console.WriteLine("quack quack quack");
            }
            else if (mood == MOOD_SCARE)
            {
                Console.WriteLine("plop into the water");
            }
            else
            {
                Console.WriteLine("quack quack quack & plop into the water");
            }
        }

        public bool HasGills()
        {
            return false;
        }

        public bool HasLaysEggs()
        {
            return true;
        }

        public int getNumberOfLegs()
        {
            return NumberOfLegs;
        }
        #endregion
    }
}
