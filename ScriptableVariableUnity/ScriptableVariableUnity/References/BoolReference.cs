using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class BoolReference
{
    [SerializeField] private bool useConstant;
    [SerializeField] private BoolVariable boolVariable;
    [SerializeField] private bool constantValue;

    public bool Value
    {
        get
        {
            return useConstant ? constantValue : boolVariable.Value; 
        }
        set
        {
            if (useConstant)
            {
                constantValue = value;
            }
            else
            {
                if (!boolVariable)
                    throw new NullReferenceException("Float variable is missing");

                boolVariable.Value = value;
            }

        }
    }
}
