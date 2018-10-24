using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLabBonus13
{
    class Warrior : GameCharacter
    {
        public Warrior(string name, int strength, int intelligence, string weaponType) : base (name, strength, intelligence)
        {            
            WeaponType = weaponType;
        }

        private string weaponType;
        public string WeaponType
        {
            get
            {
                return weaponType;
            }
            set
            {
                weaponType = value;
            }
        }

        public override void Play()
        {//adds weapon type to printout list
            base.Play();
            Console.WriteLine($"{"Weapon type:", -17} {weaponType}");
        }

        public override string GetClass()
        {
            return "Warrior";
        }
    }
}
