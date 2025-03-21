using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealmsOfMayhem.Core.Entities.Units
{
    public class CavalryUnit : Unit
    {
        public CavalryUnit(int hp, int attack, UnitPosition unitPosition)
            : base(hp, attack, UnitType.Cavalry, unitPosition)
        {
        }

        public override int GetModifiedAttack(Unit defender)
        {
            if (defender.Type == UnitType.Infantry )
            {
                return (int)(Attack * 1.5);
            }

            return base.GetModifiedAttack(defender);
        }
    }

    public class MountedMan : CavalryUnit
    {
        public MountedMan(UnitPosition position) : base(150, 25, position) { }
    }

    public class TemplarKnight : CavalryUnit
    {
        public TemplarKnight(UnitPosition position) : base( 200, 30, position) { }
    }
}
