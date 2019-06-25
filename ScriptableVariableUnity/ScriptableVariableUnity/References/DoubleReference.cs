using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class DoubleReference
{
    [SerializeField] private bool useConstant;
    [SerializeField] private DoubleVariable doubleVariable;
    [SerializeField] private double constantValue;

    public double Value
    {
        get
        {
            return useConstant ? constantValue : doubleVariable.Value;
        }

        set
        {
            if (useConstant)
            {
                constantValue = value;
            }
            else
            {
                if (!doubleVariable)
                    throw new NullReferenceException("Float variable is missing");

                doubleVariable.Value = value;
            }

        }
    }
}
