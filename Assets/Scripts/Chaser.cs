using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Chaser : MonoBehaviour
{
    public float enemySpeed;
    public float enemyAcc;
    public float enemyMaxSpeed;
    public GameObject player;

    void Start()
    {

    }

    void Update()
    {
        enemySpeed += enemyAcc;
        Vector2 direction = player.transform.position - transform.position;
        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, enemySpeed * Time.deltaTime);    
        if(enemySpeed >= enemyMaxSpeed)
        {
            enemySpeed = enemyMaxSpeed;
        }
        if (Vector2.Distance(this.transform.position, player.transform.position) < 1.75)
        {
            SceneManager.LoadScene(2);
        }

    }

}
