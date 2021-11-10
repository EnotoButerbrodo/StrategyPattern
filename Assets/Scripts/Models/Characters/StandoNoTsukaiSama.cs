using System.Collections;
using System.Collections.Generic;
using Interfaces.Models;
using UnityEngine;

public class StandoNoTsukaiSama : MonoBehaviour, IStandUser
{
    protected IStando StandBehavior;
    public bool StandoWoTsukaiMonoGaAru;
    protected virtual void Start()
    {
        GetStando();
    }

    protected void GetStando(){
            StandBehavior = GetComponent<IStando>();
            StandoWoTsukaiMonoGaAru = (StandBehavior is IStando) ? true: false;
    }

    public void Use()
    {
        if(StandBehavior is IStando)
            StandBehavior.Tsukai();
    }
}
