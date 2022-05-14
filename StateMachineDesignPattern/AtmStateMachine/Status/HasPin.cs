using StateMachineDesignPattern.AtmStateMachine.Status.Base;

namespace StateMachineDesignPattern.AtmStateMachine.Status;

class HasPin : ATMState
{
    public override void EjectCard(ATMMachine context)
    {
        Console.WriteLine("Kart çıkarılmıştır.");
        context.State = new NoCard();
    }
    public override void InsertCard(ATMMachine context)
        => Console.WriteLine("Aynı anda birden fazla kart takamazsınız!");
    public override void InsertPin(int pin, ATMMachine context)
        => Console.WriteLine("Doğrulanmış bir pin zaten girilmiştir.");
    public override void RequestCash(int cashToWithdraw, ATMMachine context)
    {
        if (cashToWithdraw > context.CashInMachine)
        {
            Console.WriteLine("Çekmek istenen tutar adil bedeli aşmaktadır.");
            Console.WriteLine("Kart çıkarılmıştır.");
            context.State = new NoCard();
        }
        else
        {
            Console.WriteLine($"{cashToWithdraw} tutarında para çekilmiştir.");
            context.CashInMachine -= cashToWithdraw; //ATM'de ki para güncelleniyor.
            Console.WriteLine("Kart çıkarılmıştır.");
            context.State = new NoCard();
            Console.WriteLine($"ATM'de kalan para : {context.CashInMachine}");

            if (context.CashInMachine <= 0)
                context.State = new NoCash();
        }
    }
}