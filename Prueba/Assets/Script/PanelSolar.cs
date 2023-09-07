using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PanelSolar : MonoBehaviour
{
    public GameObject botonesCraft;
    public GameObject panelsolar;
    public GameObject panel;
    public GameObject paneldos;
    public Collider  coliderStay;
    public GameObject  partPoof;
    public TextMeshProUGUI instruc;
   
   

    
    public static float panelsolarpointVidrio;
    public static float panelsolarpointCable;


    // Start is called before the first frame update
    void Start()
    {
        botonesCraft.SetActive(false);
        panelsolar.SetActive(false);
        panel.SetActive(false);
        paneldos.SetActive(false);
        instruc.enabled=false;
        partPoof.SetActive(false);

        

    
      


    
    }

    // Update is called once per frame
    void Update()
    {
        
    }


     private void OnTriggerStay(Collider other)
    { 


        if (other.CompareTag("Player") &&  CraftingDos.pointbasuracrafdos >= 1 && CraftingTres.pointbasuracraftres >= 1  )
        {
            

           botonesCraft.SetActive(true);
            instruc.enabled=true;

       }


     

        if (other.CompareTag("Player")  && panelsolarpointVidrio == 5 && panelsolarpointCable ==5)
        {


           
            

           StartCoroutine( PartesPanel()); 

       }




     }
     private void OnTriggerExit(Collider other)
     {

        if (other.CompareTag("Player")  && panelsolarpointVidrio >= 5 && panelsolarpointCable >=5 )
        {


            Destroy(coliderStay);
            Destroy(botonesCraft);
            GreenHouses.pointGreen++;
            Destroy (instruc);
            

         

       }
   }


    IEnumerator PartesPanel()
    {



         
         
          yield return new WaitForSeconds(1f);

          partPoof.SetActive(true);


         paneldos.SetActive(true);

         panel.SetActive(true);
          
          panelsolar.SetActive(true);



       

        
        

   }
}
