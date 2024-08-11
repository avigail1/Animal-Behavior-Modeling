// See https://aka.ms/new-console-template for more information
using AnimalBehaviorModeling;

//how many animals
int count_animals = 6;

//initial the array of animals
Animal[] animals = new Animal[count_animals];

animals[0] = new Cat(1);
animals[1] = new Dog(2);
animals[2] = new Dog(3);
animals[3] = new Frog(1);
animals[4] = new Frog(3);
animals[5] = new Cat(2);

//for (int i = 0; i < animals.Length; i++)
//{
//    Console.WriteLine(animals[i].ToString());
//    animals[i].sayHello();
//}


for (int i = 0; i < animals.Length; i++)
{
    Console.WriteLine(animals[i].ToString());
    animals[i].sayHello(5);
}