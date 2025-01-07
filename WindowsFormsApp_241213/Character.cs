using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_241213
{
    internal class Character
    {
        int hp;
        int attackPower;
        string name;

        public Character() { }
        public Character(int hp, int attackPower, string name)
        {
            this.hp = hp;
            this.attackPower = attackPower;
            this.name = name;
        }
    }
}
