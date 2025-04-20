using UnityEngine;

namespace Max.QuickScript
{
    public class QuickRotateMono : MonoBehaviour
    {
        public Transform m_whatToRotate;
        public Transform m_rotateTorus;
        public float m_globalSpeedInAngle = 360;
        public Vector3 m_rotateAxis = Vector3.up;
        public Vector3 m_rotateAxisTorus;
        public Space m_space;

        void Update()
        {
            float _delta = Time.deltaTime;
            m_whatToRotate.Rotate(m_rotateAxis, m_globalSpeedInAngle * _delta, m_space);
            m_rotateTorus.Rotate(m_rotateAxisTorus, m_globalSpeedInAngle * _delta, m_space);
        }
    }
}
