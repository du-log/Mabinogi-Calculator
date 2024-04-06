using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mabinogi_Calculator_WPF.MVVM.Model;

namespace Mabinogi_Calculator_WPF.MVVM.ViewModel
{
    /*
     * View Model for controls relating to
     * Character Primary Stats, HP, MP, Stam, etc.
     */
    class StatVM : INotifyPropertyChanged
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

        public StatVM() 
        {
            StrStat = 148;
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
        //Event Handler
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            if (propertyName == nameof(StrStat))
            {
                double newBaseDefense = StrStat / 10;
                BaseDefense = (int)newBaseDefense;
            }
        }
    }
}
