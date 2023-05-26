using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(HapticDeviceManager))]
public class HapticDeviceManagerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        HapticDeviceManager myScript = (HapticDeviceManager)target;
        if (GUILayout.Button("Get device info"))
        {
            myScript.GetDevice(myScript.currentDevice);
        }
    }
}
