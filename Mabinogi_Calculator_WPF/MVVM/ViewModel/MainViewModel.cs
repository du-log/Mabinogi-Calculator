using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Mabinogi_Calculator_WPF.MVVM.Model;

namespace Mabinogi_Calculator_WPF.MVVM.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        //Skill Box
        private string _smashRank, _chargeRank, _assaultSlashRank, _bashRank, _windmillRank;
        private string _stampedeRank, _stompRank, _throwingAttackRank;
        private string _finalHitRank, _finalStrikeRank, _finalShotRank;
        private string _rageImpactRank;
        private string _lanceChargeRank, _lanceImpactRank;

        public List<string> SkillRankBox { get; }
        public List<string> DanSkillRankBox { get; }
        public Calculations Calc { get; }
        public CharacterInfoVM CharacterInfo { get; }
        public PrimaryStatsVM Primary { get; }
        public DefensiveStatsVM Defensive { get; }
        public OffensiveStatsVM Offensive { get; }

        public MainViewModel()
        {
            CharacterInfo = new CharacterInfoVM();
            Primary = new PrimaryStatsVM();
            Defensive = new DefensiveStatsVM();
            Offensive = new OffensiveStatsVM();
            Calc = new Calculations();
            SkillRankBox = new List<string>() { "F", "E", "D", "C", "B", "A", "9", "8", "7", "6", "5", "4", "3", "2", "1" };
            DanSkillRankBox = new List<string>() { "F", "E", "D", "C", "B", "A", "9", "8", "7", "6", "5", "4", "3", "2", "1", "D1", "D2", "D3" };

            Primary.PropertyChanged += (sender, e) =>
            {
                switch (e.PropertyName)
                {
                    case nameof(Primary.StrStat):
                        Defensive.BaseDefense = Calc.CalcBaseDefense(Primary.StrStat);
                        Offensive.MinimumDamage = Calc.CalcMinimumDamage(Primary.StrStat);
                        Offensive.MaximumDamage = Calc.CalcMaximumDamage(Primary.StrStat);
                        Offensive.Damage = $"{Offensive.MinimumDamage}~{Offensive.MaximumDamage}";
                        break;
                    case nameof(Primary.IntStat):
                        Defensive.BaseMagicProtection = Calc.CalcBaseMagicProtection(Primary.IntStat);
                        Offensive.BaseMagicAttack = Calc.CalcBaseMagicAttack(Primary.IntStat);
                        break;
                    case nameof(Primary.DexStat):
                        Offensive.ArmorPierce = Calc.CalcArmorPierce(Primary.DexStat);
                        Offensive.MinimumInjury = Calc.CalcMinimumInjury(Primary.DexStat, Primary.WillStat);
                        Offensive.MaximumInjury = Calc.CalcMaximumInjury(Primary.DexStat, Primary.WillStat);
                        Offensive.Injury = $"{Offensive.MinimumInjury}~{Offensive.MaximumInjury}";
                        break;
                    case nameof(Primary.WillStat):
                        Defensive.BaseMagicDefense = Calc.CalcBaseMagicDefense(Primary.WillStat);
                        Offensive.CriticalRate = Calc.CalcCriticalRate(Primary.WillStat, Primary.LuckStat);
                        Offensive.MinimumInjury = Calc.CalcMinimumInjury(Primary.DexStat, Primary.WillStat);
                        Offensive.MaximumInjury = Calc.CalcMaximumInjury(Primary.DexStat, Primary.WillStat);
                        Offensive.Injury = $"{Offensive.MinimumInjury}~{Offensive.MaximumInjury}";
                        break;
                    case nameof(Primary.LuckStat):
                        Offensive.CriticalRate = Calc.CalcCriticalRate(Primary.WillStat, Primary.LuckStat);
                        break;
                }
            };

            Offensive.PropertyChanged += (sender, e) =>
            {
                switch (e.PropertyName)
                {
                    case nameof(Offensive.BaseMagicAttack):
                        Offensive.ModMagicAttack = Offensive.BaseMagicAttack;
                        break;
                }
            };

            Defensive.PropertyChanged += (sender, e) =>
            {
                switch (e.PropertyName)
                {
                    case nameof(Defensive.BaseDefense):
                        Defensive.ModDefense = Defensive.BaseDefense;
                        break;
                    case nameof(Defensive.BaseMagicDefense):
                        Defensive.ModMagicDefense = Defensive.BaseMagicDefense;
                        break;
                    case nameof(Defensive.BaseMagicProtection):
                        Defensive.ModMagicProtection = Defensive.BaseMagicProtection;
                        break;
                }
            };

            InitializeDefaultValues();
        }

        private void InitializeDefaultValues()
        {
            CharacterInfo.CharacterName = "Omnicity+Alexina";
            CharacterInfo.SelectedRace = "Human";
            Primary.HPStat = 133;
            Primary.MPStat = 129;
            Primary.StamStat = 246;
            Primary.StrStat = 110;
            Primary.IntStat = 123;
            Primary.DexStat = 96;
            Primary.WillStat = 92;
            Primary.LuckStat = 80;
        }

        //Get-Set Skill Tab
        public string SmashRank
        {
            get { return _smashRank; }
            set
            {
                _smashRank = value;
                OnPropertyChanged(nameof(SmashRank));
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
                _lanceChargeRank = value;
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
