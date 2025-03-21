using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealmsOfMayhem.Core.Entities.Researches
{
    public class LawResearch : Research
    {
        public LawResearch() : base("Structured Law", 400, 60) { }

        public override void ApplyEffect(User user)
        {
            user.TaxIncomeMultiplier += 0.2;
        }
    }
}
