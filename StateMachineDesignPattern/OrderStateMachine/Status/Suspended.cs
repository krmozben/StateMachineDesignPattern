using StateMachineDesignPattern.OrderStateMachine.Status.Base;

namespace StateMachineDesignPattern.OrderStateMachine.Status;

class Suspended : OrderState
{
    OrderMachine _context;
    public Suspended(OrderMachine context)
        => this._context = context;

    public override void OrderCreate()
        => Console.WriteLine("Sipariş zaten oluşturuldu...");
    public override void Payment(int totalPrice)
        => Console.WriteLine("Stok güncellenmeden ödeme yapılamaz!");
    public override void StockReserve(int quantit)
    {
        if (quantit > _context.Stock)
        {
            Console.WriteLine("Sipariş edilmek istenen ürün miktarı, stok miktarından fazladır!");
            _context.SetOrderCanceled();
            Console.WriteLine("Sipariş iptal edilmiştir.");
        }
        else
        {
            Console.WriteLine("Sipariş edilen ürün miktarı kadar stok başarıyla güncellenmiştir.");
            _context.SetStockReserved();
            Console.WriteLine($"Kalan stok miktarı : {_context.Stock - quantit}");
        }
    }
}
