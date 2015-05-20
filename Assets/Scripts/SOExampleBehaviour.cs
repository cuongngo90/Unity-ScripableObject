using UnityEngine;
using System.Collections;

public class SOExampleBehaviour : MonoBehaviour
{
    public SOExample test;
    public void OnEnable()
    {
        if (test == null)
            test = ScriptableObject.CreateInstance<SOExample>();

        Debug.Log("Text SO Example : " + test.text);
    }
}
