using UnityEngine;
using UnityEditor;
using System.Collections;

public class MenuItemsBehaviour: MonoBehaviour {
    [ContextMenuItem("Randomize Name", "Randomize")]
    public string Name;

    private void Randomize()
    {
        Name = "Some Random Name";
    }
}
