using ChaiTea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

[RequireComponent(typeof(HapticMaterial))]
public abstract class HapticObject : MonoBehaviour
{
    protected ChaiTea.GenericObject obj;

    [SerializeField]
    private HapticMaterial hapticMaterial;

    protected virtual void Awake()
    {
        obj.SetRotation(this.transform.rotation);
        obj.SetLocalPosition(this.transform.localPosition);
        HapticWorld.Instance.world.AddChild(obj);
    }

    protected virtual void Start()
    {
        obj.SetHapticMaterial(hapticMaterial.Get());
    }

    public ChaiTea.GenericObject Get()
    {
        return obj;
    }
}