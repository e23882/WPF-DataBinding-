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
    class MainViewModel : WPFApp.ViewModel.ViewModelBase
    {
        #region Declarations
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
    }
}
