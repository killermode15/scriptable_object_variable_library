﻿using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(Vector2Reference))]
public class Vector2PropertyDrawer : PropertyDrawer
{
    private string[] options = { "Use Constant", "Use Variable" };
    private int boolVal = 0;


    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginProperty(position, label, property);

        position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);
        boolVal = EditorGUI.Popup(new Rect(position.position - new Vector2(20, 0), new Vector2(17.5f, position.size.y)), boolVal, options);
        bool useConstant = property.FindPropertyRelative("useConstant").boolValue = (boolVal == 0);

        EditorGUI.PropertyField(position,
            useConstant
                ? property.FindPropertyRelative("constantValue")
                : property.FindPropertyRelative("vector2Variable"), GUIContent.none);

        EditorGUI.EndProperty();
    }
}

