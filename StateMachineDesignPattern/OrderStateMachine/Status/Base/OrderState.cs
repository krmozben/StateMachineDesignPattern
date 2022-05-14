using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineDesignPattern.OrderStateMachine.Status.Base
{
    abstract class OrderState
    {
        public abstract void OrderCreate();
        public abstract void StockReserve(int quantity);
        public abstract void Payment(int totalPrice);
    }
}
