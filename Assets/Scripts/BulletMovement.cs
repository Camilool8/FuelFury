using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = -transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "globo")
        {
            Destroy(gameObject);
            //+1 punto (script)
            Score.ScoreValue += 1;
        }
        else if (collision.tag == "gold")
        {
            Destroy(gameObject);
            // +5 puntos (script)
            Score.ScoreValue += 10;
        }
    }
}
