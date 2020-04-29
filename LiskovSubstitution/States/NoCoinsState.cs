using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution.States
{
    public class NoCoinsState : State
    {
        public NoCoinsState(LotMachine machine)
            : base(machine)
        {
        }

        public override string InsertCoin()
        {
            Machine.CurrentState = Machine.CoinInsertedState;
            return "Coin inserted";
        }

        public override string ReturnCoin() => "No coin inserted! Cannot return!";

        public override string Vend() => "No coin inserted! You can't get anything for free!";
    }
}
