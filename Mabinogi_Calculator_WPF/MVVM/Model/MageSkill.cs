using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mabinogi_Calculator_WPF.MVVM.Model
{
    class MageSkill : Skill
    {
        private double _minSpellConstant;
        private double _maxSpellConstant;
        private double _minDamageConstant;
        private double _maxDamageConstant;

        public MageSkill(string skillName, string skillType, List<double> mainSkillDamage, List<double> raceSkillDamage, double minSpellConstant, double maxSpellConstant, double minDamageConstant, double maxDamageConstant)
        {
            SkillName = skillName;
            SkillType = skillType;
            MainSkillDamage = mainSkillDamage;
            RaceSkillDamage = raceSkillDamage;
            MinSpellConstant = minSpellConstant;
            MaxSpellConstant = maxSpellConstant;
            MinDamageConstant = minDamageConstant;
            MaxDamageConstant = maxDamageConstant;
        }

        public double MinSpellConstant
        {
            get { return this._minSpellConstant; }
            set { this._minSpellConstant = value; }
        }
        public double MaxSpellConstant
        {
            get { return this._maxSpellConstant; }
            set { this._maxSpellConstant = value; }
        }
        public double MinDamageConstant
        {
            get { return this._minDamageConstant; }
            set { this._minDamageConstant = value; }
        }
        public double MaxDamageConstant
        {
            get { return this._maxDamageConstant; }
            set { this._maxDamageConstant = value; }
        }
    }
}
