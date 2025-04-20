using UnityEngine;
using UnityEngine.Events;


namespace Eloi.Relay
{
    public class RelayMono_PushPrimitive : MonoBehaviour
    {
        public UnityEvent<string> m_onRelayed = new UnityEvent<string>();
        public string m_format = "{0}";

        public void PushIn(object value) => m_onRelayed?.Invoke(string.Format(m_format, value));
        public void PushIn(float value) => m_onRelayed?.Invoke(string.Format(m_format, value));
        public void PushIn(int value) => m_onRelayed?.Invoke(string.Format(m_format, value));
        public void PushIn(uint value) => m_onRelayed?.Invoke(string.Format(m_format, value));
        public void PushIn(long value) => m_onRelayed?.Invoke(string.Format(m_format, value));
        public void PushIn(ulong value) => m_onRelayed?.Invoke(string.Format(m_format, value));
        public void PushIn(short value) => m_onRelayed?.Invoke(string.Format(m_format, value));
        public void PushIn(ushort value) => m_onRelayed?.Invoke(string.Format(m_format, value));
        public void PushIn(byte value) => m_onRelayed?.Invoke(string.Format(m_format, value));
        public void PushIn(sbyte value) => m_onRelayed?.Invoke(string.Format(m_format, value));
        public void PushIn(double value) => m_onRelayed?.Invoke(string.Format(m_format, value));
        public void PushIn(decimal value) => m_onRelayed?.Invoke(string.Format(m_format, value));
        public void PushIn(char value) => m_onRelayed?.Invoke(string.Format(m_format, value));
        public void PushIn(bool value) => m_onRelayed?.Invoke(string.Format(m_format, value));
        public void PushIn(string value) => m_onRelayed?.Invoke(string.Format(m_format, value));
        public void PushIn(Color value) => m_onRelayed?.Invoke(string.Format(m_format, value));
        public void PushIn(Color32 value) => m_onRelayed?.Invoke(string.Format(m_format, value));
        public void PushIn(Vector2 value) => m_onRelayed?.Invoke(string.Format(m_format, value));
        public void PushIn(Vector3 value) => m_onRelayed?.Invoke(string.Format(m_format, value));
        public void PushIn(Vector4 value) => m_onRelayed?.Invoke(string.Format(m_format, value));
        public void PushIn(Quaternion value) => m_onRelayed?.Invoke(string.Format(m_format, value));
        


    }






}

