using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupernaturalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Storm storm = new Storm("wind", false, "Zul'rajas");
            Console.WriteLine(storm.Announce());

            Pupil pupil = new Pupil("Mezil-kree");
            Storm storm2 = pupil.CastWindStorm();
            Console.WriteLine(storm2.Announce());

            Mage mage = new Mage("Gul’dan");
            Storm storm3 = mage.CastRainStorm();
            Console.WriteLine(storm3.Announce());

            Archmage archmage = new Archmage("Nielas Aran");
            Storm storm4 = archmage.CastRainStorm();
            Storm storm5 = archmage.CastLightningStorm();
            Console.WriteLine(storm4.Announce());
            Console.WriteLine(storm5.Announce());

            // Storm[] storms = new Storm[5];
            // int stormsIndex = 0;
            // storms[stormsIndex] = new Storm("wind", false, "Zul'rajas");
            // Console.WriteLine(storms[stormsIndex].Announce());

            // stormsIndex++;
            // for(int i = 0; i<=storms.Length; i++){
            //   Console.WriteLine(storms[i].Announce());
            // }
        }
    }
    /*
     * Extensions
19.
Well done! You’ve created four new classes. Three of them are in an inheritance hierarchy: Archmage inherits from Mage, which inherits from Pupil. Each class has at least one method that uses the fourth class, Storm.

If you’d like more practice, try these optional challenges:

In Program.cs, store the Storm objects in an array instead of separate variables.
Add a string Origin property and a new constructor to the Pupil class. The constructor should have two parameters, one for Title and one for Origin. Add a similar constructor to Mage and Archmage. In other words, you should be able to run this code in Program.cs:
Pupil p = new Pupil("Mezil-kree", "Icecrown");
Mage m = new Mage("Gul'dan", "Draenor");
Archmage a = new Archmage("Nielas Aran", "Stormwind");
3. Define an abstract class Spell with Essence, IsStrong, and Caster properties and an abstract Announce() method. Make Storm inherit from Spell. A Spell.cs file is included in the workspace — find it by clicking the folder icon at the top of the text editor.


    You’ll need to define an array of type Storm[] and use an index to keep track of the last filled space in the array. For example:

Storm[] storms = new Storm[10];
int stormsIndex = 0;
Use a for loop to call Announce() on each object in the array.

The new constructors in Mage and Archmage should have two parameters and use base to call the superclass constructor.

The Spell class should be labeled abstract because its member Announce() is abstract. If Pupil inherits from Spell, then you can move the properties from Pupil to Spell. Change any private modifiers to protected. You must also label Pupil.Announce() with override.
     */
}
