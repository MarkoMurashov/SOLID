using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution.States
{
    public class InsertedCoinState : State
    {
        public InsertedCoinState(LotMachine machine)
            : base(machine)
        {
        }

        public override string InsertCoin() => "Cannot insert more than one coin!";

        public override string ReturnCoin()
        {
            Machine.CurrentState = Machine.NoCoinState;
            return "Coin returned.";
        }

        public override string Vend()
        {
            if (Machine.ItemCount > 0)
            {
                Machine.ItemCount--;
                Machine.CurrentState = Machine.NoCoinState;
                return "An item has been vended.";
            }
            else
            {
                return "No more items in the machine. Please refill!";
            }
        }
    }
}
