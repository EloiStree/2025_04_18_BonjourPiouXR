using UnityEngine;

namespace Eloi.OVNI { 
public class OVNIMono_HelloRotation : MonoBehaviour
{
        public Transform m_whatToRotate;
        public Vector3 m_rotationAxis= Vector3.forward;
        public float m_rotationSpeed = 720;
    public bool m_inverse = false;
        public Space m_space = Space.Self;

        private void Reset()
        {
            m_whatToRotate= transform;
        }
        void Update()
        {
                transform.Rotate(m_rotationAxis,(m_inverse?-1f:1f) * m_rotationSpeed * Time.deltaTime, m_space);
       

        }
    //void Start()
    //{
    //    Debug.Log("Hello World");
    //}
    //private void OnEnable()
    //{

    //    Debug.Log("Tu me vois...");
    //}
    //private void OnDisable()
    //{

    //    Debug.Log("Tu me vois plus...");
    //}

  
}

}