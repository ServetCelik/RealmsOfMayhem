using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealmsOfMayhem.Core.Entities.Units
{
    public class InfantryUnit : Unit
    {
        public InfantryUnit(int hp, int attack, UnitPosition unitPosition)
            : base(hp, attack, UnitType.Infantry, unitPosition)
        {
        }
    }

    public class BronzeSwordInfantry : InfantryUnit
    {
        public BronzeSwordInfantry(UnitPosition position)
            : base(100, 15, position) { }
    }

    public class IronSwordInfantry : InfantryUnit
    {
        public IronSwordInfantry(UnitPosition position)
            : base(120, 20, position) { }
    }
}
