using RealmsOfMayhem.Core.Entities.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealmsOfMayhem.Core.Entities
{
    public class Army
    {
        private List<Unit> _units = new List<Unit>();

        public IReadOnlyList<Unit> Units => _units.AsReadOnly();

        public void AddUnit(Unit unit)
        {
            _units.Add(unit);
        }

        public void RemoveUnit(Unit unit)
        {
            _units.Remove(unit);
        }
    }
}
