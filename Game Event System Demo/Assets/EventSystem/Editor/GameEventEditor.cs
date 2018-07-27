using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GameEvent))]
public class GameEventEditor : Editor
{

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUI.enabled = Application.isPlaying;

        GameEvent _GE = target as GameEvent;

        if (GUILayout.Button("Raise"))
        {
            _GE.Raise();
        }
    }
}
