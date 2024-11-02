using Mabinogi_Calculator_WPF.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mabinogi_Calculator_WPF.MVVM.ViewModel
{
    internal class SkillsVM : ViewModelBase
    {
        private string _smashRank, _chargeRank, _assaultSlashRank, _bashRank, _windmillRank;
        private string _stampedeRank, _stompRank, _throwingAttackRank;
        private string _finalHitRank, _finalStrikeRank, _finalShotRank;
        private string _rageImpactRank;
        private string _lanceChargeRank, _lanceImpactRank;

        private int _smashMinDmg;

        SkillBuilder skillbuilder = new();

        public List<string> SkillRankBox { get; }
        public List<string> DanSkillRankBox { get; }
        public List<Skill> SkillList { get; }

        public SkillsVM()
        {
            SkillRankBox = new List<string>() { "F", "E", "D", "C", "B", "A", "9", "8", "7", "6", "5", "4", "3", "2", "1" };
            DanSkillRankBox = new List<string>() { "F", "E", "D", "C", "B", "A", "9", "8", "7", "6", "5", "4", "3", "2", "1", "D1", "D2", "D3" };
            SkillList = skillbuilder.AddSkills();
        }

        public string SmashRank
        {
            get { return _smashRank; }
            set
            {
                _smashRank = value;
                OnPropertyChanged(nameof(SmashRank));
            }
        }
        public int SmashMinDmg
        {
            get { return _smashMinDmg; }
            set 
            { 
                _smashMinDmg = value;
                OnPropertyChanged(nameof(SmashMinDmg));
            }
        }
        public string ChargeRank
        {
            get { return _chargeRank; }
            set
            {
                _chargeRank = value;
                OnPropertyChanged(nameof(ChargeRank));
            }
        }
        public string AssaultSlashRank
        {
            get { return _assaultSlashRank; }
            set
            {
                _assaultSlashRank = value;
                OnPropertyChanged(nameof(AssaultSlashRank));
            }
        }
        public string BashRank
        {
            get { return _bashRank; }
            set
            {
                _bashRank = value;
                OnPropertyChanged(nameof(BashRank));
            }
        }
        public string WindmillRank
        {
            get { return _windmillRank; }
            set
            {
                _windmillRank = value;
                OnPropertyChanged(nameof(WindmillRank));
            }
        }
        public string ThrowingAttackRank
        {
            get { return _throwingAttackRank; }
            set
            {
                _throwingAttackRank = value;
                OnPropertyChanged(nameof(ThrowingAttackRank));
            }
        }
        public string StampedeRank
        {
            get { return _stampedeRank; }
            set
            {
                _stampedeRank = value;
                OnPropertyChanged(nameof(StampedeRank));
            }
        }
        public string FinalHitRank
        {
            get { return _finalHitRank; }
            set
            {
                _finalHitRank = value;
                OnPropertyChanged(nameof(FinalHitRank));
            }
        }
        public string FinalStrikeRank
        {
            get { return _finalStrikeRank; }
            set
            {
                _finalStrikeRank = value;
                OnPropertyChanged(nameof(FinalStrikeRank));
            }
        }
        public string FinalShotRank
        {
            get { return _finalShotRank; }
            set
            {
                _finalShotRank = value;
                OnPropertyChanged(nameof(FinalShotRank));
            }
        }
        public string RageImpactRank
        {
            get { return _rageImpactRank; }
            set
            {
                _rageImpactRank = value;
                OnPropertyChanged(nameof(RageImpactRank));
            }
        }
        public string LanceChargeRank
        {
            get { return _lanceChargeRank; }
            set
            {
                _lanceChargeRank = value;
                OnPropertyChanged(nameof(LanceChargeRank));
            }
        }
        public string LanceImpactRank
        {
            get { return _lanceImpactRank; }
            set
            {
                _lanceImpactRank = value;
                OnPropertyChanged(nameof(LanceImpactRank));
            }
        }
        public string StompRank
        {
            get { return _stompRank; }
            set
            {
                _stompRank = value;
                OnPropertyChanged(nameof(StompRank));
            }
        }
    }
}
