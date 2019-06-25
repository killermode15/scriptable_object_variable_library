using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Vector2Reference
{
    [SerializeField] private bool useConstant;
    [SerializeField] private Vector2Variable vector2Variable;
    [SerializeField] private Vector2 constantValue;

    public Vector2 Value
    {
        get
        {
            return useConstant ? constantValue : vector2Variable.Value;
        }

        set
        {
            if (useConstant)
            {
                constantValue = value;
            }
            else
            {
                if (!vector2Variable)
                    throw new NullReferenceException("Float variable is missing");

                vector2Variable.Value = value;
            }
        }
    }

    public static Vector2 operator +(Vector2Reference a, Vector2Reference b)
    {
        return a.Value + b.Value;
    }

    public static Vector2 operator -(Vector2Reference a, Vector2Reference b)
    {
        return a.Value - b.Value;
    }

    public static Vector2 operator /(Vector2Reference a, Vector2Reference b)
    {
        return a.Value / b.Value;
    }

    public static Vector2 operator *(Vector2Reference a, Vector2Reference b)
    {
        return a.Value * b.Value;
    }

    public static bool operator ==(Vector2Reference a, Vector2Reference b)
    {
        return a == b;
    }

    public static bool operator !=(Vector2Reference a, Vector2Reference b)
    {
        return !(a==b);
    }
}
