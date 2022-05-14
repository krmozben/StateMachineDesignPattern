using StateMachineDesignPattern.OrderStateMachine.Status.Base;

namespace StateMachineDesignPattern.OrderStateMachine.Status;

class StockReserved : OrderState
{
    OrderMachine _context;
    public StockReserved(OrderMachine context)
        => this._context = context;

    public override void OrderCreate()
        => Console.WriteLine("Sipariş zaten oluşturuldu...");
    public override void Payment(int totalPrice)
    {
        if (totalPrice < 1500)
        {
            Console.WriteLine("Ödeme başarıyla gerçekleştirildi...");
            _context.SetOrderCompleted();
        }
        else
        {
            Console.WriteLine("Yetersiz bakiye!");
            _context.SetOrderFailed();
        }
    }
    public override void StockReserve(int quantit)
        => Console.WriteLine("Stok bilgisi zaten güncelleştirildi...");
}