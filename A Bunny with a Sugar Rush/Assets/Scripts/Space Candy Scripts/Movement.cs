using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    public Transform tf;
    public GameObject badFairy;
    private bool canMoveBadFairy = true;
    public float speed;
    public float rotateSpeed;
    [Header("Bullet Info")]
    [SerializeField]
    GameObject bulletPrefab;
    [SerializeField]
    Transform bulletSpawn;
    [SerializeField]
    Transform bulletSpawn2;
    void Start()
    {
        // Get the Transform Component
        tf = GetComponent<Transform>();
    }

    void Update()

    {
        //if (Input.GetKey("shift b"))
        //{
        //    tf.localPosition = tf.localPosition = new Vector2(0, speed, 0);
        //}

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        //p causing movement to be disabled.
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (canMoveBadFairy == true)
            {
                canMoveBadFairy = false;
            }
            else
            {
                canMoveBadFairy = true;
            }
        }
        //q should inactivate the game object
        if (Input.GetKeyDown(KeyCode.Q))
        {
            badFairy.SetActive(false);
        }

        if (canMoveBadFairy == true)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");


            transform.Rotate(transform.forward, rotateSpeed * horizontalInput * Time.deltaTime * -1);





            //press up arrow moves sprite up
            transform.Translate(Vector3.right * verticalInput * speed * Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
                GameObject bullet2 = Instantiate(bulletPrefab, bulletSpawn2.position, bulletSpawn2.rotation);
            }






        }

    }
}
