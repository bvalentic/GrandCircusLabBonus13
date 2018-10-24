using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLabBonus13
{
    public class GameCharacter
    {
        protected string name;
        protected int strength;
        protected int intelligence;

        public GameCharacter(string name, int strength, int intelligence)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Strength
        {
            get
            {
                return strength;
            }
            set
            {
                strength = value;
            }
        }
        public int Intelligence
        {
            get
            {
                return intelligence;
            }
            set
            {
                intelligence = value;
            }
        }

        public virtual void Play()
        {//doesn't actually "play"; prints name, class, and stats of character
            Console.WriteLine($@"{"Name:",-17} {name}
{"Class:",-17} {GetClass()}
{"Strength:",-17} {strength}
{"Intelligence:",-17} {intelligence}");
        }

        public virtual string GetClass()
        {//returns character class 
         //(this way another argument isn't needed for printing purposes)
            return "Game Character";
        }        
    }
}
