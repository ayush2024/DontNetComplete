using System;
using System.Collections.Generic;

namespace ayush2
{
    public delegate void HelloDele(string text);
    class Program
    {
        public static void Hello(String s)
        {
            Console.WriteLine(s);
        }
        public static void Main1(string[] args)
        {
            HelloDele H1 = new HelloDele(Hello);
            H1("Ayush");
        }

    }
}

namespace ayush3
{
    class delExam2
    {
        public static bool Promote(Emplpyee emp)
        {
            if (emp.Exp > 5)
                return true;
            else return false;
        }
        public static void Main2(string[] args)
        {
            List<Emplpyee> empList = new List<Emplpyee>();

            empList.Add(new Emplpyee() { ID = 1, Name = "Ayush", Salary = 100, Exp = 5 });
            empList.Add(new Emplpyee() { ID = 2, Name = "Aditya", Salary = 200, Exp = 2 });
            empList.Add(new Emplpyee() { ID = 3, Name = "Mansi", Salary = 300, Exp = 7 });
            empList.Add(new Emplpyee() { ID = 4, Name = "Puspa", Salary = 400, Exp = 1 });

            isPromotable ispromote = new isPromotable(Promote);

            // Emplpyee.promoteEmp(empList, ispromote);
            Emplpyee.promoteEmp(empList, emp => emp.Exp >= 5); // Lambda expression does the same as before using the bool method
        }
    }

    delegate bool isPromotable(Emplpyee empl);

    class Emplpyee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Exp { get; set; }

        public static void promoteEmp(List<Emplpyee> empList, isPromotable IsEligiblePromote)
        {
            foreach (Emplpyee emp in empList)
            {
                if (IsEligiblePromote(emp))
                {
                    Console.WriteLine(emp.Name + " promoted");
                }
            }
        }
    }
}

namespace ayush4
{
    delegate void sampleDele();
    class multiDele
    {
        public static void sampleOneMethod()
        { Console.WriteLine("Sample Mehtod One is Invoked"); }
        public static void sampleTwoMethod()
        { Console.WriteLine("Sample Mehtod One is Invoked"); }
        public static void sampleThreeMethod()
        { Console.WriteLine("Sample Mehtod One is Invoked"); }
        public static void sampleFourMethod()
        { Console.WriteLine("Sample Mehtod One is Invoked"); }

        public static void Main4(string[] args)
        {
            sampleDele del = new sampleDele(sampleOneMethod);
            del += sampleThreeMethod;
            del -= sampleThreeMethod;
            del();

            sampleDele del1, del2, del3, del4;

            del1 = new sampleDele(sampleOneMethod);
            del2 = new sampleDele(sampleTwoMethod);
            del3 = new sampleDele(sampleThreeMethod);

            del4 = del1 + del2 + del3; // Multicast delegate by chaining the instances of delegates
            del4();
        }
    }
}



