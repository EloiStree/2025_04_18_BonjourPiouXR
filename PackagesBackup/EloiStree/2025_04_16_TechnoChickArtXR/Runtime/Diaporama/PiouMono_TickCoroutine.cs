using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class PiouMono_TickCoroutine : MonoBehaviour
{

    public float m_timeBetweenTick;
    public UnityEvent m_onTick;
    private void OnEnable()
    {
        StartCoroutine(TickLoop());
    }

    private IEnumerator TickLoop()
    {
        while (true) {
            yield return new WaitForEndOfFrame();
            yield return new WaitForSeconds(m_timeBetweenTick);
            m_onTick.Invoke();
        }
    }
}
