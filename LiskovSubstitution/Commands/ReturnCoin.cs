﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace LiskovSubstitution.Commands
{
    public class ReturnCoin : ICommand
    {
        private LotMachineManager machineManager;
        public ReturnCoin(LotMachineManager lm)
        {
            machineManager = lm;
        }

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter) => machineManager.ReturnCoin();
    }
}
