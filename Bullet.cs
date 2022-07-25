using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float bulletSpeed = 3f;
    float xspeed;


    Rigidbody2D myRigidbody2D;
    PlayerMovment player;

    void Start()
    {     
        myRigidbody2D = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerMovment>();
        xspeed = player.transform.localScale.x * bulletSpeed;
    }

    void Update()
    {   
        myRigidbody2D.velocity = new Vector2(xspeed, 0f);
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Enemies")
        {
            Destroy(other.gameObject, 0);
        }
        Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D other) {
        Destroy(gameObject);
    }
}
