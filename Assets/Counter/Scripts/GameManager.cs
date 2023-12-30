using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject spherePrefab;
    [SerializeField] TextMeshProUGUI scoreText;

    int score = 0;
    public int Score
    {
        get { return score; }
        set {
            score = value;
            scoreText.text = "Score: " + score;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnSphere", 0, 1);
    }

    void SpawnSphere()
    {
        Instantiate(spherePrefab, new Vector3(Random.Range(-10.0f, 10.0f), 10, 0), spherePrefab.transform.rotation);
    }
}
