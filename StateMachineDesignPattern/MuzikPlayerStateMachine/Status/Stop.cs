using StateMachineDesignPattern.MuzikPlayerStateMachine;
using StateMachineDesignPattern.MuzikPlayerStateMachine.Status.Base;

class Stop : MusicPlayerState
{
    MusicPlayerMachine _context;
    public Stop(MusicPlayerMachine context)
        => _context = context;

    public override void PlayMusic()
    {
        Console.WriteLine("Müzik başlatılmıştır.");
        _context.SetPlay();
    }
    public override void StopMusic()
        => Console.WriteLine("Zaten müzik durmaktadır!");
}
