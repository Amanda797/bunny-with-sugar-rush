using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//change all Controller to sneakyController
public abstract class SneakyController : MonoBehaviour
{
    protected SneakyPawn sneakypawn;

    protected virtual void Start()
    {
        sneakypawn = GetComponent<SneakyPawn>();
        Debug.Log(sneakypawn);
    }





}

