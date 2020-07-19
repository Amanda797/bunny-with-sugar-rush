using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SneakySight : MonoBehaviour

{
    public float sightRadius;
    //Pawn to SneakyPawn, pawn to sneakypawn
    public SneakyPawn sneakypawn;
    public GameObject searchLocation;
    public float viewAngle;

    public bool CanSee()
    {
        //Distance between AI and player is less than sight radius
        //GameManager to GameOverAllControl
        if (Vector3.Distance(transform.position, GameOverAllControl.instance.sneakyPlayer.transform.position) < sightRadius)
        {
            //if player is in view angle 

            if (Vector3.Angle(transform.position, GameOverAllControl.instance.sneakyPlayer.transform.position) < viewAngle / 2)
            {
                //raycast to player
                Vector3 directionToPlayer = GameOverAllControl.instance.sneakyPlayer.transform.position - transform.position;
                RaycastHit2D hit = Physics2D.Raycast(transform.position, directionToPlayer);

                if (hit.collider.tag == "Player")
                {
                    searchLocation = new GameObject();
                    searchLocation.transform.position = GameOverAllControl.instance.sneakyPlayer.transform.position;
                    sneakypawn.target = searchLocation.transform;
                    return true;
                }

                else
                {
                    return false;
                }
            }
        }
        return false;


    }

}

