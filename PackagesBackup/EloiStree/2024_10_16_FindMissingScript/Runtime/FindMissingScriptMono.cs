using UnityEngine;
using System.Collections.Generic;

public class FindMissingScriptMono: MonoBehaviour
{
    public void FindAllMissingScripts()
    {
        StaticFindAllMissingScripts();
    }
    public static void StaticFindAllMissingScripts()
    {
        GameObject[] allObjects = GameObject.FindObjectsByType<GameObject>(FindObjectsInactive.Include, FindObjectsSortMode.None);

        int missingCount = 0;

        List<GameObject> missingObjects = new List<GameObject>();

        foreach (GameObject obj in allObjects)
        {
            Component[] components = obj.GetComponents<Component>();

            for (int i = 0; i < components.Length; i++)
            {
                if (components[i] == null)
                {
                    missingObjects.Add(obj);
                    Debug.Log($"Missing script found: {obj.name}", obj);
                    missingCount++;
                }
            }
        }

        if (missingCount == 0)
        {
            Debug.Log("No missing scripts found in the scene.");
        }
    }
}
