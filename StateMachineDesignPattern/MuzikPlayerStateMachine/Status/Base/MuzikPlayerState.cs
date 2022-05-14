using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineDesignPattern.MuzikPlayerStateMachine.Status.Base
{
    abstract class MusicPlayerState
    {
        public abstract void PlayMusic();
        public abstract void StopMusic();
    }
}
