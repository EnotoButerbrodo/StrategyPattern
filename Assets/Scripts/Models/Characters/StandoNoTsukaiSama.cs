using System.Collections;
using System.Collections.Generic;
using Interfaces.Models;
using UnityEngine;

public class StandoNoTsukaiSama : MonoBehaviour
{
    protected IStando StandBehavior;
    public bool StandoTsukaiMonoGaAru;
    protected virtual void Start()
    {
        GetStando();
        StandoTsukai();
    }

    protected void GetStando(){
            StandBehavior = GetComponent<IStando>();
            StandoTsukaiMonoGaAru = (StandBehavior is IStando) ? true: false;
    }

    public void StandoTsukai(){
        if(StandBehavior is IStando)
            StandBehavior.Tsukai();
    }
}
