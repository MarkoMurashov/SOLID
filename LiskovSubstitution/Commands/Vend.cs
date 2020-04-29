using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace LiskovSubstitution.Commands
{
    public class Vend : ICommand
    {
        private LotMachineManager machineManger;
        public Vend(LotMachineManager lm)
        {
            machineManger = lm;
        }

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object parameter) => true;
        public void Execute(object parameter) => machineManger.Vend();
    }
}
