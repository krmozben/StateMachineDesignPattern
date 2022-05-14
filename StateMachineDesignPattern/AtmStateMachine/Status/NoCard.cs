using StateMachineDesignPattern.AtmStateMachine.Status.Base;

namespace StateMachineDesignPattern.AtmStateMachine.Status;

class NoCard : ATMState
{
    public override void EjectCard(ATMMachine context)
        => Console.WriteLine("Lütfen önce kartı takınız.");
    public override void InsertCard(ATMMachine context)
    {
        Console.WriteLine("Lütfen pin giriniz.");
        context.State = new HasCard();
    }
    public override void InsertPin(int pin, ATMMachine context)
        => Console.WriteLine("Lütfen önce kartı takınız.");
    public override void RequestCash(int cashToWithdraw, ATMMachine context)
        => Console.WriteLine("Lütfen önce kartı takınız.");
}