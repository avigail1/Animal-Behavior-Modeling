using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AnimalBehaviorModeling
{
    abstract class Animal
    {
        protected bool mammals { get; set; }

        protected bool carnivorous { get; set; }

        public readonly int MOOD_HAPPY = 1;

        public readonly int MOOD_SCARE = 2;

        protected int mood;

        public Animal(bool mammals, bool carnivorous, int mood)
        {
            this.mammals = mammals;
            this.carnivorous = carnivorous;
            this.mood=mood;
        }

        #region methods
        public virtual void sayHello() {}

        public virtual void sayHello(int mood)
        {
            this.mood = mood;
            sayHello();
        }

        public override string ToString()
        {
            return $"i am a {this.GetType().Name}";
        }

        #endregion
    }
}
