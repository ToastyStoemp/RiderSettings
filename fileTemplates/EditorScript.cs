
#set( $subName = ${NAME}.substring(0, 2))

using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(${subName}))]
public class ${NAME}: Editor 
{
    private ${subName} _target;

    public virtual void OnEnable()
    {
        _target = (${subName}) target;
    }

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
    }
}