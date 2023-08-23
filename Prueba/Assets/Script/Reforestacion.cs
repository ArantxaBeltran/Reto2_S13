using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Reforestacion : MonoBehaviour
{
     public Material materialverde;
     public KeyCode interactKey;
    private Renderer objectRenderer;
    public GameObject tronco;
    public GameObject medArbol;
    public GameObject granArbol;


        public Slider slidertiempo;
        public float decreaseRate = 0.1f;
        public bool sumatiempo;



    // Start is called before the first frame update
    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        tronco.SetActive(false);
        medArbol.SetActive(false);
        granArbol.SetActive(false);
        slidertiempo.gameObject.SetActive(false);
        sumatiempo =false;



    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player" )
        slidertiempo.gameObject.SetActive(true);
               

        {
            if (Input.GetKey(interactKey ) )
            {
                 StartCoroutine(DecreaseSlider());
                
            }
            if (slidertiempo.value == 0 )
            {
                objectRenderer.material = materialverde; 
               slidertiempo.gameObject.SetActive(false);   
               StopCoroutine(DecreaseSlider());
                
            }



            if (Input.GetKey(interactKey) && Agua.pointAgua == 1 && slidertiempo.value == 0 && sumatiempo == false && Abono.pointAbono == 0 )
            {

                slidertiempo.value=10;

                slidertiempo.gameObject.SetActive(true);

                sumatiempo =true;

                StartCoroutine(troncotime()); 

                

            }

              if (Input.GetKey(interactKey)  && slidertiempo.value == 0 && sumatiempo == false  && Abono.pointAbono == 1 && Agua.pointAgua == 2)
            {

                slidertiempo.value=10;

                slidertiempo.gameObject.SetActive(true);

                sumatiempo =true;


                StartCoroutine(medArboltime());              
                

            }
               if (Input.GetKey(interactKey)  && slidertiempo.value == 0 && sumatiempo == false  && Abono.pointAbono == 2 && Agua.pointAgua == 3)
            {

                slidertiempo.value=10;

                slidertiempo.gameObject.SetActive(true);

                sumatiempo =true;

                StartCoroutine(grandArboltime());              
                

            }


             



            
        }

               



         IEnumerator DecreaseSlider()
    {
        while (slidertiempo.value > 0)
        {
             slidertiempo.value -= decreaseRate;
            yield return new WaitForSeconds(0.1f);// Esperar un segundo antes de disminuir nuevamente
        }
    }

          IEnumerator troncotime()
    {
        
        
            yield return new WaitForSeconds(3f);
            tronco.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            sumatiempo = false;

        
    }

          IEnumerator medArboltime()
    {
        
        
             tronco.SetActive(false);           
            yield return new WaitForSeconds(3f);
            medArbol.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            sumatiempo = false;


        
    }

          IEnumerator grandArboltime()
    {
        
        
            medArbol.SetActive(false);
            yield return new WaitForSeconds(3f);
            granArbol.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            sumatiempo = false;


        
    }
}
}




