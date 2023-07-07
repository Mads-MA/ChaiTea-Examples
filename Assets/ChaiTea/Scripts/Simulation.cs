using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using ChaiTea;

public class Simulation : MonoBehaviour
{
    Thread simThread;
    bool simulationRunning = false;
    bool hapticThreadStopped = true;

    [SerializeField]
    private CursorTool tool;

    private void Start()
    {
        Debug.Log("Starting Simulation");
        simThread = new Thread(UpdateHaptics);
        simThread.Start();
    }

    private void OnDestroy()
    {
        simulationRunning= false;
        while (!hapticThreadStopped)
            Thread.Sleep(5);
        simThread.Join();
    }

    private void UpdateHaptics()
    {
        simulationRunning = true;
        hapticThreadStopped = false;
        while (simulationRunning)
        {
            //Compute global reference frames for each object
            HapticWorld.Instance.world.ComputeGlobalPositions(true);

            //Update position and orientation of tool
            tool.Tool.UpdateFromDevice();

            //Compute interaction forces
            tool.Tool.ComputeInteractionForces();

            //send forces to haptic device
            tool.Tool.ApplyToDevice();
        }
        hapticThreadStopped = true;
        tool.Tool.StopServo();
        HapticWorld.Instance.ResetWorld();
    }
}
