using LiskovSubstitution.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace LiskovSubstitution
{
    public class LotMachineManager : INotifyPropertyChanged
    {
        private LotMachine machine;

        private string console;

        private ICommand vendCommand;

        private ICommand returnCoinCommand;

        private ICommand insertCoinCommand;

        private ICommand refillCommand;

        public event PropertyChangedEventHandler PropertyChanged;


        public string Console
        {
            get { return console; }
            set
            {
                console = value;
                OnPropertyChanged(nameof(Console));
            }
        }

        public int ItemCount => machine.ItemCount;

        public LotMachineManager()
        {
            machine = new LotMachine();
            machine.ItemCount = 5;
            Console += "Lot machine";
        }

        public void Refill()
        {
            Console += "\n" + machine.Refill(10);
            OnPropertyChanged(nameof(ItemCount));
        }

        public void InsertCoin() => Console += "\n" + machine.InsertCoin();

        public void ReturnCoin() => Console += "\n" + machine.ReturnCoin();

        public void Vend()
        {
            Console += "\n" + machine.Vend();
            OnPropertyChanged(nameof(ItemCount));
        }

        public ICommand RefillCommand
        {
            get
            {
                refillCommand = refillCommand == null ? new Commands.Refill(this) : refillCommand;

                return refillCommand;
            }
        }

        public ICommand InsertCoinCommand
        {
            get
            {
                insertCoinCommand = insertCoinCommand == null ? new InsertionCoin(this) : insertCoinCommand;

                return insertCoinCommand;
            }
        }

        public ICommand ReturnCoinCommand
        {
            get
            {
                returnCoinCommand = returnCoinCommand == null ? new ReturnCoin(this) : returnCoinCommand;

                return returnCoinCommand;
            }
        }

        public ICommand VendCommand
        {
            get
            {
                vendCommand = vendCommand == null ? new Vend(this) : vendCommand;

                return vendCommand;
            }
        }


        private void OnPropertyChanged(params string[] propertiesChanged)
        {
            if (PropertyChanged != null)
            {
                foreach (string property in propertiesChanged)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(property));
                }
            }
        }
    }
}
