using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealmsOfMayhem.Core.Entities.Units
{
    public class ArcherUnit : Unit
    {
        public int RangedAttack { get; private set; }
        public ArcherUnit(int hp, int attack, int rangedAttack, UnitPosition position)
            : base(hp, attack, UnitType.Archer, position)
        {
            RangedAttack = rangedAttack;
        }

        public override int GetModifiedAttack(Unit defender)
        {
            if (Position == UnitPosition.Frontline)
            {
                return Attack;
            }
            else
            {
                return RangedAttack;
            }
        }
    }

    public class BasicArcher : ArcherUnit
    {
        public BasicArcher(UnitPosition position) : base(80, 5, 15,position) { }
    }

    public class Longbow : ArcherUnit
    {
        public Longbow(UnitPosition position) : base( 90, 7, 20,position) { }
    }
}
