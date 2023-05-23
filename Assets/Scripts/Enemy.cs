using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public GameObject player;
    public Vector2 ugh = Vector2.zero;
    public float speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }
    
    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(ugh * Time.deltaTime * speed);

        ugh = (player.transform.position - transform.position).normalized;
    }
}
