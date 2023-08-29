using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeonBattle
{
    internal class Monster
    {
        private int Level;
        private string Name;
        private int Attack;
        private int HP;

        public event Action<Character> OnHit;

        public event Action OnDead;

        public event Action<Character> OnAttack;
    }
}
