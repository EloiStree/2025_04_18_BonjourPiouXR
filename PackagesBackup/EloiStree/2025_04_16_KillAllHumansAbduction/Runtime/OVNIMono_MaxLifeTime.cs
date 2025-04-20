using UnityEngine;


namespace Eloi.OVNI
{

public class OVNIMono_MaxLifeTime : MonoBehaviour
{
    public float m_maxLifeTime = 10f;
    public float m_countDown = 0f;
    public Transform m_whatToDestroy;

        public void OnEnable()
        {
            m_countDown = m_maxLifeTime;
        
        }
        public void Reset()
    {
        m_whatToDestroy = transform;
    }
    public void Update()
    {
        float count = m_countDown;
        m_countDown -= Time.deltaTime;
        if (m_countDown < 0f)
        {
            m_countDown = 0;

        }
        else if (m_countDown > 0f)
        {
            Destroy(m_whatToDestroy.gameObject);
        }
    }
}



}