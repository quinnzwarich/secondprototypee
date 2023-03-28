using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour
{

    private bool pressed = false;
    private Vector3 offset;

    [SerializeField] private Camera mainCamera;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (pressed)
        {
            transform.position = mainCamera.ScreenToWorldPoint(Input.mousePosition) + offset;
        }

        Vector3 pos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        pos.z = 0f;


        if (Input.GetMouseButtonDown(0))
        {
            offset = transform.position - mainCamera.ScreenToWorldPoint(Input.mousePosition);

            pressed = true;

        }
        else if (Input.GetMouseButtonUp(0))
        {
            pressed = false;

        }
    }
}
