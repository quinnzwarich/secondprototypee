using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class placeHat : MonoBehaviour
{
    private bool placed = false;
    private float timeRemaining = 10;

    void OnCollisionEnter2D(Collision2D collision)
    {
        placed = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (placed)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime * 4;
                
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            }
        }
    }
}
