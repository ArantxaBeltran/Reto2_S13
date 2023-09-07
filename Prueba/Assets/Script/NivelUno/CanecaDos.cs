using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanecaDos : MonoBehaviour
{
   
    public KeyCode interactKeydos = KeyCode.T;
    


     private void OnTriggerStay(Collider other)
    { 


        if (other.CompareTag("Player") &&   ScoreBasura.scorebasuratotalinfo > 0)
        {

            if (Input.GetKey(interactKeydos) && BasuraDos.pointbasura > 0)
           {
            
            BasuraDos.pointbasura--;
           }  
        }

     }

}
