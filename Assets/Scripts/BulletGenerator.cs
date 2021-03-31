using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    public GameObject[] Bullet;
    public bool start = false;
    // Start is called before the first frame update

    void Start()
    {
        
        InvokeRepeating("Balita", 1, 0.8f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Balita()
    {

        Instantiate(Bullet[0], transform.position, Quaternion.identity);


    }
}
