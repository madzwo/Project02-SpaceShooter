using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
     public Rigidbody2D rb;

    public float enemySpeed;

    public GameObject player;

    public float enemyHealth;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        // Movement
        if (Vector2.Distance(this.transform.position, player.transform.position) < 7)
        {
            Vector2 direction = player.transform.position - transform.position;
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, enemySpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {   
        if (collision.gameObject.tag == "player")
        {
            Destroy(gameObject);   
        }   
    }
}
