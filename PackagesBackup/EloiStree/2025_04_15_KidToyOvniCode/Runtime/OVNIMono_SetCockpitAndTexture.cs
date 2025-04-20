using UnityEngine;

public class OVNIMono_SetCockpitAndTexture : MonoBehaviour
{


    public Transform m_whereToCreate;
    public float m_localScale = 1;
    public Renderer[] m_bodyRenderer;


    public void SetTexture2D(Texture2D texture)
    {
        if (m_bodyRenderer != null)
        {
            foreach (var rend in m_bodyRenderer)
            {
                if (rend != null)
                {
                    rend.material.mainTexture = texture;
                }
            }
        }
    }

    public GameObject m_createdInstance;
    public void SetCockPit(GameObject prefab)
    {

        if (m_whereToCreate != null && prefab != null)
        {
            if (m_createdInstance != null)
            {
                if (Application.isEditor)
                    DestroyImmediate(m_createdInstance);
                else
                    Destroy(m_createdInstance);
            }
            GameObject instance = Instantiate(prefab, m_whereToCreate);
            instance.transform.SetParent(m_whereToCreate, false);
            instance.transform.localScale = Vector3.one * m_localScale;
            instance.transform.localPosition = Vector3.zero;
            instance.transform.localRotation = Quaternion.identity;
            m_createdInstance = instance;
        }
    }
}