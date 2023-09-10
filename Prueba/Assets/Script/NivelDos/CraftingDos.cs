using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class CraftingDos : MonoBehaviour
{
     public  static float pointbasuracrafdos;
     public  static float pointbasurados;
     public KeyCode interactKey = KeyCode.T;
     public bool basurarecolectada;
    

      void Start()
    {
     basurarecolectada=false;   
    }


      private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" )
        

        {
            if (Keyboard.current.tKey.wasPressedThisFrame && basurarecolectada ==false  && pointbasuracrafdos <5 || Gamepad.current.buttonWest.wasPressedThisFrame && basurarecolectada ==false  && pointbasuracrafdos <5 )
            {
                pointbasuracrafdos +=1;
                ScoreBauraNiveldos.scorebasuratotalinfo +=1;
                basurarecolectada = true;
                Destroy(gameObject);
                
            }
              else if ( Keyboard.current.tKey.wasPressedThisFrame && basurarecolectada ==false  && pointbasuracrafdos >= 5 || Gamepad.current.buttonWest.wasPressedThisFrame && basurarecolectada ==false  && pointbasuracrafdos >= 5)
            {
                pointbasurados +=1;
                ScoreBauraNiveldos.scorebasuratotalinfo +=1;
                basurarecolectada = true;
                Destroy(gameObject);
                
            }
            
        }
    }
}
