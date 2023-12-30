using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    GameManager gm;

    void Start()
    {
        gm = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    void OnMouseDown()
    {
        if (!gm.isGameActive)
        {
            return;
        }

        gm.Score++;
        Debug.Log(gm.Score);
        Destroy(gameObject);
    }
}
