// Layman's Terms:
// This script creates a special tag that can be placed on variables.
// This tag will remember the type of scripts we want to choose from in the Unity Inspector.

// Programming Terms:
// This script defines a custom attribute named UClassSelectorAttribute, which can be used to annotate fields with a specific base type for class selection in the Unity Inspector.

using System;
using UnityEngine;

[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
public class UClassSelectorAttribute : PropertyAttribute
{
    public Type BaseType { get; private set; }

    public UClassSelectorAttribute(Type baseType)
    {
        BaseType = baseType;
    }
}

