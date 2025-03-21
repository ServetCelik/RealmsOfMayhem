using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealmsOfMayhem.Core.Entities.Units
{
    public class AxeUnit : Unit
    {
        public AxeUnit(int hp, int attack, UnitPosition unitPosition)
           : base(hp, attack, UnitType.Axeman, unitPosition)
        {
        }

        public override int GetModifiedAttack(Unit defender)
        {
            if (defender.Type == UnitType.Cavalry)
            {
                return (int)(Attack * 0.6); 
            }

            return base.GetModifiedAttack(defender);
        }
    }

    public class AxeMan : AxeUnit
    {
        public AxeMan(UnitPosition position) : base(150, 25, position) { }
    }

    public class Berserk : AxeUnit
    {
        public Berserk(UnitPosition position) : base(200, 30, position) { }
    }
}
}
