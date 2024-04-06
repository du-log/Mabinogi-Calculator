using System.ComponentModel;

namespace Mabinogi_Calculator_WPF.MVVM.ViewModel
{
    /*
     * View Model for controls relating to
     * character level, race and name.
     */
    class CharacterVM : INotifyPropertyChanged
    {
        private int _currentLevel;
        private int _totalLevel;
        private string _selectedRace;
        private string _characterName;

        public List<int> CurrentLevels { get; }
        public List<string> Race { get; }

        public CharacterVM()
        {
            //Populate Current Level ComboBox
            CurrentLevels = new List<int>();
            for (int i = 1; i <= 200; i++)
            {
                CurrentLevels.Add(i);
            }
            //Populate Race ComboBox
            Race = new List<string>() { "Human", "Elf", "Giant" };

            //Default ComboBox Selection
            CharacterName = "";
            CurrentLevel = CurrentLevels.FirstOrDefault();
            TotalLevel = 40000;
            SelectedRace = Race.FirstOrDefault();
        }
        //Get-Set
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
        //Event Handler
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
