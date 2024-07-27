using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mabinogi_Calculator_WPF.MVVM.ViewModel;

namespace Mabinogi_Calculator_WPF.MVVM.Model
{
    class Calculations
    {
        public Calculations() { }

        private double CalculateStat(int baseStat, double divisor)
        {
            return ((baseStat - 10) / divisor);
        }

        public int CalcBaseDefense(int strength)
        {
            //Calculates base defense from total strength stat (base + modifiers, yellow value in-game), first 10 strength are non-existent.
            return (int)CalculateStat(strength, 10);
        }
        public int CalcBaseMagicDefense(int will)
        {
            //Calculates base magic defense from total will stat (base + modifiers, yellow value in-game), first 10 will are non-existent.
            return (int)CalculateStat(will, 10);
        }
        public int CalcBaseMagicProtection(int intelligence)
        {
            //Calculates base magic protection from total intelligence stat (base + modifiers, yellow value in-game), first 10 intelligence are non-existent.
            return (int)CalculateStat(intelligence, 20);
        }
        public int CalcBaseMagicAttack(int intelligence)
        {
            return (int)CalculateStat(intelligence, 5);
        }
        public int CalcMinimumDamage(int strength)
        {
            //Calculate minimum damage from total strength stat
            return (int)CalculateStat(strength, 3);
        }
        //public int CalcMinimumDamage(int strength, string weapon){} Placeholder for when weapons implemented
        public int CalcMaximumDamage(int strength)
        {
            //Calculate maximum damage from total strength stat
            return (int)CalculateStat(strength, 2.5);
        }
        public double CalcCriticalRate(int will, int luck)
        {
            double critRate = (((double)will - 10) / 10.0) + (((double)luck - 10) / 5.0);
            return Math.Round(critRate, 1, MidpointRounding.ToZero);
        }
        public int CalcMaximumInjury(int dex, int will)
        {
            double maxInjury = ((dex - 10) / 10) + (2 * ((will - 10) / 10));
            return (int)Math.Min(maxInjury, 100.0);
        }
        public int CalcMinimumInjury(int dex, int will)
        {
            double minInjury = (0.5 * ((dex - 10) / 10)) + (0.5 * ((will - 10) / 10));
            return (int)Math.Min(minInjury, 100.0);
        }
        public int CalcArmorPierce(int dex)
        {
            return (int)CalculateStat(dex, 15);
        }
    }
}
