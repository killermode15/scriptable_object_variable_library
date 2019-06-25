using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Vector4Reference
{
    [SerializeField] private bool useConstant;
    [SerializeField] private Vector4Variable vector4Variable;
    [SerializeField] private Vector4 constantValue;

    public Vector4 Value
    {
        get
        {
            return useConstant ? constantValue : vector4Variable.Value;
        }

        set
        {
            if (useConstant)
            {
                constantValue = value;
            }
            else
            {
                if (!vector4Variable)
                    throw new NullReferenceException("Float variable is missing");

                vector4Variable.Value = value;
            }
        }
    }

    public static Vector3 operator +(Vector4Reference a, Vector4Reference b)
    {
        return a.Value + b.Value;
    }

    public static Vector3 operator -(Vector4Reference a, Vector4Reference b)
    {
        return a.Value - b.Value;
    }

    public static Vector3 operator /(Vector4Reference a, float b)
    {
        return a.Value / b;
    }

    public static Vector3 operator *(Vector4Reference a, float b)
    {
        return a.Value * b;
    }

    public static bool operator ==(Vector4Reference a, Vector4Reference b)
    {
        return a == b;
    }

    public static bool operator !=(Vector4Reference a, Vector4Reference b)
    {
        return !(a==b);
    }
}
