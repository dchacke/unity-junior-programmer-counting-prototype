using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    GameManager gm;

    void Start()
    {
        gm = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (!gm.isGameActive)
        {
            return;
        }

        gm.Score--;
        Destroy(other.gameObject);
        Debug.Log(gm.Score);
    }
}
