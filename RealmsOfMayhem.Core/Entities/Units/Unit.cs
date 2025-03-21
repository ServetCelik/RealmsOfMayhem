using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealmsOfMayhem.Core.Entities.Units
{
    public abstract class Unit
    {
        public int HP { get; protected set; }
        public int Attack { get; protected set; }
        public UnitType Type { get; protected set; }
        public UnitPosition Position { get; protected set; }

        protected Unit(int hp, int attack, UnitType type, UnitPosition unitPosition)
        {
            HP = hp;
            Attack = attack;
            Type = type;
            Position = unitPosition;
        }

        public virtual int GetModifiedAttack(Unit defender)
        {
            return Attack;
        }
    }
}
