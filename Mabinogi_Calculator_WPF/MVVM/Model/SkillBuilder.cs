using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mabinogi_Calculator_WPF.MVVM.Model
{
    internal class SkillBuilder
    {
        public List<Skill> AddSkills()
        {
            SkillBuilder builder = new();
            List<Skill> TempList = [builder.HESmash(), builder.GSmash()];
            return TempList;
        }
        private Skill HESmash()
        {
            Dictionary<string, double> RankValues = new Dictionary<string, double>
            {
                { "F", 2.0 },
                { "E", 2.1 },
                { "D", 2.2 },
                { "C", 2.3 },
                { "B", 2.4 },
                { "A", 2.5 },
                { "9", 3.0 },
                { "8", 3.1 },
                { "7", 3.2 },
                { "6", 3.3 },
                { "5", 4.0 },
                { "4", 4.2 },
                { "3", 4.4 },
                { "2", 4.6 },
                { "1", 5.0 },
                { "D1", 5.4 },
                { "D2", 5.8 },
                { "D3", 8.0 }
            };
            return new Skill("Smash", "HE", RankValues);
        }
        private Skill GSmash()
        {
            Dictionary<string, double> RankValues = new Dictionary<string, double>
            {
                { "F", 3.0 },
                { "E", 3.1 },
                { "D", 3.2 },
                { "C", 3.3 },
                { "B", 3.4 },
                { "A", 3.5 },
                { "9", 4.0 },
                { "8", 4.1 },
                { "7", 4.2 },
                { "6", 4.3 },
                { "5", 5.0 },
                { "4", 5.2 },
                { "3", 5.4 },
                { "2", 5.6 },
                { "1", 6.0 },
                { "D1", 6.4 },
                { "D2", 8.0 },
                { "D3", 9.0 }
            };
            return new Skill("Smash", "G", RankValues);
        }
    }
}
