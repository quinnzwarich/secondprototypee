using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnMoney : MonoBehaviour
{
    public GameObject money;
    public GameObject moneyParent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), 5, Random.Range(-10, 11));
        GameObject clone = (GameObject) Instantiate(money, randomSpawnPosition, Quaternion.identity);
 
        Destroy(clone, 1f);
        
    }
}
