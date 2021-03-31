using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MouseMovement1 : MonoBehaviour
{
    public GameObject playerGameobject;
    public Rigidbody2D CharacterMovement;
    public GameObject MainMenu;
    public GameObject menuGameOver;
    public GameObject winner;
    public bool start = false;
    public bool gameOver = false;
    float Speed;
    
    
    


    // Start is called before the first frame update
    void Start()
    {
        CharacterMovement = GetComponent<Rigidbody2D>();
        Speed = 15f;
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (start == false)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                start = true;
                Time.timeScale = 1;
            }
        }

       

        if (start == true && gameOver == false && !Pausa.pause)
        {
            MainMenu.SetActive(false);

            

           


            
            



        }

        if (Score.ScoreValue >= 500)
        {
            winner.SetActive(true);
            Time.timeScale = 0;

        }
        

        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "limit")
        {
            gameObject.SetActive(false);
            gameOver = true;
            GameOver();
            
            Time.timeScale = 1;

        }
    }

    public void Reset()
    {
        SceneManager.LoadScene("SampleScene");
        Score.ScoreValue = 1;

    }

    public void GameOver()
    {
        
            menuGameOver.SetActive(true);
            Time.timeScale = 0;


        
    }

    public void UP()
    {
        playerGameobject.transform.position += Vector3.up * Speed * Time.deltaTime;
    }

    public void DOWN()
    {
        playerGameobject.transform.position += Vector3.down * Speed * Time.deltaTime;
    }
    


}
