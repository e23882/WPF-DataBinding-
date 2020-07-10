using System;
using System.Windows.Input;

namespace WPFApp.SampleCase.Command
{
    public class RelayCommand : ICommand
    {
        #region Declarations
        private readonly Action<object> _execute;
        public event EventHandler CanExecuteChanged;

        #endregion
        
        #region Memberfunction
        public RelayCommand(Action<object> execute)
        {
            this._execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this._execute.Invoke(parameter);
        }
        #endregion
    }
}
