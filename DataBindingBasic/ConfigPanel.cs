using System.ComponentModel;

namespace DataBindingBasic
{
    public class ConfigPanel(int volume) : INotifyPropertyChanged
    {
        private int volume = volume;
        public int Volume {
            get { return volume; }
            set {
                volume = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Volume)));
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
