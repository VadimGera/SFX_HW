using UnityEngine;
using UnityEngine.Events;

namespace NickKhalow.Sound_Managments.Scripts.Lib
{
    public class UnToggle: MonoBehaviour
    {
        public UnityEvent<bool> toggled = new();

        public void Turn(bool toggle)
        {
            toggled.Invoke(!toggle);
        }
    }
}