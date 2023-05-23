using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI lifeText;
    public float life;
    public float score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        life = Player.life;
        score = Player.score;

        lifeText.text = ("Lives:" + life);
        scoreText.text = ("Score: " + score);
    }
}
