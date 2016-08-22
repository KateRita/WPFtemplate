using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfTemplateApp.ViewModel
{
    class RelayCommand : ICommand
    {
        private Action methodToExecute;
        private Func<bool> canExecuteEvaluator;
        public RelayCommand(Action methodToExecute, Func<bool> canExecuteEvaluator)
        {
            this.methodToExecute = methodToExecute;
            this.canExecuteEvaluator = canExecuteEvaluator;
        }

        public RelayCommand(Action methodToExecute)
            : this(methodToExecute, null)
        {
        }

        public bool CanExecute(object parameter)
        {
            if (this.canExecuteEvaluator == null)
            {
                return true;
            }
            else
            {
                bool result = this.canExecuteEvaluator.Invoke();
                return result;
            }
        }

        public void Execute(object parameter)
        {
            this.methodToExecute.Invoke();
        }

        public event EventHandler CanExecuteChanged;

        /*
        //Usage Pattern
        private RelayCommand _myCommand;
        public RelayCommand MyCommand
        {
            get
            {
                //can use lambdas here too, ie. for one line of code
                return _myCommand ?? (_myCommand = new RelayCommand(ActionFunction, CanActionFunction));
            }

        }
        */
    }
}
