using System;
using System.Windows.Input;

namespace WPFApp.Advanced.Command
{
    public class RelayCommand : ICommand
    {
        #region Declarations
        private readonly Action<object> _execute;
        #endregion

        #region Property
        #endregion

        #region Memberfunction
        #endregion

        public RelayCommand(Action<object> execute)
        {
            this._execute = execute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this._execute.Invoke(parameter);
        }
    }
}
