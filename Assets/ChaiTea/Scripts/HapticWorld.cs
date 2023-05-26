using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HapticWorld
{
    //Implemnent as singleton. We want this to be initialized whenever we first attempt to access it.
    private static HapticWorld instance;
    public static HapticWorld Instance { get {
            if (instance == null)
            {
                instance = new HapticWorld();
                
                Debug.Log("Created haptic world");
            }
            return instance;
        } 
    }

    public ChaiTea.World world;

    protected HapticWorld() 
    {
        world = new ChaiTea.World();
    }
    
    public void ResetWorld()
    {
        world.Reset();
    }
}
