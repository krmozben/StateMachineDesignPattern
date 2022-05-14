using StateMachineDesignPattern.OrderStateMachine.Status;
using StateMachineDesignPattern.OrderStateMachine.Status.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineDesignPattern.OrderStateMachine
{
    class OrderMachine
    {
        OrderState state;
        OrderState noOrder;
        OrderState suspend;
        OrderState stockReserve;
        OrderState payment;
        OrderState orderCompleted;
        OrderState orderFailed;
        OrderState orderCanceled;
        public OrderMachine()
        {
            noOrder = new NoOrder(this);
            suspend = new Suspended(this);
            stockReserve = new StockReserved(this);
            orderCompleted = new OrderCompleted(this);
            orderFailed = new OrderFailed(this);
            orderCanceled = new OrderCanceled(this);

            state = noOrder;
        }

        public int Stock { get; set; } = 1000;

        public void SetNoOrder()
            => state = noOrder;
        public void SetSuspended()
            => state = suspend;
        public void SetStockReserved()
            => state = stockReserve;
        public void SetOrderCompleted()
            => state = orderCompleted;
        public void SetOrderFailed()
            => state = orderFailed;
        public void SetOrderCanceled()
            => state = orderCanceled;

        public void OrderCreate()
            => state.OrderCreate();
        public void StockReserve(int quantit)
            => state.StockReserve(quantit);
        public void Payment(int totalPrice)
            => state.Payment(totalPrice);
    }
}