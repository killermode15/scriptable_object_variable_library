using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class FloatReference
{
    [SerializeField] private bool useConstant;
    [SerializeField] private FloatVariable floatVariable;
    [SerializeField] private float constantValue;

    public float Value
    {
        get
        {
            return useConstant ? constantValue : floatVariable.Value;
        }

        set
        {
            if (useConstant)
            {
                constantValue = value;
            }
            else
            {
                if (!floatVariable)
                    throw new NullReferenceException("Float variable is missing");

                floatVariable.Value = value;
            }

        }
    }
}
