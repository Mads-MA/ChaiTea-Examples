using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class HapticMaterial : MonoBehaviour
{
    [SerializeField]
    private double stiffness = 100;

    [SerializeField]
    private double damping = 0;

    [SerializeField]
    private double dynamicFriction = 0;

    [SerializeField]
    private double staticFriction = 0;

    [SerializeField]
    private double vibrationFrequency = 0;

    [SerializeField]
    private double vibrationAmplitude = 0;

    [SerializeField]
    private double stickSlipMaxForce = 0;

    [SerializeField]
    private double stickSlipStiffness = 0;

    [SerializeField]
    private double viscosity = 0;

    [SerializeField]
    private double magneticMaxForce = 0;

    [SerializeField]
    private double magneticMaxDistance = 0;


    ChaiTea.HapticMaterial hapticMaterial;

    private void Awake()
    {
        hapticMaterial = new ChaiTea.HapticMaterial();
        hapticMaterial.SetStiffness(stiffness);
        hapticMaterial.SetDamping(damping);
        hapticMaterial.SetFriction(staticFriction, dynamicFriction);
        hapticMaterial.SetStickSlip(stickSlipMaxForce, stickSlipStiffness);
        hapticMaterial.SetViscosity(viscosity);
        hapticMaterial.SetMagnet(magneticMaxForce, magneticMaxDistance);
        hapticMaterial.SetVibration(vibrationFrequency, vibrationAmplitude);
    }


    public ChaiTea.HapticMaterial Get()
    {
        return hapticMaterial;
    }
}