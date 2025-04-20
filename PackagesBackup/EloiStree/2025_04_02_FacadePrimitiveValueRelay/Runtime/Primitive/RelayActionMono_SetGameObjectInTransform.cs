using UnityEngine;


namespace Eloi.Relay
{
    public class RelayActionMono_SetGameObjectInTransform : MonoBehaviour {

        public Transform m_whereToCreate;
        public GameObject m_createdInstance;
        public float m_localScale = 1;
        public void PushIn(GameObject prefab) {

            if (m_whereToCreate != null && prefab != null)
            {
                if (m_createdInstance != null)
                {
                    if( Application.isEditor)
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

   
}

