using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variable/Float")]
public class FloatVariable : ScriptableObject
{
    public float Value
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

    [SerializeField] private float value;
}