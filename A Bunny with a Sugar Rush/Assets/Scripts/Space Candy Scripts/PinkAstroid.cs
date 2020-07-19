using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PinkAstroid : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject playerPosition;
    [SerializeField]
    float speed;
    [SerializeField]
    Rigidbody2D Rb;
    public float damage;
    void Start()
    {
        playerPosition = GameObject.Find("Player");
        Vector3 moveDirection = playerPosition.transform.position - transform.position;
        transform.right = moveDirection;
        Rb.AddForce(transform.right * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Health>())
        {
            Health health = collision.gameObject.GetComponent<Health>();
            health.TakeDamage(damage);

        }
    }


}
