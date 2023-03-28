using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cutNail : MonoBehaviour
{
    private float fallDelay = 1f;
    private float destroyDelay = 2f;
    public int nailCount = 0;

    [SerializeField] private Rigidbody2D rb;

    public void Cut()
    {
        StartCoroutine(Fall());
        nailCount++; 
    }

    private IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallDelay);
        rb.bodyType = RigidbodyType2D.Dynamic;
        Destroy(gameObject, destroyDelay);
    }
}
