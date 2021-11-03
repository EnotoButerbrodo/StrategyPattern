using Interfaces.Models;
using UnityEngine;
using UnityEditor;

public class StarPlatinum : MonoBehaviour, IStando
{
    public string Namae { get => "Star Platinum"; }

    public void Tsukai()
    {
        EditorUtility.DisplayDialog("Stando Tsukai", "URURURURURURRURU", "OK");
    }
}
