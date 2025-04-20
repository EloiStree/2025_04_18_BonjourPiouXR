using UnityEngine;
using UnityEngine.Events;

namespace Jorge.QuickScript {
    public class QuickRotateMono : MonoBehaviour
    {
        public Transform m_whatToRotate;
        public float m_globalspeedInAngle = 360;
        public Vector3 m_rotateAxis = Vector3.up;
        public Space m_space = Space.Self;

        void Update()
        {
            float deltaTime = Time.deltaTime;
            m_whatToRotate.Rotate(m_rotateAxis, 
            m_globalspeedInAngle * deltaTime, 
            m_space);
        }
    }
}
