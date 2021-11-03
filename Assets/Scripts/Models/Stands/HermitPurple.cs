using System.Collections;
using System.Collections.Generic;
using Interfaces.Models;
using UnityEditor;
using UnityEngine;

public class HermitPurple : MonoBehaviour, IStando
{
    public string Namae => "Hermito Purple!";

    public void Tsukai()
    {
        EditorUtility.DisplayDialog("Stando Tsukai", "O MAY GAD! O NO!", "YES Yes YES");    
    }
}
