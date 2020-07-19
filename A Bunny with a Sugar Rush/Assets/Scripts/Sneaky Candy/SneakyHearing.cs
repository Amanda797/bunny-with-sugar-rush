using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SneakyHearing : MonoBehaviour
{
    public float hearingRadius;
    public SneakyPawn sneakypawn;
    public GameObject searchLocation;
    public bool CanHear()
    {
        if (Vector3.Distance(transform.position, GameOverAllControl.instance.sneakyPlayer.transform.position) < hearingRadius + GameOverAllControl.instance.sneakyPlayer.GetComponent<SneakyPlayerController>().playerNoiseDistance)
        {
            //I can hear the player
            Debug.Log("I can hear the player");
            searchLocation = new GameObject();
            searchLocation.transform.position = GameOverAllControl.instance.sneakyPlayer.transform.position;
            sneakypawn.target = searchLocation.transform;
            return true;
        }
        return false;
    }



}

