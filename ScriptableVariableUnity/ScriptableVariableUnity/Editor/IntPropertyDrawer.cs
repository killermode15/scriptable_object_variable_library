using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(IntReference))]
public class IntPropertyDrawer : PropertyDrawer
{
    private string[] options = { "Use Constant", "Use Variable" };
    private int boolVal = 0;


    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginProperty(position, label, property);

        Debug.Log(position.position);
        Debug.Log(position.size);

        position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);
        boolVal = EditorGUI.Popup(new Rect(position.position - new Vector2(20, 0), new Vector2(17.5f, position.size.y)), boolVal, options);
        bool useConstant = property.FindPropertyRelative("useConstant").boolValue = (boolVal == 0);

        EditorGUI.PropertyField(position,
            useConstant
                ? property.FindPropertyRelative("constantValue")
                : property.FindPropertyRelative("intVariable"), GUIContent.none);

        EditorGUI.EndProperty();
    }
}

