using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mabinogi_Calculator_WPF.MVVM.ViewModel
{
    internal class OffensiveStatsVM : ViewModelBase
    {
        private int _minimumDamage, _maximumDamage;
        private string _damage = "";
        private string _injury = "";
        private int _baseMagicAttack, _modMagicAttack;
        private int _minimumInjury, _maximumInjury;
        private double _criticalRate;
        private int _balance, _armorPierce;

        public int MinimumDamage
        {
            get { return _minimumDamage; }
            set { SetField(ref _minimumDamage, value, nameof(MinimumDamage)); }
        }
        public int MaximumDamage
        {
            get { return _maximumDamage; }
            set { SetField(ref _maximumDamage, value, nameof(MaximumDamage)); }
        }
        public string Damage
        {
            get { return _damage; }
            set { SetField(ref _damage, value, nameof(Damage)); }
        }
        public int BaseMagicAttack
        {
            get { return _baseMagicAttack; }
            set { SetField(ref _baseMagicAttack, value, nameof(BaseMagicAttack)); }
        }
        public int ModMagicAttack
        {
            get { return _modMagicAttack; }
            set { SetField(ref _modMagicAttack, value, nameof(ModMagicAttack)); }
        }
        public int MinimumInjury
        {
            get { return _minimumInjury; }
            set { SetField(ref _minimumInjury, value, nameof(MinimumInjury)); }
        }
        public int MaximumInjury
        {
            get { return _maximumInjury; }
            set { SetField(ref _maximumInjury, value, nameof(MaximumInjury)); }
        }
        public string Injury
        {
            get { return _injury; }
            set { SetField(ref _injury, value, nameof(Injury)); }
        }
        public double CriticalRate
        {
            get { return _criticalRate; }
            set { SetField(ref _criticalRate, value, nameof(CriticalRate)); }
        }
        public int Balance
        {
            get { return _balance; }
            set { SetField(ref _balance, value, nameof(Balance)); }
        }
        public int ArmorPierce
        {
            get { return _armorPierce; }
            set { SetField(ref _armorPierce, value, nameof(ArmorPierce)); }
        }
    }
}
