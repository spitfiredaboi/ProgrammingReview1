using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pickup : MonoBehaviour
{

    public BoxCollider2D collide;
    public SpriteRenderer sr;
    public GameObject player;
    public GameObject[] enemy;

    public void Awake()
    {
        enemy[1] = GameObject.Find("Enemy");
        collide = GetComponent<BoxCollider2D>();
        sr = GetComponent<SpriteRenderer>();
        player = GameObject.Find("Player");
    }    

    public virtual void Activate()
    {

    }

    public IEnumerator DelayedDestroy()
    {
        collide.enabled = false;
        sr.enabled = false;
        yield return new WaitForSeconds(5);
        Player.poweredUp = false;
        Enemy.speed = 3;
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        Activate();
        StartCoroutine(DelayedDestroy());
    }
}
