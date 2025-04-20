using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


namespace Eloi.Relay
{
    public class RelayMono_PushListOfPrimitive : MonoBehaviour
    {
        public UnityEvent<string> m_onRelayed = new UnityEvent<string>();
        public UnityEvent<string[]> m_onRelayedAsArray = new UnityEvent<string[]>();

        public string m_format="{0}";
        public string m_separator = ",";
        public void PushIn<T>(IEnumerable<T> value)
        {
            List<string> list = new List<string>();
            foreach (var item in value)
            {
                list.Add(string.Format(m_format, item));
            }

            m_onRelayed?.Invoke(string.Join(m_separator, list));
            m_onRelayedAsArray?.Invoke(list.ToArray());
        }
        public void PushIn(IEnumerable<float> value) => PushIn<float>(value);
        public void PushIn(IEnumerable<int> value) => PushIn<int>(value);
        public void PushIn(IEnumerable<uint> value) => PushIn<uint>(value);
        public void PushIn(IEnumerable<long> value) => PushIn<long>(value);
        public void PushIn(IEnumerable<ulong> value) => PushIn<ulong>(value);
        public void PushIn(IEnumerable<short> value) => PushIn<short>(value);
        public void PushIn(IEnumerable<ushort> value) => PushIn<ushort>(value);
        public void PushIn(IEnumerable<byte> value) => PushIn<byte>(value);
        public void PushIn(IEnumerable<sbyte> value) => PushIn<sbyte>(value);
        public void PushIn(IEnumerable<double> value) => PushIn<double>(value);
        public void PushIn(IEnumerable<decimal> value) => PushIn<decimal>(value);
        public void PushIn(IEnumerable<char> value) => PushIn<char>(value);
        public void PushIn(IEnumerable<bool> value) => PushIn<bool>(value);
        public void PushIn(IEnumerable<string> value) => PushIn<string>(value);
        public void PushIn(IEnumerable<Color> value) => PushIn<Color>(value);
        public void PushIn(IEnumerable<Color32> value) => PushIn<Color32>(value);
        public void PushIn(IEnumerable<Vector2> value) => PushIn<Vector2>(value);
        public void PushIn(IEnumerable<Vector3> value) => PushIn<Vector3>(value);
        public void PushIn(IEnumerable<Vector4> value) => PushIn<Vector4>(value);
        public void PushIn(IEnumerable<Quaternion> value) => PushIn<Quaternion>(value);


    }






}

