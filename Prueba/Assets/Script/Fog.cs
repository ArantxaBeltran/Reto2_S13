
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Rendering;

public class Fog : MonoBehaviour
{
    
    
    public GameObject timer;
    public bool enmarchatime;
    public TextMeshProUGUI timertext;
    void Start()
    {
        RenderSettings.fog = false;
         timer.SetActive (false);
        StartCoroutine( FogTime());
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }




          IEnumerator FogTime()
    {
          while (ScoreBasura.scorebasuratotalinfo < 25)
          {


            yield return new WaitForSeconds(120f);
            RenderSettings.fog = true;
            timertext.enabled=true;
            enmarchatime = true;
            StartCoroutine( menosBasura());
           

           
            timer.SetActive (true);

            yield return new WaitForSeconds(10f);
            RenderSettings.fog = false;
             timertext.enabled=false;
             enmarchatime = false;

            timer.SetActive (false);
             

          }


                IEnumerator menosBasura()
    {
        while (ScoreBasura.scorebasuratotalinfo > 0 && enmarchatime == true)

        {
         

            yield return new WaitForSeconds(1f);
           
            ScoreBasura.scorebasuratotalinfo -= 1;

        }
            


            


        
    }
}
}
