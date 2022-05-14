using StateMachineDesignPattern.OrderStateMachine.Status.Base;

namespace StateMachineDesignPattern.OrderStateMachine.Status;

class OrderCompleted : OrderState
{
    OrderMachine _context;
    public OrderCompleted(OrderMachine context)
        => this._context = context;

    public override void OrderCreate()
        => Console.WriteLine("Sipariş zaten başarıyla tamamlandı...");
    public override void Payment(int totalPrice)
        => Console.WriteLine("Sipariş zaten başarıyla tamamlandı...");
    public override void StockReserve(int quantit)
        => Console.WriteLine("Sipariş zaten başarıyla tamamlandı...");
}
