using StateMachineDesignPattern.OrderStateMachine.Status.Base;

namespace StateMachineDesignPattern.OrderStateMachine.Status;

class OrderFailed : OrderState
{
    OrderMachine _context;
    public OrderFailed(OrderMachine context)
        => this._context = context;

    public override void OrderCreate()
        => Console.WriteLine("Sipariş başarısız sonuçlandı...");
    public override void Payment(int totalPrice)
        => Console.WriteLine("Sipariş başarısız sonuçlandı...");
    public override void StockReserve(int quantit)
        => Console.WriteLine("Sipariş başarısız sonuçlandı...");
}
