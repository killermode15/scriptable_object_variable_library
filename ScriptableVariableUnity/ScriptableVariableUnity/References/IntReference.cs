using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class IntReference
{
    [SerializeField] private bool useConstant;
    [SerializeField] private IntVariable intReference;
    [SerializeField] private int constantValue;

    public int Value
    {
        get
        {
            return useConstant ? constantValue : intReference.Value;
        }

        set
        {
            if (useConstant)
            {
                constantValue = value;
            }
            else
            {
                if (!intReference)
                    throw new NullReferenceException("Float variable is missing");

                intReference.Value = value;
            }

        }
    }
}
