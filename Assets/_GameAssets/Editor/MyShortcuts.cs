using UnityEditor;
using UnityEngine;

public class MyShortcuts : Editor
{
    [MenuItem("GameObject/ActiveToggle #a")] //Shift + A = Toggle GameObject(s) on/off
    static void ToggleActivationSelection()
    {
        foreach (GameObject go in Selection.gameObjects)
            go.SetActive(!go.activeSelf);
    }
}