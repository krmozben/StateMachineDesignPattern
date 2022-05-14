using StateMachineDesignPattern.MuzikPlayerStateMachine.Status.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineDesignPattern.MuzikPlayerStateMachine.Status
{
    class Play : MusicPlayerState
    {
        MusicPlayerMachine _context;
        public Play(MusicPlayerMachine context)
            => _context = context;

        public override void PlayMusic()
            => Console.WriteLine("Zaten müzik çalmaktadır!");
        public override void StopMusic()
        {
            Console.WriteLine("Müzik durdurulmuştur.");
            _context.SetStop();
        }
    }
}
