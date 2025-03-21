using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealmsOfMayhem.Core.Entities.Researches
{
    public class SharpenToolsResearch : Research
    {
        public SharpenToolsResearch() : base("Sharpen Tools", 500, 70) { }

        public override void ApplyEffect(User user)
        {
            user.AttackMultiplier += 0.2;
        }
    }
}
