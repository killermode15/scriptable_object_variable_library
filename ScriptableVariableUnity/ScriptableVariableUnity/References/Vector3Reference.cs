using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Vector3Reference
{
    [SerializeField] private bool useConstant;
    [SerializeField] private Vector3Variable vector3Variable;
    [SerializeField] private Vector3 constantValue;

    public Vector3 Value
    {
        get
        {
            return useConstant ? constantValue : vector3Variable.Value;
        }

        set
        {
            if (useConstant)
            {
                constantValue = value;
            }
            else
            {
                if (!vector3Variable)
                    throw new NullReferenceException("Float variable is missing");

                vector3Variable.Value = value;
            }
        }
    }

    public static Vector3 operator +(Vector3Reference a, Vector3Reference b)
    {
        return a.Value + b.Value;
    }

    public static Vector3 operator -(Vector3Reference a, Vector3Reference b)
    {
        return a.Value - b.Value;
    }

    public static Vector3 operator /(Vector3Reference a, float b)
    {
        return a.Value / b;
    }

    public static Vector3 operator *(Vector3Reference a, float b)
    {
        return a.Value * b;
    }

    public static bool operator ==(Vector3Reference a, Vector3Reference b)
    {
        return a == b;
    }

    public static bool operator !=(Vector3Reference a, Vector3Reference b)
    {
        return !(a==b);
    }
}
