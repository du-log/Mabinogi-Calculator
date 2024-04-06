using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mabinogi_Calculator_WPF.MVVM.Model;

namespace Mabinogi_Calculator_WPF.MVVM.ViewModel
{
    class DefensiveVM : INotifyPropertyChanged
    {

        private int _baseDefense;
        private int _modDefense;
        private int _baseProtection;
        private int _modProtection;
        private int _baseMagicDefense;
        private int _modMagicDefense;
        private int _baseMagicProtection;
        private int _modMagicProtection;

        public DefensiveVM() 
        {
        }

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
            get { return _modMagicDefense;  }
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
        }
    }
}
