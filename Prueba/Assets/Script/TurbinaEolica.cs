using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TurbinaEolica : MonoBehaviour
{
    public GameObject botonesCraft;
    public GameObject turbinaEolica;
    public Collider  coliderStay;
     public GameObject  partPoof;
     public TextMeshProUGUI instruc;
      public static float pointturb;
   

    public static float turbEpointPlastico;
    public static float turbEpointVidrio;
  

    // Start is called before the first frame update
    void Start()
    {
        botonesCraft.SetActive(false);
        turbinaEolica.SetActive(false);
        instruc.enabled=false;
        partPoof.SetActive(false);
     

    
    }

    // Update is called once per frame
    void Update()
    {
        
    }


     private void OnTriggerStay(Collider other)
    { 


        if (other.CompareTag("Player") &&  Crafting.pointbasuracraf >= 1 )
        {
            

           botonesCraft.SetActive(true);

       }


     

        if (other.CompareTag("Player")  && turbEpointVidrio == 10 && turbEpointPlastico == 5)
        {
            

          
           StartCoroutine( PartesTrubina()); 
         
        



       }




     }
     private void OnTriggerExit(Collider other)
     {

        if (other.CompareTag("Player") &&  turbEpointPlastico >=10  && turbEpointVidrio >= 5 )
        {



            pointturb++;
            Destroy(coliderStay);
            Destroy(botonesCraft);
        
             Destroy (instruc);
            

         

       }
   }


    IEnumerator PartesTrubina()
    {

         
          yield return new WaitForSeconds(1f);

          partPoof.SetActive(true);
          turbinaEolica.SetActive(true);




       

        
        

   }
}
