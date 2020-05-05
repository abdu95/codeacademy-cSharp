using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Two references to the same object
            Dissertation diss1 = new Dissertation();
            Dissertation diss2 = diss1;
            diss1.CurrentPage = 31;
            diss1.Flip();
            Console.WriteLine(diss1.CurrentPage);
            Console.WriteLine(diss2.CurrentPage);
            // Both print 32

            // Referential equality when comparing reference types
            Dissertation d1 = new Dissertation(50);
            Dissertation d2 = new Dissertation(50);
            Console.WriteLine(d1 == d2);
            // Prints false

            // Value equality when comparing value types
            int int1 = 6;
            int int2 = 6;
            Console.WriteLine(int1 == int2);
            // Prints true

            // Reference to object with implemented interface
            Dissertation diss = new Dissertation(50);
            IFlippable f = diss;
            diss.Flip();
            f.Flip();
            Console.WriteLine(diss.Define());
            // This causes an error!
            // Console.WriteLine(f.Define());

            // Reference to object with inherited superclass
            Dissertation diss3 = new Dissertation(19, "Lajos Kossuth", "Shiny Happy People");
            Book bdiss3 = diss3;
            Console.WriteLine(diss3.Author);
            Console.WriteLine(bdiss3.Author);
            Console.WriteLine(diss3.Define());
            // This causes an error!
            // bdiss3.Define();

            // Arrays of references
            IFlippable[] flippers = new IFlippable[] { new Dissertation(), new Diary() };
            foreach (IFlippable flipper in flippers)
            {
                flipper.Flip();
            }

            // Same reference type but different behavior (using virtual/override)
            Book bdiss = new Dissertation();
            Book bk = new Book();
            Console.WriteLine(bdiss.Stringify());
            Console.WriteLine(bk.Stringify());
            // Output:
            // "This is a Dissertation object!"
            // "This is a Book object!"

            // Null reference
            Diary dy = null;
            // Unassigned reference
            Diary dy2;
            // Unassigned references in array
            Diary[] dys = new Diary[5];
        }
    }
    /*
     * REFERENCE FUNDAMENTALS
Review
You made it! References aren’t always easy, but learning how to use them unlocks a whole new set of superpowers in C#.

In this lesson you learned that:

Classes and interfaces are reference types. A variable of this type holds a reference to the data, not the data itself. This is different from value types like int and bool
The equality operator (==) uses a referential comparison for reference types and a value comparison for value types
Multiple references can be created for a single object
A reference and its corresponding object do not have to be the same type. For example, we can refer to a subclass object by an inherited superclass or implemented interface reference
The functionality available to an object reference is determined by the reference’s type, not the object’s type
Polymorphism is the ability in programming to present the same interface for differing data types
Referencing an object by an inherited type or implemented interface is called upcasting. It can be done implicitly
Referencing an object by a derived class is called downcasting, which must be made explicit by adding the type name in parentheses. It may cause an InvalidCastException error when the code is run
To signify that a reference is “empty” or refers to no object, we set it equal to null
If a reference is not set to any value it is unassigned and cannot perform any operations
Instructions
In Program.cs, there are two lines that are commented out:

f.Define();
bdiss3.Define();
Before you move on, make sure you can explain why each of them cause an error.
     
     */
}
