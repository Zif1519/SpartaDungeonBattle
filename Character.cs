using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeonBattle
{
    internal class Character
    {
        private int Level;
        private string Name;
        private ClassType Class;
        private List<Equipment> ItemOnEquipped;
        private int Attack;
        private int Defense;
        private int HP;
        private int MP;
        private int Gold;
        private int Exp;
        private Inventory Inventory;
        private List<Skill> Skills;

        public Character() { }

        public void UseSkill(Skill skill) { }
        
        public void UseItem(Consumption consumption) { }

        public void EquipItem(Equipment equipment) { }

        public void IncreaseExp(int exp) { }

        public event Action<Monster> OnHit;

        public event Action OnDead;

        public event Action<Monster> OnAttack;
    }

    public enum ClassType
    {
        WARRIOR,
        ARCHER,
        MAGICIAN,
        CLERIC
    }
}
