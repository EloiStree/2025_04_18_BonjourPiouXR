using UnityEngine;
namespace Eloi.OvniToy
{
    /// <summary>
    /// I am a class that move the ovni toy from the player position.
    /// </summary>
    public class OvniToyMono_MoveFromPlayerPosition : MonoBehaviour
    {

        public Transform m_playerToObserver;
        public Transform m_ovniToMove;

        [Header("Speed in Seconds")]
        public float m_leftToRightSpeedPerSeconds = 1;
        public float m_downToUpSpeedPerSeconds = 1;
        public float m_backwardToForwardSpeedPerSeconds = 1;

        [Header("Percent to input")]
        [Range(-1,1)]
        public float m_leftToRightPercent = 0;
        [Range(-1, 1)]
        public float m_downToUpPercent = 0;
        [Range(-1, 1)]
        public float m_backwardToForwardPercent = 0;

        public float m_globalSpeedMultiplicator = 1;

        public bool m_useDebugLine = true;
        private void Reset()
        {
            m_playerToObserver = this.transform;
        }
        public void Update()
        {

            if (m_playerToObserver == null)
                m_playerToObserver = GameObject.FindWithTag("Player")?.transform;
            if ( m_playerToObserver== null)
                m_playerToObserver= Camera.main?.transform;


            if (m_playerToObserver == null)
                return;

            Vector3 directionForward = (m_ovniToMove.position - m_playerToObserver.position);
            // Let's flat the direction to the XZ plane
            directionForward.y = 0;
            // Let's have a 90 degree angles
            // Quaternion * Direction allow to make a new direction rotated by the angle
            Vector3 directionRight = Quaternion.Euler(0, 90, 0) * directionForward;
            directionForward.Normalize();
            directionRight.Normalize();



            Vector3 position= m_ovniToMove.position;
            float timeDelta = Time.deltaTime;
            position += directionRight *( m_leftToRightPercent * m_leftToRightSpeedPerSeconds * timeDelta* m_globalSpeedMultiplicator);
            position += Vector3.up * (m_downToUpPercent * m_downToUpSpeedPerSeconds * timeDelta * m_globalSpeedMultiplicator);
            position += directionForward * (m_backwardToForwardPercent * m_backwardToForwardSpeedPerSeconds * timeDelta * m_globalSpeedMultiplicator);



            if (m_useDebugLine) { 
                Debug.DrawLine(m_playerToObserver.position, m_ovniToMove.position, Color.yellow);
                Debug.DrawLine(m_ovniToMove.position, m_ovniToMove.position + directionForward, Color.blue);
                Debug.DrawLine(m_ovniToMove.position, m_ovniToMove.position + directionRight, Color.red);
                Debug.DrawLine(m_ovniToMove.position, m_ovniToMove.position + Vector3.up, Color.green);
            }

            m_ovniToMove.position = position;


        }


        public void SetLeftToRightPercent(float movePercentSpeed)
        {
            m_leftToRightPercent = movePercentSpeed;
        }
        public void SetDownToUpPercent(float movePercentSpeed)
        {
            m_downToUpPercent = movePercentSpeed;
        }
        public void SetBackwardToForwardPercent(float movePercentSpeed)
        {
            m_backwardToForwardPercent = movePercentSpeed;
        }

    }

}


