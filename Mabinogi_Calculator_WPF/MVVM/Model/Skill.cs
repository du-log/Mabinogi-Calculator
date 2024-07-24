using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mabinogi_Calculator_WPF.MVVM.Model
{
    class Skill
    {
        private string _skillName;
        private string _skillType;
        private List<double> _mainSkillDamage;
        private List<double> _raceSkillDamage;

        public Skill() { }

        public Skill(string skillName, string skillType, List<double> skillDamage)
        {
            SkillName = skillName;
            SkillType = skillType;
            MainSkillDamage = skillDamage;
        }

        public Skill(string skillName, string skillType, List<double> mainSkillDamage, List<double> raceSkillDamage)
        {
            SkillName = skillName;
            SkillType = skillType;
            MainSkillDamage = mainSkillDamage;
            RaceSkillDamage = raceSkillDamage;
        }

        public string SkillName 
        { 
            get { return this._skillName; } 
            set { this._skillName = value; } 
        }
        public string SkillType 
        { 
            get { return this._skillType; }
            set { this._skillType = value; }
        }
        public List<double> MainSkillDamage 
        {
            get { return this._mainSkillDamage; }
            set { this._mainSkillDamage = value; }
        }
        public List<double> RaceSkillDamage
        {
            get { return this._raceSkillDamage; }
            set { this._raceSkillDamage = value; }
        }
    }
}
