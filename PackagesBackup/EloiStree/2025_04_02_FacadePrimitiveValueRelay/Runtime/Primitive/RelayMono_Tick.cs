using UnityEngine;
using UnityEngine.Events;


namespace Eloi.Relay
{
    public class RelayMono_Tick : MonoBehaviour {

        public UnityEvent m_onTick = new UnityEvent();

        [ContextMenu("Invoke Relay Event Tick")]
        public void Tick()
        {
            m_onTick?.Invoke();
        }
    }
}

