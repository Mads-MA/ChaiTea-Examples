using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class HapticDeviceManager : MonoBehaviour
{
    public int currentDevice = 0; 
    public void GetDevice(int deviceId)
    {
        ChaiTea.HapticDeviceInfo info = ChaiTea.HapticDevice.GetDeviceInfo(deviceId);
        Debug.Log($"Model: {info.model}\n" +
            $"manufacture: {info.manufacturerName}\n" +
            $"workspace radius: {info.workspaceRadius}\n" +
            $"max stiffness: {info.maxLinearStiffness}" +
            $"max damping: {info.maxLinearDamping}");
    }
}
