using UnityEngine;
using UnityEngine.Events;

namespace Sebastien.QuickScript
{
    public class QuickRotationMono : MonoBehaviour
    {
        public Transform m_whatToRotation;
        public float m_globalSpeedRotation = 20;
        public Vector3 m_rotationAxis = Vector3.up;
        public Space m_space = Space.Self;

        // Update is called once per frame
        void Update()
        {
            float delaTime = Time.deltaTime;
            float result = delaTime * m_globalSpeedRotation;
            m_whatToRotation.Rotate(m_rotationAxis, result, m_space);
        }
    }
}

 