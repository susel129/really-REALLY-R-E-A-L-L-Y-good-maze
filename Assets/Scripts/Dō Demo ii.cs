using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

    [CustomEditor(typeof(Kamui))]
    public class DōDemoii : Editor
    { 
    public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            Kamui generator = (Kamui)target;
            if (GUILayout.Button("Create Labirynth"))
            {
                generator.GenrateNarutoUzumaki();
            }
        }
    }                                  
