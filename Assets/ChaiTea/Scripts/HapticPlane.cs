using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


public class HapticPlane : HapticObject
{


    protected override void Awake()
    {
        obj = ChaiTea.Mesh.CreatePlane(this.transform.localScale.x, this.transform.localScale.z);
        base.Awake();
    }

    protected override void Start()
    {
        base.Start();
    }
}

