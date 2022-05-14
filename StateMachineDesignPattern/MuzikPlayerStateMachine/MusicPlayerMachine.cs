using StateMachineDesignPattern.MuzikPlayerStateMachine.Status;
using StateMachineDesignPattern.MuzikPlayerStateMachine.Status.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineDesignPattern.MuzikPlayerStateMachine
{
    class MusicPlayerMachine
    {
        MusicPlayerState state;
        MusicPlayerState play;
        MusicPlayerState stop;
        public MusicPlayerMachine()
        {
            play = new Play(this);
            stop = new Stop(this);
            state = play;
        }

        public void SetPlay()
            => state = play;
        public void SetStop()
            => state = stop;

        public void Play()
            => state.PlayMusic();
        public void Stop()
            => state.StopMusic();
    }
}
