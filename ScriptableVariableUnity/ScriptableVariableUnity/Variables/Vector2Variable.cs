using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variable/Vector 2")]
public class Vector2Variable : ScriptableObject
{
    public Vector2 Value
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

    [SerializeField] private Vector2 value;
}