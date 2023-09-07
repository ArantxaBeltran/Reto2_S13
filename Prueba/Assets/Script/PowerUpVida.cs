using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpVida : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    { 


        if (other.CompareTag("Player") )
        {
            

            if ( LivePlayer.playerSalud <= 50)
        
           {      
             LivePlayer.playerSalud += 5;
             
           } 


       }

     }
      private void OnTriggerExit(Collider other)
    { 


    
             gameObject.SetActive(false); 

    }
}