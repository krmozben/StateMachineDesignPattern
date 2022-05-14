using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineDesignPattern.AtmStateMachine.Status.Base
{
    abstract class ATMState
    {
        public abstract void InsertCard(ATMMachine context);
        public abstract void EjectCard(ATMMachine context);
        public abstract void InsertPin(int pin, ATMMachine context);
        public abstract void RequestCash(int cashToWithdraw, ATMMachine context);
    }
}
