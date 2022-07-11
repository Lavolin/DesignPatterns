using System;

namespace ShallowDeepCopy
{
    public class Program
    {
                              //  Prototype Pattern
        static void Main(string[] args)
        {
            Sandwich firstSandwich = new Sandwich(
                bread: "white", 
                meat: "salami", 
                cheese: "feta", 
                veggies:"tomato", 
                test: new Test(15));

            Sandwich shallowCopy = firstSandwich.ShallowCopy();

            Sandwich deepCopy = firstSandwich.DeepCopy();

            shallowCopy.Test.Integer = 20;
            deepCopy.Test.Integer = 40;

            Console.WriteLine($"{nameof(firstSandwich)} {firstSandwich.Test.Integer}");

            Console.WriteLine($"{nameof(shallowCopy)} {shallowCopy.Test.Integer}");

            Console.WriteLine($"{nameof(deepCopy)} {deepCopy.Test.Integer}");
        }
    }
}
