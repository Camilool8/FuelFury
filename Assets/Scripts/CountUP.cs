using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountUP : MonoBehaviour
{
    public float timeStart;
    public Text textbox;
    

    public static bool pausa = false;
    // Start is called before the first frame update
    void Start()
    {
        textbox.text = timeStart.ToString("F0");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!pausa)
        {
            timeStart += Time.deltaTime;
            textbox.text = timeStart.ToString("F0");
            
        }
    }
    public void timerButton()
    {
        pausa = !pausa;
    }
}
