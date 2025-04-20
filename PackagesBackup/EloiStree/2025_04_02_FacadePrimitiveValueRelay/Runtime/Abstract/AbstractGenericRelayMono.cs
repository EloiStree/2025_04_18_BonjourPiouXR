using UnityEngine;
using UnityEngine.Events;


namespace Eloi.Relay
{
    public class AbstractGenericRelayMono<T> : MonoBehaviour    {
        public UnityEvent<T> m_onRelayed=new UnityEvent<T>();
        public T m_lastValueRelayed= default;

        [ContextMenu("Push from inspector")]
        public void PushInInspectorLastValue()
        {
            m_onRelayed.Invoke(m_lastValueRelayed);
        }
        public void PushIn(T value)
        {
            m_lastValueRelayed = value;
            m_onRelayed.Invoke(value);
            HandleDataToRelayInChildren(value);
        }
        public void GetLastValue(out T value)
        {
            value = m_lastValueRelayed;
        }
        public T GetLastValue()
        {
            return m_lastValueRelayed;
        }

        protected virtual void HandleDataToRelayInChildren(T dataToHandle) {

            // This method is virtual to be overridden in child classes
            // and can be used to handle the data before relaying it.
            // For example, you could modify the data or perform some validation here.
            // In this base class, we do nothing.

        }
    }






}

