using StateMachineDesignPattern.AtmStateMachine.Status.Base;

namespace StateMachineDesignPattern.AtmStateMachine.Status;

class HasCard : ATMState
{
    public override void EjectCard(ATMMachine context)
    {
        Console.WriteLine("Kart çıkarılmıştır.");
        context.State = new NoCard();
    }
    public override void InsertCard(ATMMachine context)
        => Console.WriteLine("Aynı anda birden fazla kart takamazsınız!");
    public override void InsertPin(int pin, ATMMachine context)
    {
        if (pin == 123)
        {
            Console.WriteLine("Pin doğrulandı!");
            context.CorrectPinEntered = true;
            context.State = new HasPin();
        }
        else
        {
            Console.WriteLine("Geçersiz pin girildi!");
            context.CorrectPinEntered = false;
            Console.WriteLine("Kart çıkarılmıştır.");
            context.State = new NoCard();
        }
    }
    public override void RequestCash(int cashToWithdraw, ATMMachine context)
        => Console.WriteLine("Lütfen önce pini giriniz.");
}