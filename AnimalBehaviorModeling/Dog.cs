using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalBehaviorModeling
{
    internal class Dog : Animal, Land
    {
        private int NumberOfLegs = 4;

        public Dog(int mood) : base(true, true, mood)
        {
        }

        #region methods
        public override void sayHello()
        {
            if (mood == MOOD_HAPPY)
            {
                Console.WriteLine("bark, bark");
            }
            else if (mood == MOOD_SCARE)
            {
                Console.WriteLine("whoop, whoop");
            }
            else
            {
                Console.WriteLine("wagging the tail");
            }
        }

        public int getNumberOfLegs()
        {
            return NumberOfLegs;
        }
        #endregion
    }
}
