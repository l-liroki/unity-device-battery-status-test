﻿
namespace DeviceStatus.Devices
{

    public class UnityEditorDeviceStatus : IDeviceStatus
    {

        public void OnEnable()
        {
        }

        public void OnDisable()
        {
        }


        public float GetMemoryUsage()
        {
            var m = System.GC.GetTotalMemory(false);

            return m;
        }

        public BatteryStatus GetBatteryStatus()
        {
            return new BatteryStatus
            {
                Level = -1f
            };
        }

    }

}
