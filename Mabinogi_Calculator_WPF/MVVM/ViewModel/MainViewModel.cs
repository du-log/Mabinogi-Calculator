using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Mabinogi_Calculator_WPF.MVVM.Model;

namespace Mabinogi_Calculator_WPF.MVVM.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        //Primary Stats
        private int _hpStat;
        private int _mpStat;
        private int _stamStat;
        private int _strStat;
        private int _intStat;
        private int _dexStat;
        private int _willStat;
        private int _luckStat;
        //Defensive Stats
        private int _baseDefense;
        private int _modDefense;
        private int _baseProtection;
        private int _modProtection;
        private int _baseMagicDefense;
        private int _modMagicDefense;
        private int _baseMagicProtection;
        private int _modMagicProtection;
        //Character Info
        private int _currentLevel;
        private int _totalLevel;
        private string _selectedRace;
        private string _characterName;
        //Offensive Stats
        private int _minimumDamage;
        private int _maximumDamage;
        private string _damage;
        private int _baseMagicAttack;
        private int _modMagicAttack;
        private int _minimumInjury;
        private int _maximumInjury;
        private string _injury;
        private double _criticalRate;
        private int _balance;
        private int _armorPierce;

        public List<int> CurrentLevels { get; }
        public List<string> Race { get; }

        public Calculations calc { get; }

        public MainViewModel()
        {
            calc = new Calculations();
            //Populate Current Level ComboBox
            CurrentLevels = new List<int>();
            for (int i = 1; i <= 200; i++)
            {
                CurrentLevels.Add(i);
            }
            //Populate Race ComboBox
            Race = new List<string>() { "Human", "Elf", "Giant" };

            //Defaults
            CharacterName = "Omnicity";
            CurrentLevel = 1;
            TotalLevel = 8774;
            SelectedRace = "Human";
            HPStat = 133;
            MPStat = 129;
            StamStat = 246;
            StrStat = 110;
            IntStat = 123;
            DexStat = 96;
            WillStat = 92;
            LuckStat = 80;
        }
        //Get-Set Primary Stats
        public int HPStat
        {
            get { return _hpStat; }
            set
            {
                _hpStat = value;
                OnPropertyChanged(nameof(HPStat));
            }
        }
        public int MPStat
        {
            get { return _mpStat; }
            set
            {
                _mpStat = value;
                OnPropertyChanged(nameof(MPStat));
            }
        }
        public int StamStat
        {
            get { return _stamStat; }
            set
            {
                _stamStat = value;
                OnPropertyChanged(nameof(StamStat));
            }
        }
        public int StrStat
        {
            get { return _strStat; }
            set
            {
                _strStat = value;
                OnPropertyChanged(nameof(StrStat));
            }
        }
        public int IntStat
        {
            get { return _intStat; }
            set
            {
                _intStat = value;
                OnPropertyChanged(nameof(IntStat));
            }
        }
        public int DexStat
        {
            get { return _dexStat; }
            set
            {
                _dexStat = value;
                OnPropertyChanged(nameof(DexStat));
            }
        }
        public int WillStat
        {
            get { return _willStat; }
            set
            {
                _willStat = value;
                OnPropertyChanged(nameof(WillStat));
            }
        }
        public int LuckStat
        {
            get { return _luckStat; }
            set
            {
                _luckStat = value;
                OnPropertyChanged(nameof(LuckStat));
            }
        }

        //Get-Set Defensive Stats
        public int BaseDefense
        {
            get { return _baseDefense; }
            set
            {
                _baseDefense = value;
                OnPropertyChanged(nameof(BaseDefense));
            }
        }
        public int ModDefense
        {
            get { return _modDefense; }
            set
            {
                _modDefense = value;
                OnPropertyChanged(nameof(ModDefense));
            }
        }
        public int BaseProtection
        {
            get { return _baseProtection; }
            set
            {
                _baseProtection = value;
                OnPropertyChanged(nameof(BaseProtection));
            }
        }
        public int ModProtection
        {
            get { return _modProtection; }
            set
            {
                _modProtection = value;
                OnPropertyChanged(nameof(ModProtection));
            }
        }
        public int BaseMagicDefense
        {
            get { return _baseMagicDefense; }
            set
            {
                _baseMagicDefense = value;
                OnPropertyChanged(nameof(BaseMagicDefense));
            }
        }
        public int ModMagicDefense
        {
            get { return _modMagicDefense; }
            set
            {
                _modMagicDefense = value;
                OnPropertyChanged(nameof(ModMagicDefense));
            }
        }
        public int BaseMagicProtection
        {
            get { return _baseMagicProtection; }
            set
            {
                _baseMagicProtection = value;
                OnPropertyChanged(nameof(BaseMagicProtection));
            }
        }
        public int ModMagicProtection
        {
            get { return _modMagicProtection; }
            set
            {
                _modMagicProtection = value;
                OnPropertyChanged(nameof(ModMagicProtection));
            }
        }

        //Get-Set Character Info
        public int CurrentLevel
        {
            get { return _currentLevel; }
            set
            {
                _currentLevel = value;
                OnPropertyChanged(nameof(CurrentLevel));
            }
        }
        public int TotalLevel
        {
            get { return _totalLevel; }
            set
            {
                _totalLevel = value;
                OnPropertyChanged(nameof(TotalLevel));
            }
        }
        public string SelectedRace
        {
            get { return _selectedRace; }
            set
            {
                _selectedRace = value;
                OnPropertyChanged(nameof(SelectedRace));
            }
        }
        public string CharacterName
        {
            get { return _characterName; }
            set
            {
                _characterName = value;
                OnPropertyChanged(nameof(CharacterName));
            }
        }

        //Get-Set Offensive Stats - No Alchemy
        public int MinimumDamage
        {
            get { return _minimumDamage; }
            set
            {
                _minimumDamage = value;
                OnPropertyChanged(nameof(MinimumDamage));
            }
        }
        public int MaximumDamage
        {
            get { return _maximumDamage; }
            set
            {
                _maximumDamage = value;
                OnPropertyChanged(nameof(MaximumDamage));
            }
        }
        public string Damage
        {
            get { return _damage; }
            set
            {
                _damage = value;
                OnPropertyChanged(nameof(Damage));
            }
        }
        public int BaseMagicAttack
        {
            get { return _baseMagicAttack; }
            set
            {
                _baseMagicAttack = value;
                OnPropertyChanged(nameof(BaseMagicAttack));
            }
        }
        public int ModMagicAttack
        {
            get { return _modMagicAttack; }
            set
            {
                _modMagicAttack = value;
                OnPropertyChanged(nameof(ModMagicAttack));
            }
        }
        public int MinimumInjury
        {
            get { return _minimumInjury; }
            set
            {
                _minimumInjury = value;
                OnPropertyChanged(nameof(MinimumInjury));
            }
        }
        public int MaximumInjury
        {
            get { return _maximumInjury; }
            set
            {
                _maximumInjury = value;
                OnPropertyChanged(nameof(MaximumInjury));
            }
        }
        public string Injury
        {
            get { return _injury; }
            set
            {
                _injury = value;
                OnPropertyChanged(nameof(Injury));
            }
        }
        public double CriticalRate
        {
            get { return _criticalRate; }
            set
            {
                _criticalRate = value;
                OnPropertyChanged(nameof(CriticalRate));
            }
        }
        public int Balance
        {
            get { return _balance; }
            set
            {
                _balance = value;
                OnPropertyChanged(nameof(Balance));
            }
        }
        public int ArmorPierce
        {
            get { return _armorPierce; }
            set
            {
                _armorPierce = value;
                OnPropertyChanged(nameof(ArmorPierce));
            }
        }

        //Get-Set Placeholder

        //Event Handler
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            //Base Defense
            if (propertyName == nameof(StrStat))
            {
                BaseDefense = calc.CalcBaseDefense(StrStat);
            }
            //Mod Defense
            if (propertyName == nameof(BaseDefense))
            {
                ModDefense = BaseDefense;
            }

            //Base Magic Attack, Base Magic Protection
            if (propertyName == nameof(IntStat))
            {
                BaseMagicProtection = calc.CalcBaseMagicProtection(IntStat);
                BaseMagicAttack = calc.CalcBaseMagicAttack(IntStat);
            }
            //Mod Magic Attack
            if (propertyName == nameof(BaseMagicAttack))
            {
                ModMagicAttack = BaseMagicAttack;
            }
            //Mod Magic Protection
            if (propertyName == nameof(BaseMagicProtection))
            {
                ModMagicProtection = BaseMagicProtection;
            }

            //Base Magic Defense
            if (propertyName == nameof(WillStat))
            {
                BaseMagicDefense = calc.CalcBaseMagicDefense(WillStat);
            }
            //Mod Magic Defense
            if (propertyName == nameof(BaseMagicDefense))
            {
                ModMagicDefense = BaseMagicDefense;
            }

            //Damage
            if (propertyName == nameof(StrStat))
            {
                MinimumDamage = calc.CalcMinimumDamage(StrStat);
                MaximumDamage = calc.CalcMaximumDamage(StrStat);
                Damage = MinimumDamage + "~" + MaximumDamage;
            }
            //Critical
            if (propertyName == nameof(WillStat) || propertyName == nameof(LuckStat))
            {
                CriticalRate = calc.CalcCriticalRate(WillStat, LuckStat);
            }
            //Injury
            if (propertyName == nameof(DexStat) || propertyName == nameof(WillStat))
            {
                MinimumInjury = calc.CalcMinimumInjury(DexStat, WillStat);
                MaximumInjury = calc.CalcMaximumInjury(DexStat, WillStat);
                Injury = MinimumInjury + ".0~" + MaximumInjury + ".0%";
            }
            //Armor Pierce
            if (propertyName == nameof(DexStat))
            {
                ArmorPierce = calc.CalcArmorPierce(DexStat);
            }
        }
    }
}
