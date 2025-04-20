using UnityEngine;
using UnityEngine.Events;


namespace Eloi.KillAllHumans {

    public class OVNIMono_OnTouchEnterAction : MonoBehaviour
    {
        public LayerMask m_allowsCollision=~1;
        public UnityEvent m_onTouchAction;




        public void OnCollisionEnter(Collision collision)
        {
            if (m_allowsCollision == (m_allowsCollision | (1 << collision.gameObject.layer)))
            {
                m_onTouchAction.Invoke();
            }
        }

        public void OnTriggerEnter(Collider other)
        {
            if (m_allowsCollision == (m_allowsCollision | (1 << other.gameObject.layer)))
            {
                m_onTouchAction.Invoke();
            }
        }
    }

}