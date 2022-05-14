using StateMachineDesignPattern.OrderStateMachine.Status.Base;

namespace StateMachineDesignPattern.OrderStateMachine.Status;

class NoOrder : OrderState
{
    OrderMachine _context;
    public NoOrder(OrderMachine context)
        => this._context = context;

    public override void OrderCreate()
    {
        Console.WriteLine("Sipariş oluşturuldu.");
        _context.SetSuspended();
    }
    public override void Payment(int totalPrice)
        => Console.WriteLine("Sişarip oluşturmadan ödeme yapılamaz!");
    public override void StockReserve(int quantit)
        => Console.WriteLine("Sipariş oluşturmadan stok güncellenemez!");
}
