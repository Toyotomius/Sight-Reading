using Minis;
using UnityEngine;
using UnityEngine.InputSystem;
using static Main.Assets.Resources.Global.GlobalConstants;

namespace Main.Assets.Resources
{
    public class ChangeMidiDevice : MonoBehaviour
    {
        public void Start()
        {
            InputSystem.onDeviceChange += (device, change) =>
            {
                if (change != InputDeviceChange.Added)
                {
                    return;
                }
                Device = device as MidiDevice;
            };
        }
    }
}
