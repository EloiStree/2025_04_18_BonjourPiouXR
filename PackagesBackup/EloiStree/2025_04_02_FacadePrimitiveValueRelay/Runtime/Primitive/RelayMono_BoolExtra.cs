using UnityEngine.Events;

namespace Eloi.Relay
{
    public class RelayMono_BoolExtra : AbstractGenericRelayMono<bool>
    {


        public UnityEvent m_onRelayIsTrue;
        public UnityEvent m_onRelayIsFalse;
        public UnityEvent<bool> m_onRelayInverseValue;

        protected override void HandleDataToRelayInChildren(bool dataToHandle)
        {
            if (dataToHandle)
            {
                m_onRelayIsTrue.Invoke();
            }
            else
            {
                m_onRelayIsFalse.Invoke();
            }
            m_onRelayInverseValue.Invoke(!dataToHandle);
        }

    }





}

