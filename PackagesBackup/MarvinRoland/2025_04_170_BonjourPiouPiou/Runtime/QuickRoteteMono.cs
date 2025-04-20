using UnityEngine;

namespace Roland.QuickScrpit { 
public class QuickRoteteMono : MonoBehaviour
{
    public Transform m_whatToRotale;
    public float m_globalSpeedInAngle;
    public Vector3 m_rotateAxis = Vector3.up;
    public Space m_space = Space.Self;

    // Update is called once per frame
    void Update()
    {
        float deltaTime = Time.deltaTime;

        transform.Rotate(m_rotateAxis, m_globalSpeedInAngle * deltaTime, m_space);
    }
    }
}
