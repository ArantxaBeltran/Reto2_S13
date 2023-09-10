using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine;

public class ContadorEnergia : MonoBehaviour
{
     public GameObject botonesCraft;
    public GameObject contadorEnergia;
    public Collider  coliderStay;
     public GameObject  partPoof;
     public TextMeshProUGUI instruc;
     public static float pointcaja;
       public GameObject botonplastico;
   

    public static float conEpointPlastico;
    public static float conEpointVidrio;
    public static float conEpointCable;


    // Start is called before the first frame update
    void Start()
    {
        botonesCraft.SetActive(false);
        contadorEnergia.SetActive(false);
       instruc.enabled=false;
        partPoof.SetActive(false);

     

    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        private void OnTriggerEnter(Collider other)
        {
              EventSystem.current.SetSelectedGameObject(null); 
              EventSystem.current.SetSelectedGameObject(botonplastico);

            }


     private void OnTriggerStay(Collider other)
    { 


        if (other.CompareTag("Player") &&  Crafting.pointbasuracraf >= 1 && CraftingDos.pointbasuracrafdos >= 1 && CraftingTres.pointbasuracraftres >= 1 )
        {
            

           botonesCraft.SetActive(true);

       }


     

        if (other.CompareTag("Player")  && conEpointVidrio == 15 && conEpointPlastico == 10 && conEpointCable ==5)
        {
            

            StartCoroutine( PartesContador()); 
           
        



       }




     }
     private void OnTriggerExit(Collider other)
     {

        if (other.CompareTag("Player") &&  conEpointPlastico >=15  && conEpointVidrio >= 10 && conEpointCable >=5 )
        {


            Destroy(coliderStay);
            Destroy(botonesCraft);
             Destroy (instruc);
              pointcaja++;
            

         

       }
   }


    IEnumerator PartesContador()
    {

         
          yield return new WaitForSeconds(1f);

          partPoof.SetActive(true);
          contadorEnergia.SetActive(true);


    
        

   }
}
