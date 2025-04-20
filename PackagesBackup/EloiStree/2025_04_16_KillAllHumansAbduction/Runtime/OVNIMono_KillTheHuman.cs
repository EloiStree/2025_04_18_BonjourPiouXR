using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Eloi.OVNI { 
    public class OVNIMono_KillTheHuman : MonoBehaviour
    {
        public static List<OVNIMono_KillTheHuman> HumansInScene = new List<OVNIMono_KillTheHuman>();


        public static int GetAliveCount()
        {
            int count = 0;
            foreach (var humanInScene in HumansInScene)
            {
                if (humanInScene.gameObject.activeSelf)
                    count++;
            }
            return count;
        }
        public static int GetDeathCount()
        {
            int count = 0;
            foreach (var humanInScene in HumansInScene)
            {
                if (!humanInScene.gameObject.activeSelf)
                    count++;
            }
            return count;
        }
        public static int GetTotalCount()
        {
            return HumansInScene.Count;
        }


        public void Awake()
        {
            HumansInScene.Add(this);

        }
        public void OnDestroy()
        {
            HumansInScene.Remove(this);
        }


        [ContextMenu("Kill All The Humans")]
        public void KillAllTheHumans()
        {

            foreach (var humanInScene in HumansInScene)
            {
                OVNIMono_KillTheHuman human = humanInScene.GetComponent<OVNIMono_KillTheHuman>();
                if (human != null)
                {
                    human.KillTheHuman();
                }
            }
        }

        [ContextMenu("Spawn All The Humans")]
        public void SpawnAllTheHumans()
        {

            foreach (var humanInScene in HumansInScene)
            {
                OVNIMono_KillTheHuman human = humanInScene.GetComponent<OVNIMono_KillTheHuman>();
                if (human != null)
                {
                    human.SpawnTheHuman();
                }
            }
        }

        public static bool IsAllAlive()
        {
            foreach (var humanInScene in HumansInScene)
            {
                if (!humanInScene.gameObject.activeSelf)
                    return false;
            }
            return true;
        }
        public static bool IsAllDeath()
        {
            foreach (var humanInScene in HumansInScene)
            {
                if (humanInScene.gameObject.activeSelf)
                    return false;
            }
            return true;
        }

        public static void IsOneAlive()
        {
            foreach (var humanInScene in HumansInScene)
            {
                if (humanInScene.gameObject.activeSelf)
                    return;
            }
            Debug.Log("All the humans are dead");
        }

        public static void IsOneDeath()
        {
            foreach (var humanInScene in HumansInScene)
            {
                if (!humanInScene.gameObject.activeSelf)
                    return;
            }
            Debug.Log("All the humans are alive");
        }

        public UnityEvent m_onSpawnAction;
        public UnityEvent m_onKillAction;
        public bool m_disableOnKill = true;

        [ContextMenu("Kill The Human")]
        public void KillTheHuman()
        {
            if (m_disableOnKill)
                this.gameObject.SetActive(false);
            m_onKillAction.Invoke();
        }
        [ContextMenu("Spawn")]
        public void SpawnTheHuman()
        {
            this.gameObject.SetActive(true);
            m_onSpawnAction.Invoke();
        }
    }

}