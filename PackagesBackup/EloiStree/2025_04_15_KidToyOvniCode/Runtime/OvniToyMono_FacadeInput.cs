using UnityEngine;
using UnityEngine.Events;


namespace Eloi.OvniToy { 

    /// <summary>
    /// I am a clas that make the abstraction between outside code and inside code.
    /// </summary>
    

    public class OvniToyMono_FacadeInput : MonoBehaviour
{
    [Range(-1,1)]
    public float m_moveLeftToRightPercent;
    [Range(-1, 1)]
    public float m_moveDownToUpPercent;
    [Range(-1, 1)]
    public float m_moveBackwardToForwardPercent;

    public bool m_useAbductionRay = false;
        public bool m_useValidateForDebug = true;
    
    public UnityEvent<float> m_onMoveLeftToRightPercent;
    public UnityEvent<float> m_onMoveDownToUpPercent;
    public UnityEvent<float> m_onMoveBackwardToForwardPercent;
    public UnityEvent<bool> m_onAbductionRay;


        public void OnValidate()
        {
            if (m_useValidateForDebug)
            {
                SetMoveLeftToRightPercent(m_moveLeftToRightPercent);
                SetMoveDownToUpPercent(m_moveDownToUpPercent);
                SetMoveBackwardToForwardPercent(m_moveBackwardToForwardPercent);
                SetAbductionRay(m_useAbductionRay);
            }
        }
        public void SetMoveLeftToRightPercent(float percent)
    {
        m_moveLeftToRightPercent = percent;
        m_onMoveLeftToRightPercent?.Invoke(percent);
    }
    public void SetMoveDownToUpPercent(float percent)
    {
        m_moveDownToUpPercent = percent;
        m_onMoveDownToUpPercent?.Invoke(percent);
    }
    public void SetMoveBackwardToForwardPercent(float percent)
    {
        m_moveBackwardToForwardPercent = percent;
        m_onMoveBackwardToForwardPercent?.Invoke(percent);
    }
    public void SetAbductionRay(bool isOn)
    {
        m_useAbductionRay = isOn;
        m_onAbductionRay?.Invoke(isOn);
    }

    [ContextMenu("Set Random Move Value")]
    public void SetRandomMoveValue()
    {
        SetMoveLeftToRightPercent(Random.Range(-1.0f, 1.0f));
        SetMoveDownToUpPercent(Random.Range(-1.0f, 1.0f));
        SetMoveBackwardToForwardPercent(Random.Range(-1.0f, 1.0f));
     }
    [ContextMenu("Reset Value to Default")]
    public void ResetValueToDefault()
    {
        SetMoveLeftToRightPercent(0);
        SetMoveDownToUpPercent(0);
        SetMoveBackwardToForwardPercent(0);
        SetAbductionRay(false);
    }
}
}
