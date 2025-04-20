using UnityEngine;


namespace Eloi.OVNI
{
    public class OVNIMono_BasicProjectile : MonoBehaviour {

        public Transform m_whatToMove;
        public float m_speed = 10f;
        public float m_lifeTime = 5f;
        public float m_countDown = 0f;
        public void Reset()
        {
            m_whatToMove = transform;
        }

        public void OnEnable()
        {
            m_countDown = m_lifeTime;
        }

        [ContextMenu("Destroy Now")]
        public void DestroyNow()
        {
            Destroy(m_whatToMove.gameObject);
        }
        public void Update()
        {
            m_countDown -= Time.deltaTime;
            if (m_countDown < 0f)
            {
                DestroyNow();
            }
            else
            {
                m_whatToMove.position += m_whatToMove.forward * m_speed * Time.deltaTime;
            }
        }
    }



}