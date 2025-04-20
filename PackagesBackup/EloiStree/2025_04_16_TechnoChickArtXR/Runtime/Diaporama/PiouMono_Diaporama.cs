using UnityEngine;

public class PiouMono_Diaporama : MonoBehaviour
{

    public GameObject[] m_whatToDisplay;
    public int m_index = 0;


    [ContextMenu("Next")]
    public void DisplayNext() {

        m_index++;
        if (m_index>= m_whatToDisplay.Length)
            m_index = 0;

        foreach (GameObject go in m_whatToDisplay)
            go.SetActive(false);

        if (m_whatToDisplay.Length > 0)
            m_whatToDisplay[m_index].SetActive(true);
    }

    [ContextMenu("Previous")]
    public void DisplayPrevious() { 

        m_index--;
        if(m_index<0)   
            m_index = m_whatToDisplay.Length-1;

        foreach (GameObject go in m_whatToDisplay)
            go.SetActive(false);

        if(m_whatToDisplay.Length>0)
            m_whatToDisplay[m_index].SetActive(true);

    }
}
