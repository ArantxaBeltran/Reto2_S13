using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class Crafting : MonoBehaviour
{
     public  static float pointbasuracraf;
     public  static float pointbasura;
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
            if (Keyboard.current.tKey.wasPressedThisFrame && basurarecolectada ==false  && pointbasuracraf <5 || Gamepad.current.buttonWest.wasPressedThisFrame && basurarecolectada ==false  && pointbasuracraf <5)
            {
                pointbasuracraf +=1;
                ScoreBauraNiveldos.scorebasuratotalinfo +=1;
                basurarecolectada = true;
                Destroy(gameObject);
                
            }
            else if (Keyboard.current.tKey.wasPressedThisFrame && basurarecolectada ==false  && pointbasuracraf >= 5 || Gamepad.current.buttonWest.wasPressedThisFrame && basurarecolectada ==false  && pointbasuracraf >= 5)
            {
                pointbasura +=1;
                ScoreBauraNiveldos.scorebasuratotalinfo +=1;
                basurarecolectada = true;
                Destroy(gameObject);
                
            }


            
        }
    }
}
