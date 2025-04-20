using UnityEngine;


namespace Eloi.Relay
{
    public class  RelayActionMono_SetRendererTexture2D: MonoBehaviour
    {

        public Renderer[] m_renderers;
        
        public void PushIn(Texture2D value)
        {
            foreach (var renderer in m_renderers)
            {
                if (renderer != null)
                {
                    renderer.material.mainTexture = value;
                }
            }
        }
    }
}

