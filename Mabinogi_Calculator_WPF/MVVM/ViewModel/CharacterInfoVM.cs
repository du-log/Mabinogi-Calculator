using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mabinogi_Calculator_WPF.MVVM.ViewModel
{
    internal class CharacterInfoVM : ViewModelBase
    {
        private string _selectedRace = "";
        private string _characterName = "";

        public List<string> Race { get; }

        public CharacterInfoVM()
        {
            Race = new List<string>() { "Human", "Elf", "Giant" };
        }

        public string SelectedRace
        {
            get { return _selectedRace; }
            set { SetField(ref _selectedRace, value, nameof(SelectedRace)); }
        }
        public string CharacterName
        {
            get { return _characterName; }
            set { SetField(ref _characterName, value, nameof(CharacterName)); }
        }
    }
}
