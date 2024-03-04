interface IAnimal
{
    void animalSound(); // interface method (does not have a body)
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
        Console.WriteLine("The pig says: wee wee wee" );
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
    static void Main(string[] args)
    {
        Pig myPig = new Pig();  // Create a Pig object
        myPig.animalSound();
        myPig.legs();

        Horse myHorse = new Horse();
        myHorse.animalSound();
        myHorse.sleep();
    }
}