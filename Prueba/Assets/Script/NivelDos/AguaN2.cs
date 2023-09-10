using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.InputSystem;
using UnityEngine;

public class AguaN2 : MonoBehaviour
{
    public  static float pointAgua;
     public KeyCode interactKey = KeyCode.A;
     public bool aguaRecolectada;
     public TextMeshProUGUI pointAguatext;
     

    

      void Start()
    {
       aguaRecolectada=false;   
    }
     void Update()
    {
        pointAguatext.text =("" + pointAgua);
    }


private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" )
        

        {
            

            if (Keyboard.current.aKey.wasPressedThisFrame && aguaRecolectada == false && LagoN2.aguapotable >= 1 || Gamepad.current.buttonSouth.wasPressedThisFrame  && aguaRecolectada == false && LagoN2.aguapotable >= 1  ) 
            {
                pointAgua +=1;
                Debug.Log("Player detectado");
                aguaRecolectada = true;
                
                
            }
            
        }
    }
    
private void OnTriggerExit(Collider other)
    {
        
                aguaRecolectada = false;
                
                
     

    }

 private void OnTriggerEnter(Collider other)
    {
        
        if (LagoN2.aguapotable < 1)
            
            {
                LivePlayer.playerSalud -=10f;
            }
                
                
            
                
    }

}
