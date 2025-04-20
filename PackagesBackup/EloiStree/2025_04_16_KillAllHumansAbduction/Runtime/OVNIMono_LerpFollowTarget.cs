using UnityEngine;

namespace Eloi.OVNI { 
public class OVNIMono_LerpFollowTarget : MonoBehaviour
{

    public Transform m_whatToFollow;
    public Transform m_WhatToMove;
        public bool m_lookForPlayerIfNull = true;

        public float m_lerpRotatePercent = 2;

        public float m_lerpMovePercent = 2;

        private void Reset()
        {
            m_WhatToMove = transform;
        }
        public void Update()
    {
            if (m_lookForPlayerIfNull && m_whatToFollow == null)
            {
                m_whatToFollow = GameObject.FindGameObjectWithTag("Player")?.transform;
          
            }
            if (m_whatToFollow != null && m_WhatToMove != null)
        {
            Vector3 targetPosition = m_whatToFollow.position;
            Vector3 currentPosition = m_WhatToMove.position;
            Vector3 newPosition = Vector3.Lerp(currentPosition, targetPosition, m_lerpMovePercent * Time.deltaTime);
                Quaternion targetRotation = m_whatToFollow.rotation;
                Quaternion currentRotation = m_WhatToMove.rotation;
                Quaternion newRotation = Quaternion.Lerp(currentRotation, targetRotation, m_lerpRotatePercent * Time.deltaTime);
                m_WhatToMove.rotation = newRotation;
                m_WhatToMove.position = newPosition;
        }
    }
}

}