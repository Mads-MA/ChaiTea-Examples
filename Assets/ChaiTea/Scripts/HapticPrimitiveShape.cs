using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public abstract class HapticPrimitiveShape : HapticObject
{
    [SerializeField]
    private ChaiTea.EffectType hapticEffects;

    protected override void Awake()
    {
        base.Awake();

        //Check and create all enabled haptic effects. 
        foreach (ChaiTea.EffectType effectType in Enum.GetValues(hapticEffects.GetType()))
        {
            if (hapticEffects.HasFlag(effectType))
            {
                obj.CreateEffect(effectType);
            }
        }    
    }

    protected override void Start()
    {
        base.Start();
    }

}