using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variable/Integer")]
public class IntVariable : ScriptableObject
{
    public int Value
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

    [SerializeField] private int value;
}