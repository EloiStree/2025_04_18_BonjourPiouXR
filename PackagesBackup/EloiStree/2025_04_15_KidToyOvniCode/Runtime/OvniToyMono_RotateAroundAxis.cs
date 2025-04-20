using UnityEngine;


namespace Eloi.OvniToy {
    public class OvniToyMono_RotateAroundAxis: MonoBehaviour
    {
        public Vector3 m_axis = Vector3.up;
        public float m_angleSpeedLeftToRightPerSeconds = 90;
        public bool m_inverse = false;
        public Space m_space = Space.Self;
        public Transform m_whatToRotate;

        private void Reset()
        {
            m_whatToRotate = transform;
        }

        public void SetRotationSpeed(float speed)
        {
            m_angleSpeedLeftToRightPerSeconds = speed;
        }
        public void SetInverse(bool inverse)
        {
            m_inverse = inverse;
        }
        private void Update()
        {
            m_whatToRotate.Rotate(m_axis, m_angleSpeedLeftToRightPerSeconds * Time.deltaTime *(m_inverse?-1:1) ,m_space);
        }
    }
}
