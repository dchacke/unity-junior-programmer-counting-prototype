using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public bool isGameActive = false;

    [SerializeField] GameObject spherePrefab;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] GameObject gameOverScreen;

    int score;
    public int Score
    {
        get { return score; }
        set {
            if (value < 0)
            {
                GameOver();
                return;
            }

            score = value;
            scoreText.text = "Score: " + score;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = new Vector3(0, -1.0f, 0);
        isGameActive = true;
        InvokeRepeating("SpawnSphere", 0, 1);
        Score = 0;
    }

    void SpawnSphere()
    {
        Instantiate(spherePrefab, new Vector3(Random.Range(-10.0f, 10.0f), 10, 0), spherePrefab.transform.rotation);
    }

    void GameOver()
    {
        isGameActive = false;
        gameOverScreen.SetActive(true);
        CancelInvoke("SpawnSphere");
    }
}
