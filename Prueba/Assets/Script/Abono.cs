using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Abono : MonoBehaviour
{
    public  static float pointAbono;
     public KeyCode interactKey;
     public bool abonoRecolectada;
     public TextMeshProUGUI scoreAbono;

    

      void Start()
    {
       abonoRecolectada=false;   
    }


     private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" )
        

        {
            if (Input.GetKey(interactKey ) && abonoRecolectada == false )
            {
                pointAbono +=1;
                Debug.Log("Player detectado");
                abonoRecolectada = true;
                scoreAbono.text = ( "" + pointAbono);
                
                
            }
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        
                abonoRecolectada = false;
                
                
    }
}
