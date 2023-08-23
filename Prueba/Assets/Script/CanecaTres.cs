using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanecaTres : MonoBehaviour
{ 
    public KeyCode interactKeydos;
    


     private void OnTriggerStay(Collider other)
    { 


        if (other.CompareTag("Player") &&   ScoreBasura.scorebasuratotalinfo > 0)
        {

            if (Input.GetKey(interactKeydos) && BasuraTres.pointbasura > 0)
           {
            
            BasuraDos.pointbasura--;
           }  
        }

     }
}
