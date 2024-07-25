using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mabinogi_Calculator_WPF.MVVM.ViewModel
{
    internal class PrimaryStatsVM : ViewModelBase
    {
        private int _hpStat, _mpStat, _stamStat, _strStat, _intStat, _dexStat, _willStat, _luckStat;

        public int HPStat
        {
            get { return _hpStat; }
            set { SetField(ref _hpStat, value, nameof(HPStat)); }
        }
        public int MPStat
        {
            get { return _mpStat; }
            set { SetField(ref _mpStat, value, nameof(MPStat)); }
        }
        public int StamStat
        {
            get { return _stamStat; }
            set { SetField(ref _stamStat, value, nameof(StamStat)); }
        }
        public int StrStat
        {
            get { return _strStat; }
            set { SetField(ref _strStat, value, nameof(StrStat)); }
        }
        public int IntStat
        {
            get { return _intStat; }
            set { SetField(ref _intStat, value, nameof(IntStat)); }
        }
        public int DexStat
        {
            get { return _dexStat; }
            set { SetField(ref _dexStat, value, nameof(DexStat)); }
        }
        public int WillStat
        {
            get { return _willStat; }
            set { SetField(ref _willStat, value, nameof(WillStat)); }
        }
        public int LuckStat
        {
            get { return _luckStat; }
            set { SetField(ref _luckStat, value, nameof(LuckStat)); }
        }
    }
}
