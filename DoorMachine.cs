using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tpmod4_103022300062
{
    class DoorMachine
    {
        public enum DoorState { terkunci, tidak_terkunci };
        public enum Trigger { Membuka_Pintu, Mengunci_Pintu };

        class transition
        {
            public DoorState prevState;
            public DoorState nextState;
            public Trigger trigger;

            public transition(DoorState prevState, DoorState nextState, Trigger trigger)
            {
                this.prevState = prevState;
                this.nextState = nextState;
                this.trigger = trigger;
            }
        }

        transition[] transitions = 
            {
                new transition(DoorState.terkunci, DoorState.tidak_terkunci, Trigger.Membuka_Pintu),
                new transition(DoorState.tidak_terkunci, DoorState.terkunci, Trigger.Mengunci_Pintu)
            };

        public DoorState currentState;

        public DoorState getNextState(DoorState prevState, Trigger trigger)
        {
            DoorState nextState = prevState;
                for (int i = 0; i < transitions.Length; i++)
                {
                    if (transitions[i].prevState == prevState && transitions[i].trigger == trigger)
                        nextState = transitions[i].nextState;
                }
                return nextState;
            }
        public void activateTrigger(Trigger trigger)
        {
            DoorState nextState = getNextState(currentState, trigger);
            currentState = nextState;
        }
    }
}
