using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution.States
{
    public abstract class State
    {
        protected LotMachine Machine;

        public State(LotMachine machine)
        {
            Machine = machine;
        }

        public abstract string InsertCoin();
        public abstract string ReturnCoin();
        public abstract string Vend();
    }
}
