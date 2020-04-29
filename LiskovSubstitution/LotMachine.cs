using LiskovSubstitution.States;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution
{
    public class LotMachine
    {
        public int ItemCount { get; set; }

        public State NoCoinState { get; private set; }
        public State CoinInsertedState { get; private set; }
        public State CurrentState { get; set; }

        public LotMachine()
        {
            NoCoinState = new NoCoinsState(this);
            CoinInsertedState = new InsertedCoinState(this);
            CurrentState = NoCoinState;
        }

        public string InsertCoin() => CurrentState.InsertCoin();

        public string ReturnCoin() => CurrentState.ReturnCoin();

        public string Vend() => CurrentState.Vend();

        public string Refill(int qty)
        {
            ItemCount += qty;

            return string.Format("Items in the machine: {0}", ItemCount);
        }
    }
}
