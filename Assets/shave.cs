using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class shave : MonoBehaviour
{
    public float timeRemaining = 10;
    public GameObject mask;
    bool pressed;

    [SerializeField] private Camera mainCamera;

    private void timer()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime / 2;
            Debug.Log(timeRemaining);

        } else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 pos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        pos.z = 0f;

        if (pressed)
        {
            GameObject ob = Instantiate(mask, pos, Quaternion.identity);
            ob.transform.parent = GameObject.Find("shave").transform;

            timer(); 
        }
        if (Input.GetMouseButtonDown(0))
        {
            pressed = true;

        } else if (Input.GetMouseButtonUp(0))
        {
            pressed = false;

        }
    }
}
