using UnityEngine;
using UnityEngine.Events;

namespace Robert.QuickScrit { 


public class QuickRotateMono : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform m_WhatToRotate;
    public float m_globalSpeedInAngle = 360;
    public Vector3 m_rotateAxis = Vector3.forward; 
    public Space m_Space = Space.Self;  

 
    // Update is called once per frame
    void Update()
    {
        float deltaTime = Time.deltaTime;
        m_WhatToRotate.Rotate(m_rotateAxis,m_globalSpeedInAngle * deltaTime,m_Space);
    }
}

}