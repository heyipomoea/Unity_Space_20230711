using UnityEngine;

namespace Heyipomoea.TwoD
{
    public class StateWander : State
    {
        public override State RunCurrentState()
        {
            return this;
        }
    }
}

