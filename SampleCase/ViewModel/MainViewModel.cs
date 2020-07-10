using System.Windows;
using System.Windows.Input;
using WPFApp.Advanced.Command;

namespace WPFApp.SampleCase.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        #region Declarations
        private string _InputValue = string.Empty;
        private string _OutputValue = string.Empty;
        #endregion

        #region Property
        public ICommand ButtonClick
        {
            get { return new RelayCommand(ButtonClickCommandAction); }
        }

        public string InputValue
        {
            get
            {
                return _InputValue;
            }
            set
            {
                _InputValue = value;
                OutputValue = value;
                OnPropertyChanged();
            }
        }

        public string OutputValue
        {
            get
            {
                return $"Input is : {_OutputValue}";
            }
            set
            {
                _OutputValue = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Memberfunction
        private void ButtonClickCommandAction(object parameter)
        {
            MessageBox.Show("Button Click");
        }
        #endregion
    }
}
