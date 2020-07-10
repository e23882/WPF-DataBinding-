using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPFApp
{
    public class ViewModel : INotifyPropertyChanged
    {
        #region Declarations
        private bool _IsChecked = true;
        private string _Content = "Default Text";
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Property
        public bool IsChecked
        {
            get
            {
                return this._IsChecked;
            }
            set
            {
                this._IsChecked = value;
                this.OnPropertyChanged();
            }
        }

        public string Content
        {
            get
            {
                return this._Content;
            }
            set
            {
                this._Content = value;
                this.OnPropertyChanged();
            }
        }
        #endregion

        #region Memberfunction
        public void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
