using StateMachineDesignPattern.AtmStateMachine.Status.Base;
using StateMachineDesignPattern.AtmStateMachine.Status;

class ATMMachine
{
    ATMState state = new NoCard();
    public ATMState State { set => state = value; }
    /// <summary>
    /// CashInMachine : ATM'de ki peşin parayı ifade eder.
    /// </summary>
    public int CashInMachine { get; set; } = 2000;
    /// <summary>
    /// CorrectPinEntered : Pin'in girilip girilmediğini kontrol eder.
    /// </summary>
    public bool CorrectPinEntered { get; set; } = false;
    public void InsertCard()
        => state.InsertCard(this);
    public void EjectCard()
        => state.EjectCard(this);
    public void InsertPin(int pin)
        => state.InsertPin(pin, this);
    public void RequestCash(int cashToWithdraw)
        => state.RequestCash(cashToWithdraw, this);
}
