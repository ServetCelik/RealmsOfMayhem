using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealmsOfMayhem.Core.Entities.Researches
{
    public class MillResearch : Research
    {
        public MillResearch() : base("Mill", 300, 50) { }

        public override void ApplyEffect(User user)
        {
            user.WheatProductionMultiplier += 0.25;
        }
    }
}
