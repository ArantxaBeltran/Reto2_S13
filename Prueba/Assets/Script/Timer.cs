using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public int min;
    public int seg;
    public TMP_Text tiempo;

    private float restante;
    public bool enMarcha;


    // Start is called before the first frame update
    void Awake()
    {
        restante= (min*60) + seg;
        enMarcha = true;

      
    }

    // Update is called once per frame
    void Update()
    {
        if (enMarcha)

        {
            restante -= Time.deltaTime;
            if (restante<1)
            {
                enMarcha = false;

            }

            int tempMin = Mathf.FloorToInt(restante/60);
            int tempSeg = Mathf.FloorToInt(restante%60);
            tiempo.text= string.Format("{00:00}:{01:00}",tempMin,tempSeg); 
        }
        
    }
}
