using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLabBonus13
{
    class Wizard : MagicUsingCharacter
    {
        public Wizard(string name, int strength, int intelligence, int spellNumber) 
            : base(name, strength, intelligence)
        {//I kept spell number as an input stat unlike magical energy
            SpellNumber = spellNumber;
        }

        private int spellNumber;
        public int SpellNumber
        {
            get
            {
                return spellNumber;
            }
            set
            {
                spellNumber = value;
            }
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"{"Number of spells:",-17} {spellNumber}");
        }

        public override string GetClass()
        {/*it looks like grandchild classes 
            (or whatever sub-of-sub-classes are called) 
            can inherit from their grandparent class */
            return "Wizard";
        }
    }
}
