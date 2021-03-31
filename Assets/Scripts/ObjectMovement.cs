using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float speed = 2f;
    public float gold = 5;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(Random.Range(-7.21f, 3.66f), -6.1f);
;
    }

    // Update is called once per frame
    void Update()
    {
        speed = Random.Range(1, 5);
        transform.Translate(new Vector2(0, 2f) * speed * gold * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Destroyer" || collision.tag == "bullet")
        {
            Destroy(this.gameObject);
        }
    }
}
