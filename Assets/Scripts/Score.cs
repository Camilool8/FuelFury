using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int ScoreValue = 0;
    Text ScoreText;
    public Rigidbody2D character;
    public float Timer=0;
    

    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GetComponent<Text>();
        

        
    }

    // Update is called once per frame
    void Update()
    {
        
        ScoreText.text = "Score: " + ScoreValue;
        if(ScoreValue <= 0)
        {
            character.gravityScale = 8;
        }

       
       
    }

    
}