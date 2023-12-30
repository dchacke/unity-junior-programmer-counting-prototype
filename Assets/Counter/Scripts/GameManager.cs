using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject spherePrefab;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnSphere", 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnSphere()
    {
        Instantiate(spherePrefab, new Vector3(Random.Range(-10.0f, 10.0f), 10, 0), spherePrefab.transform.rotation);
    }
}
