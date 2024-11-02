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
        public List<string> SkillRankBox { get; }
        public List<string> DanSkillRankBox { get; }
        public Calculations Calc { get; }
        public CharacterInfoVM CharacterInfo { get; }
        public PrimaryStatsVM Primary { get; }
        public DefensiveStatsVM Defensive { get; }
        public OffensiveStatsVM Offensive { get; }
        public SkillsVM Skills { get; }

        public MainViewModel()
        {
            CharacterInfo = new CharacterInfoVM();
            Primary = new PrimaryStatsVM();
            Defensive = new DefensiveStatsVM();
            Offensive = new OffensiveStatsVM();
            Skills = new SkillsVM();
            Calc = new Calculations();

            Primary.PropertyChanged += (sender, e) =>
            {
                switch (e.PropertyName)
                {
                    case nameof(Primary.StrStat):
                        Defensive.BaseDefense = Calc.CalcBaseDefense(Primary.StrStat);
                        Offensive.MinimumDamage = Calc.CalcMinimumDamage(Primary.StrStat);
                        Offensive.MaximumDamage = Calc.CalcMaximumDamage(Primary.StrStat);
                        Offensive.Damage = $"{Offensive.MinimumDamage}~{Offensive.MaximumDamage}";
                        Skills.SmashMinDmg = Calc.CalcSmashMinDamage(CharacterInfo.SelectedRace, Skills.SmashRank, Offensive.MinimumDamage, Skills.SkillList);
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

            Skills.PropertyChanged += (sender, e) =>
            {
                switch (e.PropertyName)
                {
                    case nameof(Skills.SmashRank):
                        Skills.SmashMinDmg = Calc.CalcSmashMinDamage(CharacterInfo.SelectedRace, Skills.SmashRank, Offensive.MinimumDamage, Skills.SkillList);
                        break;
                }
            };

            CharacterInfo.PropertyChanged += (sender, e) =>
            {
                switch (e.PropertyName)
                {
                    case nameof(CharacterInfo.SelectedRace):
                        Skills.SmashMinDmg = Calc.CalcSmashMinDamage(CharacterInfo.SelectedRace, Skills.SmashRank, Offensive.MinimumDamage, Skills.SkillList);
                        break;
                }
            };

            InitializeDefaultValues();
            SetSkillRanksToF();
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
        private void SetSkillRanksToF()
        {
            Skills.SmashRank = "F";
            Skills.ChargeRank = "F";
            Skills.AssaultSlashRank = "F";
            Skills.BashRank = "F";
            Skills.WindmillRank = "F";
            Skills.ThrowingAttackRank = "F";
            Skills.StampedeRank = "F";
            Skills.FinalHitRank = "F";
            Skills.FinalStrikeRank = "F";
            Skills.FinalShotRank = "F";
            Skills.RageImpactRank = "F";
            Skills.LanceChargeRank = "F";
            Skills.LanceImpactRank = "F";
            Skills.StompRank = "F";
        }
    }
}
