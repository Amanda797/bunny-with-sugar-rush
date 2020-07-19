using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class SneakyPawn : MonoBehaviour
{
    public float speed;
    public float rotateSpeed;
    public Transform target;

    public void Move(float direction)
    {
        //pawn movement
        Vector3 myPos = transform.position;
        myPos += transform.right * speed * direction * Time.deltaTime;
        transform.position = myPos;



    }


    public void Rotate(float direction)
    {
        transform.Rotate(transform.forward * direction * rotateSpeed * Time.deltaTime);
    }

    public void RotateToward(Vector3 direction)
    {
        transform.right = direction;
    }
}

