using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mabinogi_Calculator_WPF.MVVM.ViewModel
{
    internal class DefensiveStatsVM : ViewModelBase
    {
        private int _baseDefense, _modDefense;
        private int _baseProtection, _modProtection;
        private int _baseMagicDefense, _modMagicDefense;
        private int _baseMagicProtection, _modMagicProtection;

        public int BaseDefense
        {
            get { return _baseDefense; }
            set { SetField(ref _baseDefense, value, nameof(BaseDefense)); }
        }
        public int ModDefense
        {
            get { return _modDefense; }
            set { SetField(ref _modDefense, value, nameof(ModDefense)); }
        }
        public int BaseProtection
        {
            get { return _baseProtection; }
            set { SetField(ref _baseProtection, value, nameof(BaseProtection)); }
        }
        public int ModProtection
        {
            get { return _modProtection; }
            set { SetField(ref _modProtection, value, nameof(ModProtection)); }
        }
        public int BaseMagicDefense
        {
            get { return _baseMagicDefense; }
            set { SetField(ref _baseMagicDefense, value, nameof(BaseMagicDefense)); }
        }
        public int ModMagicDefense
        {
            get { return _modMagicDefense; }
            set { SetField(ref _modMagicDefense, value, nameof(ModMagicDefense));}
        }
        public int BaseMagicProtection
        {
            get { return _baseMagicProtection; }
            set { SetField(ref _baseMagicProtection, value, nameof(BaseMagicProtection)); }
        }
        public int ModMagicProtection
        {
            get { return _modMagicProtection; }
            set { SetField(ref _modMagicProtection, value, nameof(ModMagicProtection)); }
        }
    }
}
