using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Coronafrases : MonoBehaviour
{
    public List<string> quotes;
    public Text Quote;
    public Text Crono;

    float timer;
    int quotePosition;
    bool stop;


    // Start is called before the first frame update
    void Start()
    {
        timer = 10f;

        for (int y = 0; y <= 9; y++)
        {
            print(quotes[y]);
        }

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Quote.text = quotes[quotePosition];
        Crono.text = timer.ToString();


        if (stop == false)
        {
            timer -= Time.deltaTime;

        }


        if (timer < 0)
        {
            if(quotePosition < 9)
            {
                quotePosition = quotePosition + 1;
                timer = 10;
            }
            else
            {
                quotePosition = 0;
                timer = 10;
            }


        }



    }

    public void PausarReanudar()
    {
        if (stop)
        {
            stop = false;
        }
        else
        {
            stop = true;
        }
    }

    public void Aleatorio()
    {
        quotePosition = Random.Range(0, 9);
    }
    
}
