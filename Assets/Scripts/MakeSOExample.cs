using UnityEngine;
using System.Collections;
using UnityEditor;

public class MakeSOExample
{
    [MenuItem("Assets/Create/My Scriptable Object")]
    public static void CreateSOAsset()
    {
        SOExample asset = ScriptableObject.CreateInstance<SOExample>();

        AssetDatabase.CreateAsset(asset, "Assets/Resources/SOExample.asset");
        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();
        Selection.activeObject = asset;
    }
}
