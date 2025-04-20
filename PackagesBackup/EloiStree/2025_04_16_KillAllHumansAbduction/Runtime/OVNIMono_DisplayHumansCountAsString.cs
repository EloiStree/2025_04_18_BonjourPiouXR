
using Eloi.OVNI;
using UnityEngine;
using UnityEngine.Events;

public class OVNIMono_DisplayHumansCountAsString : MonoBehaviour
{
    public UnityEvent<int> m_onHumanAliveCountRefresh;
    public UnityEvent<string> m_onHumanAliveCountRefreshAsString;
    public UnityEvent<int> m_onHumanDeathCountRefresh;
    public UnityEvent<string> m_onHumanDeathCountRefreshAsString;
    public UnityEvent<int> m_onHumanTotalCountRefresh;
    public UnityEvent<string> m_onHumanTotalCountRefreshAsString;
    public int m_aliveCount;
    public int m_deathCount;
    public int m_totalCount;

    public float m_refreshRate = 1f;

    public void Awake()
    {
        InvokeRepeating(nameof(Refresh), 0, m_refreshRate);
    }
    public void Refresh()
    {
       m_aliveCount = OVNIMono_KillTheHuman.GetAliveCount();
       m_deathCount = OVNIMono_KillTheHuman.GetDeathCount();
       m_totalCount = OVNIMono_KillTheHuman.GetTotalCount();
        m_onHumanAliveCountRefresh?.Invoke(m_aliveCount);
        m_onHumanAliveCountRefreshAsString?.Invoke(m_aliveCount.ToString());
        m_onHumanDeathCountRefresh?.Invoke(m_deathCount);
        m_onHumanDeathCountRefreshAsString?.Invoke(m_deathCount.ToString());
        m_onHumanTotalCountRefresh?.Invoke(m_totalCount);
        m_onHumanTotalCountRefreshAsString?.Invoke(m_totalCount.ToString());


    }
}
