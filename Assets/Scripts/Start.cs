using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public Button startButton;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButton() 
    {
        SceneManager.LoadScene(1);
    }
}
