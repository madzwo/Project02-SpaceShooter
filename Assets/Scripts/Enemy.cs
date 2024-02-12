using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Enemy : MonoBehaviour
{
    public float enemySpeed;

    public GameObject player;

    public float enemyHealth;

    void Start()
    {

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
            SceneManager.LoadScene(2);
        }   
        if (collision.gameObject.tag == "bullet")
        {
            Destroy(gameObject);
            Destroy(collision);
        } 
    }
}
