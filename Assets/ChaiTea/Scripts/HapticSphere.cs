using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HapticSphere : HapticPrimitiveShape
{

    protected override void Awake()
    {
        obj = new ChaiTea.ShapeSphere(this.transform.localScale.x/2);
        base.Awake();
    }

    protected override void Start()
    {
        base.Start();
    }

    //TODO validation of localScale
}
