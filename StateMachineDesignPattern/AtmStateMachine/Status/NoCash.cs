using StateMachineDesignPattern.AtmStateMachine.Status.Base;

namespace StateMachineDesignPattern.AtmStateMachine.Status;

class NoCash : ATMState
{
    public override void EjectCard(ATMMachine context)
     => Console.WriteLine("Para yok para :)");
    public override void InsertCard(ATMMachine context)
        => Console.WriteLine("Para yok para :)");
    public override void InsertPin(int pinEntered, ATMMachine context)
        => Console.WriteLine("Para yok para :)");
    public override void RequestCash(int cashToWithdraw, ATMMachine context)
        => Console.WriteLine("Para yok para :)");
}