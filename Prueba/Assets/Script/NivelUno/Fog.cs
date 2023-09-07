
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
    public GameObject fog;
    void Start()
    {
        RenderSettings.fog = false;
         timer.SetActive (false);

        StartCoroutine( FogTime());

         

        
       
        


    }

    // Update is called once per frame
    void Update()
    {

          if (ScoreBasura.scorebasuratotalinfo >= 25)
         {
             Destroy(gameObject);
             Debug.Log("no niebla");
         }
        
    }




          IEnumerator FogTime()
    {       
            while (ScoreBasura.scorebasuratotalinfo < 25)

            {
                 yield return new WaitForSeconds(150f);
            RenderSettings.fog = true;
            timertext.enabled=true;
            enmarchatime = true;
            timer.SetActive (true);

            StartCoroutine( menosBasura());
           

           
            

            yield return new WaitForSeconds(10f);
            RenderSettings.fog = false;
             timertext.enabled=false;
             enmarchatime = false;

            timer.SetActive (false);

             

            }

           

           

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
