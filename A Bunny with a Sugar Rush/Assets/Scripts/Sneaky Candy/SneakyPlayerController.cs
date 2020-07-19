using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//PlayerController to SneakyPlayerController    Controller to SneakyController
public class SneakyPlayerController : SneakyController
{
    public float playerNoiseDistance;
    public GameObject bullet;
    public Transform firepoint;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        sneakypawn.Move(vertical);
        sneakypawn.Rotate(horizontal);


        if (Input.GetKeyDown(KeyCode.Space))
        {

            Instantiate(bullet, firepoint.position, firepoint.rotation);



        }
    }
}

