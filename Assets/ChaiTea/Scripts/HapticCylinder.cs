using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class HapticCylinder : HapticPrimitiveShape
{
    protected override void Awake()
    {
        double height = this.transform.localScale.y*2;
        double radius = this.transform.localScale.x / 2;
        obj = new ChaiTea.ShapeCylinder(radius, height);
        base.Awake();

        //Chai3D cylinder position is at bottom
        //Unity cylinder position at middle
        //Apply the offset.
        Vector3 offset = new Vector3(0, -this.transform.localPosition.y, 0);
        obj.SetLocalPosition(this.transform.localPosition + offset);
    }

    protected override void Start()
    {
        base.Start();
    }
}
