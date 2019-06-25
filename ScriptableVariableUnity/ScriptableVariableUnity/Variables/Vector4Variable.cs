using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variable/Vector 4")]
public class Vector4Variable : ScriptableObject
{
    public Vector4 Value
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

    [SerializeField] private Vector4 value;
}