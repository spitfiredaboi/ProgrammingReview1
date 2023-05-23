using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float horizontalInput;
    public float verticalInput;
    public float speed = 5;
    public float respawnTime;
    static public float score;
    static public float life;
    public bool dead = false;
    public SpriteRenderer sr;
    public Sprite normal;
    public Sprite death;
    public Sprite buff;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = normal;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        if (!dead)
        {
            transform.Translate(Vector2.right * speed * horizontalInput * Time.deltaTime);
            transform.Translate(Vector2.up * speed * verticalInput * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("snake"))
        {
            StartCoroutine(Deadguy());
        }
    }

    IEnumerator Deadguy()
    {
        life--;
        dead = true;
        sr.sprite = death;
        yield return new WaitForSeconds(respawnTime);
        dead = false;
        sr.sprite = normal;
        transform.position = new Vector2(Random.Range(-12, 12), Random.Range(-5, 5));
    }
}
