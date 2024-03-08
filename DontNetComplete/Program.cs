namespace ayush
{
    interface IAnimal
    {
        void animalSound(); // interface method (does not have a body)
        static int i = 100;
    }

    interface ILeg
    {
        void legs();
    }

    // Pig "implements" the IAnimal interface

    class Lion : IAnimal, ILeg
    {
        void IAnimal.animalSound()
        {
            Console.WriteLine("Roar...");
        }
        void ILeg.legs()
        {
            Console.WriteLine("4 Legs...");
        }
    }
    class Pig : IAnimal, ILeg
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee wee");
        }

        public void legs()
        {
            Console.WriteLine("Have 4 legs");
        }
    }

    abstract class Animal
    {
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
    class Horse : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The horse says: hee hee");
        }
    }

    // Diamond problem reason Multiple inheritance solution is interface.
    //         A
    //        / \
    //        B C
    //        \ /
    //         D

    class Program
    {
        public int fun(int i)
        {
            i++;
            return i;
        } 
        public int fun2(ref int i)
        {
            i++;
            return i;
        }

        int fun3(out int y)
        {
            y = 20;
            return y;
        }
        static void Main2(string[] args)
        {
            Pig myPig = new Pig();  // Create a Pig object
            myPig.animalSound();
            myPig.legs();

            Horse myHorse = new Horse();
            myHorse.animalSound();
            myHorse.sleep();

            // Call By Value
            int i = 10;
            Console.WriteLine(i);
            Program p = new Program();    
            Console.WriteLine("Call By value " + p.fun(i));
            Console.WriteLine(i);

            // Call By Reference
            int x = 10;
            Console.WriteLine(x);
            Program q = new Program();    
            Console.WriteLine("Call By refernce " + q.fun2(ref x));
            Console.WriteLine(x);

            // Out Parameter
            int y;
            Console.WriteLine("Take example of Out parameter " + q.fun3(out y));
            Console.WriteLine(y);

            
        }
    }
}

