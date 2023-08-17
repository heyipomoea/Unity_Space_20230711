using UnityEngine;

namespace Heyipomoea.TwoD
{
    public class StateTrack : State
    {
        public override State RunCurrentState()
        {
            return this;
        }
    }
}

