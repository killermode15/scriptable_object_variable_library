using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variable/Vector 3")]
public class Vector3Variable : ScriptableObject
{
    public Vector3 Value
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

    [SerializeField] private Vector3 value;
}