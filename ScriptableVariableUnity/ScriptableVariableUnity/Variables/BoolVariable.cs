using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variable/Boolean")]
public class BoolVariable : ScriptableObject
{
    public bool Value
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

    [SerializeField] private bool value;
}