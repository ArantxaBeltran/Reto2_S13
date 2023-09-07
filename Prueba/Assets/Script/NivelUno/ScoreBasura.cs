using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class ScoreBasura : MonoBehaviour
{
    public Slider scorebasura;
    public Slider scorebasurados;
    public Slider scorebasuratres;
    public Image misioncum;
    public Image insignia;
    public GameObject credits;

    public List<Image> check;
    
  
    public TextMeshProUGUI scorebasuratotal;
    public static float scorebasuratotalinfo;


    public static float scorearbol;

    // Start is called before the first frame update
    void Start()
    {
           misioncum.enabled =false;
           check[0].enabled = false;
           check[1].enabled = false;
           check[2].enabled = false;
           check[3].enabled = false;
           check[4].enabled = false;
           check[5].enabled = false;
           check[6].enabled = false;
           insignia.enabled =false;
           credits.SetActive(false);
           misioncum.enabled=false;



    }

    // Update is called once per frame
    void Update()
    {
              

        scorebasura.value = Basura.pointbasura;
        scorebasurados.value = BasuraDos.pointbasura;
        scorebasuratres.value = BasuraTres.pointbasura;

        scorebasuratotal.text = ( "Residuos: " + scorebasuratotalinfo);


        if (scorebasuratotalinfo == 10 ) //mision uno animales
        {
            misioncum.enabled =true;
             check[0].enabled = true;

        }
        else

        {
            misioncum.enabled =false;
        }

         if (scorebasuratotalinfo == 30 ) //mision dos niebla/lago/reforestacion
        {
            misioncum.enabled =true;
            check[1].enabled = true;
            check[2].enabled = true;
            check[3].enabled = true;

        }
        else

        {
            misioncum.enabled =false;
        }
           if (scorebasuratotalinfo == 40 ) //mision de animales totales
        {
            misioncum.enabled =true;
            check[5].enabled = true;

        }
        else

        {
            misioncum.enabled =false;
        }

           if (scorebasuratotalinfo == 70 ) //mision basura total
        {
            misioncum.enabled =true;
            check[6].enabled = true;

        }
        else

        {
            misioncum.enabled =false;
        }

           if (scorebasuratotalinfo >= 5 ) //mision arboles
        {
            misioncum.enabled =true;
            check[4].enabled = true;

        }
        else

        {
            misioncum.enabled =false;
        }



        if (scorebasuratotalinfo >= 70 && scorebasuratotalinfo >= 5  ) //mision insignia y arboles
        {
            insignia.enabled =true;
            StartCoroutine( CreditosFin()); 
             

        }
        else

        {
            insignia.enabled =false;
        }
        
        











    }


     IEnumerator CreditosFin()
    {

        
             yield return new WaitForSeconds(2f );
             credits.SetActive(true);

             yield return new WaitForSeconds(2f );
             credits.SetActive(false);

           


        
               
       

                

        }

}
