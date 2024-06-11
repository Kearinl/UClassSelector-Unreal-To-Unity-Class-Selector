// Layman's Terms:
// This script tells Unity how to display our special tag in the Inspector.
// It shows a dropdown list of scripts that match the type we specified, and lets us choose one.

// Programming Terms:
// This script defines a custom property drawer named UClassSelectorDrawer, which handles the drawing of fields marked with the UClassSelectorAttribute in the Unity Inspector. It provides a dropdown list of all non-abstract subclasses of the specified base type.

using System;
using System.Linq;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(UClassSelectorAttribute))]
public class UClassSelectorDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        var typeSelector = attribute as UClassSelectorAttribute;

        if (typeSelector == null)
            return;

        // Find all classes that derive from the specified base type
        var types = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(assembly => assembly.GetTypes())
            .Where(t => typeSelector.BaseType.IsAssignableFrom(t) && !t.IsAbstract)
            .ToArray();

        // Get the type names
        var typeNames = types.Select(t => t.FullName).ToArray();

        // Get the current selected type index
        int currentIndex = Array.IndexOf(typeNames, property.stringValue);

        // Draw the popup
        int newIndex = EditorGUI.Popup(position, label.text, currentIndex, typeNames);

        // Set the property value to the selected type
        if (newIndex >= 0)
        {
            property.stringValue = typeNames[newIndex];
        }
        else
        {
            property.stringValue = "";
        }
    }
}

