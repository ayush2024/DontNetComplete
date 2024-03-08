using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace DontNetComplete.NewFolder
{
    class Base
    {
        private int a;
        private string job;

        public int intPro
        {
            get { return a; }
            set { a = value; }
        }
        public string stringPro
        {
            get { return job; }
            set { job = value; }
        }

        void displayBase() // by default it is of private type
        {
            Console.WriteLine("Private From Base Class");
        }

        public void showBase() 
        { 
            Console.WriteLine("Public show From Base Class");
        }

        protected int add (int a, int b) // can only be accessible in the derived class
        { return a + b; }

        
        public virtual string name()
        {
            return "Ayush Base";
        }
    }

    class subClass : Base
    {
        public void displaySubClass() 
        {
            Console.WriteLine("Display From subbclass");
        }

        public int cal(int a, int b = 3)
        {
            return a + b;
        } 
        public int cal(int a, int b, int c)
        {
            return a + b;
        }

        public override string name()
        {
            return "Ayush Sub";
        }
        public new int add(int a, int b)
        {
            return a + b;
        }
    }

    class subClass2 : Base
    {
        int age;
        string name;

        public subClass2(int agee, string namee)
        {
            this.age = agee;
            this.name = namee;
        }   

        public void displaySubClass2() 
        {
            Console.WriteLine($"Name {name} and age is {age}");
        }
    }

    /*
     Can not use multiple Inhritence for this we have to use Interface
    Have Done in Proram.cs File
    class Multiple : subClass , subClass2
    {

    }
    */

    class Oops : subClass// By default class is of type internal 
    {
        void display()
        {
            Console.WriteLine("Simply says Hello");
        }
        static void displayStatic()
        {
            Console.WriteLine("Statically says Hello");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            Oops oop = new Oops();
            oop.display();
            displayStatic(); // don't need to create the instance of class to call it because of static
            int val = oop.intPro = 10;
            string job = oop.stringPro = "React Js";
            Console.WriteLine ("Using Properties " + val +" " + job);

            Base b = new Base();
            b.showBase();
            Console.WriteLine(b.name());

            subClass sub = new subClass();  
            sub.displaySubClass();

            //Console.WriteLine(sub.add(2, 2));  // not possible
            Console.WriteLine(oop.add(2, 2));  // possible because it is inheritagin from subClass which is inheriting from Base class
            
            // Method Overloading
            Console.WriteLine(sub.cal(2, 8));
            Console.WriteLine(sub.cal(2));
            Console.WriteLine(sub.cal(22,2,10));

            // Method Overriding
            Console.WriteLine(sub.name());

            // Mehod Hiding
            Console.WriteLine(sub.add(100,200));

            subClass2 sub2 = new subClass2(21, "Ayush");
            sub2.displaySubClass2();

        }
    }
}
