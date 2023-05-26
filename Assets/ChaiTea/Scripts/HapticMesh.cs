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
        obj = new ChaiTea.Mesh(meshFilter.mesh);
        base.Awake();
    }

    protected override void Start()
    {
        base.Start();
    }
}
