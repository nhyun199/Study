using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Attributes
{
    internal class LegoStore : INotifyPropertyChanged
    {
        public int StarwarsTotal
        {
            get => _starwarsTotal;

            set
            {
                _starwarsTotal = value;
                OnPropertyChanged();
            }
        }
        private int _starwarsTotal;


        public int CityTotal
        {
            get => _cityTotal;

            set
            {
                _cityTotal = value;
                OnPropertyChanged();
            }
        }
        private int _cityTotal;


        public int CreatorTotal
        {
            get => _creatorTotal;

            set
            {
                _creatorTotal = value;
                OnPropertyChanged();
            }
        }
        private int _creatorTotal;

        // Property가 바뀐 사건을 처리하는 대리자
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = default)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
