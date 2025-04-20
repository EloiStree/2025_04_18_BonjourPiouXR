using UnityEngine;

namespace Eloi.OVNI
{
    public class OVNIMono_ClassicDrone : MonoBehaviour
    {
        public Transform m_whatToMove;

        [Header("Speed")]
        public float m_allDirectionSpeed = 0.5f;
        public float m_speedRotation = 180f;

        [Header("Percent Input")]
        [Range(-1, 1)]
        public float m_pourcentToMoveFront = 0;
        [Range(-1, 1)]
        public float m_pourcentToMoveRight = 0;
        [Range(-1, 1)]
        public float m_pourcentToMoveUp = 0;

        [Range(-1, 1)]
        public float m_pourcentToRotationRotation = 0;

        private void Reset()
        {
            m_whatToMove = transform;
        }


        public void SetWithTwoJoysticks(Vector2 joystickLeft, Vector2 joystickRight)
        {
            m_pourcentToMoveFront = joystickRight.y;
            m_pourcentToMoveRight = joystickRight.x;
            m_pourcentToMoveUp = joystickLeft.y;
            m_pourcentToRotationRotation = joystickLeft.x;
        }

        public void SetWithVectorLeft(Vector2 joystick) {

            m_pourcentToRotationRotation = joystick.x;
            m_pourcentToMoveUp = joystick.y;
        }

        public void SetWithVectorRight(Vector2 joystick)
        {
            m_pourcentToMoveFront = joystick.y;
            m_pourcentToMoveRight = joystick.x;
        }
        public void SetMoveLeftToRight(float percent)
        {
            m_pourcentToMoveRight = percent;
        }

        public void SetMoveDownToUp(float percent) {

            m_pourcentToMoveUp = percent;
        }
        public void SetMoveBackToFront(float percent)
        {
            m_pourcentToMoveFront = percent;
        }
        public void SetRotationLeftToRight(float percent)
        {
            m_pourcentToRotationRotation = percent;
        }
        public void SetAllDirectionSpeed(float speed)
        {
            m_allDirectionSpeed = speed;
        }

        public void SetSpeedRotationInDegree(float speedInDegree)
        {
            m_speedRotation = speedInDegree;
        }


        void Update()
        {
            float delta = Time.deltaTime;

            m_whatToMove.Translate(
                Vector3.forward *
                delta *
                m_allDirectionSpeed *
                m_pourcentToMoveFront
                , Space.Self);
            m_whatToMove.Translate(
                Vector3.up *
                delta *
                m_allDirectionSpeed *
                m_pourcentToMoveUp
                , Space.Self);
            m_whatToMove.Translate(
                Vector3.right *
                delta *
                m_allDirectionSpeed *
                m_pourcentToMoveRight
                , Space.Self);

            m_whatToMove.Rotate(0,
                m_speedRotation *
                delta *
                m_pourcentToRotationRotation
                , 0,
                Space.Self);
        }
    }

}