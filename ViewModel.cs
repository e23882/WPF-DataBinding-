using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp
{
    class ViewModel : INotifyPropertyChanged
    {
        #region Declarations
        public event PropertyChangedEventHandler PropertyChanged;
        private bool _IsChecked = true;
        private string _Content = "Default Text";
        #endregion

        #region Property
        public bool IsChecked
        {
            get
            {
                return _IsChecked;
            }
            set
            {
                _IsChecked = value;
                OnPropertyChanged();
            }
        }

        public string Content
        {
            get
            {
                return _Content;
            }
            set
            {
                _Content = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Memberfunction
        public void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
