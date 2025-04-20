using UnityEngine;
using UnityEngine.Events;


namespace Eloi.Relay
{
    public class AbstractGenericStringRelayMono<T>: MonoBehaviour
    {
        public UnityEvent<string> m_onRelayed = new UnityEvent<string>();
        public T m_lastRelayed=default;
        public string m_format = "{0}";
        public string m_lastValueRelayed = "";


        public void PushInInspectorLastValue()
        {
            PushIn(m_lastRelayed);
        }

        private string GetValueAsString()
        {
            return string.Format(m_format, m_lastValueRelayed);
        }

        public void PushIn(T value)
        {
            string t = GetValueAsString();
            m_lastValueRelayed = t;
            m_onRelayed.Invoke(t);
        }
        public void GetLastValue(out string value)
        {
            value = GetValueAsString();
        }
        public string GetLastValue()
        {
            return GetValueAsString();
        }

    }






}

