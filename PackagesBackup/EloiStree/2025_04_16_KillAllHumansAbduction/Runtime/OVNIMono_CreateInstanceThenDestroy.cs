using UnityEngine;

namespace Eloi.OVNI
{

    public class OVNIMono_CreateInstanceThenDestroy : MonoBehaviour
    {
        public float m_timeToDie = 5;
        public GameObject m_whatToCreate;
        public Transform m_whereToCreate;
        [ContextMenu("Create the prefab")]
        public void CreatePrefab()
        {
            GameObject createdGameObject = GameObject.Instantiate(m_whatToCreate);
            createdGameObject.transform.position = m_whereToCreate.transform.position;
            createdGameObject.transform.rotation = m_whereToCreate.transform.rotation;
            Destroy(createdGameObject, m_timeToDie);

        }
    }
}