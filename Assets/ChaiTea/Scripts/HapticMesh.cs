using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class HapticMesh : HapticObject
{
    [SerializeField]
    private MeshFilter meshFilter;

    protected override void Awake()
    {
        var meshObj = new ChaiTea.Mesh(meshFilter.mesh);
        meshObj.SetScale(transform.localScale);
        obj = meshObj;
        base.Awake();
        
    }

    protected override void Start()
    {
        base.Start();
    }
}
