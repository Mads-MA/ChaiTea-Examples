using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HapticBox : HapticPrimitiveShape
{

    protected override void Awake()
    {
        obj = new ChaiTea.ShapeBox(this.transform.localScale);
        base.Awake();
    }

    public new ChaiTea.ShapeBox Get()
    {
        return obj as ChaiTea.ShapeBox;
    }
}
