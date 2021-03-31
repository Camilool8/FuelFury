using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGenerator : MonoBehaviour
{
    public float random;
    public GameObject[] Globo1;
    public GameObject[] Globo2;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GlobitoSpam", 1, 1);
        InvokeRepeating("GlobitoGold", 1, 0.4f);
        InvokeRepeating("Scoredecrease", 10, 10);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GlobitoSpam()
    {

        Instantiate(Globo1[0], transform.position, Quaternion.identity);
        

    }

    void GlobitoGold()
    {

        Instantiate(Globo2[0], transform.position, Quaternion.identity);


    }

    void Scoredecrease()
    {
        Score.ScoreValue -= 5;
    }
   
}
