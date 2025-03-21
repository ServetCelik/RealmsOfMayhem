using RealmsOfMayhem.Core.Entities.Buildings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealmsOfMayhem.Core.Entities
{
    public class UserBuilding
    {
        public int Id { get; private set; }
        public Building Building { get; private set; }
        public int Count { get; private set; }

        public UserBuilding(Building building, int count)
        {
            Building = building;
            Count = count;
        }

        public void Add(int amount) => Count += amount;
        public void Remove(int amount)
        {
            if (Count < amount) throw new InvalidOperationException("Not enough buildings to remove.");
            Count -= amount;
        }
    }
}
