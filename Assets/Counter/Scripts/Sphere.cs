using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    private GameManager gm;

    void Start()
    {
        gm = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    void OnMouseDown()
    {
        gm.score++;
        Debug.Log(gm.score);
        Destroy(gameObject);
    }
}
