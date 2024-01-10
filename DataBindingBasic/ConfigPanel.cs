using System.ComponentModel;

namespace DataBindingBasic
{
    public class ConfigPanel(int volume, string name) : INotifyPropertyChanged
    {
        private int volume = volume;
        public int Volume {
            get { return volume; }
            set {
                volume = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Volume)));
            }
        }

        private string name = name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
