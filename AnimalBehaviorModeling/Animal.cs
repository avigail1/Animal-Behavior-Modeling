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
        protected bool Mammals { get; set; }

        protected bool Carnivorous { get; set; }

        public readonly int MOOD_HAPPY = 1;

        public readonly int MOOD_SCARE = 2;

        protected int Mood;

        public Animal(bool mammals, bool carnivorous, int mood)
        {
            this.Mammals = mammals;
            this.Carnivorous = carnivorous;
            this.Mood=mood;
        }

        #region methods
        public virtual void sayHello() {}

        public virtual void sayHello(int mood)
        {
            this.Mood = mood;
            sayHello();
        }

        public override string ToString()
        {
            return $"i am a {this.GetType().Name}";
        }

        #endregion
    }
}
