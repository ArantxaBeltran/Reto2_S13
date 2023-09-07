using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanecaTres : MonoBehaviour
{ 
    public KeyCode interactKeytres = KeyCode.T;
    


     private void OnTriggerStay(Collider other)
    { 


        if (other.CompareTag("Player") &&   ScoreBasura.scorebasuratotalinfo > 0)
        {

            if (Input.GetKey(interactKeytres) && BasuraTres.pointbasura > 0)
           {
            
            BasuraTres.pointbasura--;
           }  
        }

     }
}
