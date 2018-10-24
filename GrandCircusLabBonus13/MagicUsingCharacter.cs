using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLabBonus13
{
    class MagicUsingCharacter : GameCharacter
    {
        public MagicUsingCharacter(string name, int strength, int intelligence) : base(name, strength, intelligence)
        {/*I did a thing here where magical energy isn't an actual input
         * but rather it's a function of the character's intelligence
         * (like how an RPG would do it)
         * also I wanted to see how it would actually work
         */
            MagicalEnergy = intelligence * 5;
        }

        private int magicalEnergy;
        public int MagicalEnergy
        {
            get
            {
                return magicalEnergy;
            }
            set
            {
                magicalEnergy = value;
            }
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"{"Magical Energy:",-17} {magicalEnergy}");
        }

        //skipped GetClass here since it seems redundant
    }
}
