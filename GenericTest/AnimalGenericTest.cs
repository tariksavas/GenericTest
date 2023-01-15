namespace GenericTest
{ 
    public class AnimalGeneric<T> where T : Animal
    {
        public void Speak(T item)
        {
            Console.WriteLine("Animal Speaking...");
            item.Speak();
        }
    }

    public abstract class Animal
    {
        public abstract void Speak();
    }

    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Hav hav!");
        }
    }

    public class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Meow!");
        }
    }

     public class AnimalGenericTest
     {
         public static void Run()
         {
             Console.WriteLine("\n\nAnimalGenericTest testing...");
             
             Dog dog = new Dog();
             Cat cat = new Cat();
             
             AnimalGeneric<Animal> animals = new AnimalGeneric<Animal>();
             animals.Speak(dog);
             animals.Speak(cat);
         }
     }
}