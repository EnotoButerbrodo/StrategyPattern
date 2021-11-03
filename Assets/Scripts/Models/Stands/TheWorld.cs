using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Interfaces.Models;
using UnityEditor;

public class TheWorld : MonoBehaviour, IStando
{
    public string Namae => "The World";

    public void Tsukai()
    {
        EditorUtility.DisplayDialog("Stando Tsukai", "The Wardo, tomare wo tokeyo!", "OK");
    }
}
