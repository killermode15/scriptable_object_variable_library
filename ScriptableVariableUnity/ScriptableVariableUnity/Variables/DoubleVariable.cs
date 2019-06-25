using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variable/Double")]
public class DoubleVariable : ScriptableObject
{
    public double Value
    {
        get
        {
            return value; 
        }
        set
        {
            this.value = value; 
        }
    }

    [SerializeField] private double value;
}