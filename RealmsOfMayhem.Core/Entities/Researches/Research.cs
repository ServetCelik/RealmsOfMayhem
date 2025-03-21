using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealmsOfMayhem.Core.Entities.Researches
{
    public class Research
    {
        public string Name { get; private set; }
        public double TotalCost { get; private set; } 
        public double OptimalSpendPerTurn { get; private set; }
        public double CurrentProgress { get; private set; }

        public bool IsCompleted => CurrentProgress >= TotalCost;

        public Research(string name, double totalCost, double optimalSpendPerTurn)
        {
            if (totalCost <= 0 || optimalSpendPerTurn <= 0)
                throw new ArgumentException("Cost and optimal spend must be positive.");

            Name = name;
            TotalCost = totalCost;
            OptimalSpendPerTurn = optimalSpendPerTurn;
            CurrentProgress = 0;
        }

        public virtual void ApplyEffect(User user)
        {
            // Base class: no default behavior
        }

        /// <summary>
        /// Spend gold on research. Returns the actual progress made this turn (adjusted for efficiency).
        /// </summary>
        public double SpendGold(double amount)
        {
            if (IsCompleted)
                return 0;

            if (amount <= 0)
                throw new ArgumentException("Spend amount must be positive.");

            // Efficiency logic
            double ratio = amount / OptimalSpendPerTurn;

            double efficiency;
            if (ratio <= 1.0)
            {
                efficiency = ratio;
            }
            else
            {
                efficiency = 1.0 + Math.Log10(ratio);
            }

            double actualProgress = OptimalSpendPerTurn * efficiency;
            double progressRemaining = TotalCost - CurrentProgress;

            if (actualProgress > progressRemaining)
                actualProgress = progressRemaining;

            CurrentProgress += actualProgress;
            return actualProgress;
        }

        public double ProgressRemaining => TotalCost - CurrentProgress;

        public double GetCompletionPercentage()
        {
            return Math.Min(100.0, (CurrentProgress / TotalCost) * 100);
        }
    }
}
