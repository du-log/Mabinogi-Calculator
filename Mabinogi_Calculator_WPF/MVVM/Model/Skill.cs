using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mabinogi_Calculator_WPF.MVVM.Model
{
    public class Skill
    {
        private string _skillName;
        private string _skillRace;
        private Dictionary<string, double> _skillRankDamage;

        public Skill() { }

        public Skill(string skillName, string skillRace, Dictionary<string, double> RankDamage)
        {
            SkillName = skillName;
            SkillRace = skillRace;
            SkillRankDamage = RankDamage;
        }

        public string SkillName 
        { 
            get { return this._skillName; } 
            set { this._skillName = value; } 
        }
        public string SkillRace
        {
            get { return this._skillRace; }
            set { this._skillRace = value; }
        }
        public Dictionary<string, double> SkillRankDamage
        {   get { return this._skillRankDamage; } 
            set { this._skillRankDamage = value; }
        }
    }
}
