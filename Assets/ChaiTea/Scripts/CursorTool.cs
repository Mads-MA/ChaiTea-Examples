using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class CursorTool : MonoBehaviour
{
    private ChaiTea.ToolCursor tool;
    public ChaiTea.ToolCursor Tool { get { return tool; } }


    [SerializeField]
    private int deviceIndex = 0;

    [SerializeField]
    private double toolRadius = 0.05;

    [SerializeField]
    private double workspaceRadius = 1f;

    [SerializeField]
    private GameObject proxyObject;

    [SerializeField]
    private GameObject hipObject;

    [SerializeField]
    private bool showProxy = true;
    [SerializeField]
    private bool showHIP = true;

    private void Awake()
    {
        tool = new ChaiTea.ToolCursor(HapticWorld.Instance.world, deviceIndex);
        HapticWorld.Instance.world.AddChild(tool);
        tool.SetToolRadius(toolRadius);
        tool.SetWorkspaceRadius(workspaceRadius);
        tool.WaitForSmallForce(true);
        
    }

    private void Start()
    {
        Debug.Log("Starting Servo");
        tool.StartServo();
    }


    private void Update()
    {
        Vector3 proxyPosition = tool.GetProxyPosition();
        proxyObject.transform.position = proxyPosition;

        Vector3 hipPosition = tool.GetDevicePosition();
        hipObject.transform.position = hipPosition;
    }


    private void OnApplicationQuit()
    {
        tool.StopServo();
    }

    //We cannot modify objects in OnValidate, so we do a workaround.
    //Solution from here https://forum.unity.com/threads/sendmessage-cannot-be-called-during-awake-checkconsistency-or-onvalidate-can-we-suppress.537265/#post-8157614
#if UNITY_EDITOR
    private void OnValidate() => UnityEditor.EditorApplication.update += _OnValidate;
    private void _OnValidate()
    {
        UnityEditor.EditorApplication.update -= _OnValidate;
        if (this == null || !UnityEditor.EditorUtility.IsDirty(this)) return;

        proxyObject.transform.localScale = new Vector3((float)toolRadius * 2, (float)toolRadius * 2, (float)toolRadius * 2);
        hipObject.transform.localScale = new Vector3((float)toolRadius * 2, (float)toolRadius * 2, (float)toolRadius * 2);

        proxyObject.SetActive(showProxy);
        hipObject.SetActive(showHIP);

        UnityEditor.EditorUtility.SetDirty(proxyObject);
        UnityEditor.EditorUtility.SetDirty(hipObject);
        //ModifyComponentsAndMarkThemAsDirty();
    }
#endif
}