using UnityEngine;
using UnityEngine.Events;


namespace Eloi.Relay
{
    public class RelayMono_Percent01OnValidate : MonoBehaviour{ 
    
        [Range(0, 1)]
        public float m_percentAsDouble = 0;
        public UnityEvent<float> m_onRelayedPercent01 = new UnityEvent<float>();
        public bool m_useValidate=true;
        public bool m_disableWhenPlaying = true;
        void OnValidate()
        {
            if (Application.isPlaying && m_disableWhenPlaying)
                return;
            if (!m_useValidate)
                return;
            m_onRelayedPercent01.Invoke(m_percentAsDouble);
        }
    }

}

