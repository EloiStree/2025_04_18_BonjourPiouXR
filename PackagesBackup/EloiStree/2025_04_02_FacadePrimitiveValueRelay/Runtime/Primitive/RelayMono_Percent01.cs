using UnityEngine;
using UnityEngine.Events;


namespace Eloi.Relay
{
    public class RelayMono_Percent01: MonoBehaviour {

        public UnityEvent<float> m_onRelayedPercentAsPercent = new UnityEvent<float>();
        public UnityEvent<double> m_onRelayedPercentAsDouble = new UnityEvent<double>();
        public UnityEvent<int> m_onRelayedPercentAsInteger100 = new UnityEvent<int>();

        public double m_percentAsDouble = 0;
        [Range(0,1)]
        public float m_percentAsFloat = 0;
        public int m_percentAsInteger100 = 0;

        [ContextMenu("Push from inspector double")]
        public void PushInFromInspectorDouble()
        {
            PushIn(m_percentAsDouble);
        }

        public void PushIn(float percent01)
        {
            percent01 = Mathf.Clamp01(percent01);
            m_percentAsFloat = percent01;
            m_percentAsDouble = percent01;
            m_percentAsInteger100 = (int)(percent01 * 100);
            m_onRelayedPercentAsPercent.Invoke(percent01);
            m_onRelayedPercentAsDouble.Invoke(percent01);
            m_onRelayedPercentAsInteger100.Invoke((int)(percent01 * 100));
        }
        public void PushIn(double percent01)
        {
            if (percent01 < 0.0)
                percent01 = 0.0;
            if (percent01 > 1.0)
                percent01 = 1.0;
            m_percentAsFloat = (float)percent01;
            m_percentAsDouble = percent01;
            m_percentAsInteger100 = (int)(percent01 * 100);
            m_onRelayedPercentAsPercent.Invoke((float)percent01);
            m_onRelayedPercentAsDouble.Invoke(percent01);
            m_onRelayedPercentAsInteger100.Invoke((int)(percent01 * 100));
        }
        public void PushIn(int percent100)
        {
            if ( percent100<0)
                percent100 = 0;

            if (percent100 > 100)
                percent100 = 100;

            m_percentAsFloat = percent100 / 100f;
            m_percentAsDouble = percent100 / 100d;
            m_percentAsInteger100 = percent100;
            m_onRelayedPercentAsPercent.Invoke(percent100 / 100f);
            m_onRelayedPercentAsDouble.Invoke(percent100 / 100d);
            m_onRelayedPercentAsInteger100.Invoke(percent100);
        }

    }

}

