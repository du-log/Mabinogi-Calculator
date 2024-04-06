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

        public int CalcBaseDefense(int strength)
        {
            //Calculates base defense from total strength stat (base + modifiers, yellow value in-game), first 10 strength are non-existent.
            double baseDef = (strength - 10) / 10;
            return (int)baseDef;
        }
        public int CalcBaseMagicDefense(int will)
        {
            //Calculates base magic defense from total will stat (base + modifiers, yellow value in-game), first 10 will are non-existent.
            double baseMDef = (will - 10) / 10;
            return (int)baseMDef;
        }
        public int CalcBaseMagicProtection(int intelligence)
        {
            //Calculates base magic protection from total intelligence stat (base + modifiers, yellow value in-game), first 10 intelligence are non-existent.
            double baseMProt = (intelligence - 10) / 20;
            return (int)baseMProt;
        }
        public int CalcBaseMagicAttack(int intelligence)
        {
            double baseMA = (intelligence - 10) / 5;
            return (int)baseMA;
        }
        public int CalcMinimumDamage(int strength) 
        {
            //Calculate minimum damage from total strength stat
            double minDmg = (strength - 10) / 3;
            return (int)minDmg;
        }
        //public int CalcMinimumDamage(int strength, string weapon){} Placeholder for when weapons implemented
        public int CalcMaximumDamage(int strength) 
        {
            double maxDmg = (strength - 10) / 2.5;
            return (int)maxDmg;
        }
        public double CalcCriticalRate(int will, int luck)
        {
            double critRate = (((double)will - 10) / 10) + (((double)luck - 10) / 5);
            critRate = Math.Round(critRate, 1, MidpointRounding.ToZero);
            return critRate;
        }
        public int CalcMaximumInjury(int dex, int will)
        {
            double maxInjury = ((dex - 10) / 10) + (2 * ((will - 10) / 10));
            if (maxInjury >= 100.0)
            {
                maxInjury = 100.0;
            }
            return (int)maxInjury;
        }
        public int CalcMinimumInjury(int dex, int will)
        {
            double minInjury = (0.5 * ((dex - 10) / 10)) + (0.5 * ((will - 10) / 10));
            if(minInjury >= 100.0)
            {
                minInjury = 100.0;
            }
            return (int)minInjury;
        }
        public int CalcArmorPierce(int dex)
        {
            double armorPierce = ((double)dex - 10)/ 15;
            return (int)armorPierce;
        }
    }
}
