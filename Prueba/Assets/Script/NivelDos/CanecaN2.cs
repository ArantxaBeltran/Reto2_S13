using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class CanecaN2 : MonoBehaviour
{   

    public KeyCode interactKey = KeyCode.T;
    public GameObject  gemVida;
    public bool masVida = false;
   

    // Start is called before the first frame update
    void Start()
    {
        gemVida.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

     private void OnTriggerStay(Collider other)
    { 


        if (other.CompareTag("Player") && ScoreBauraNiveldos.scorebasuratotalinfo > 0 )
        {
            

            if (Keyboard.current.tKey.wasPressedThisFrame && BasuraUnoN2.pointbasura <= 5 || Gamepad.current.buttonWest.wasPressedThisFrame && BasuraUnoN2.pointbasura <= 5 )
           {
            
            BasuraUnoN2.pointbasura--;
           
           }  

             if (Keyboard.current.tKey.wasPressedThisFrame && BasuraUnoN2.pointbasura > 0 && masVida ==false && LivePlayer.playerSalud <= 50 || Gamepad.current.buttonWest.wasPressedThisFrame  && BasuraUnoN2.pointbasura > 0 && masVida ==false && LivePlayer.playerSalud <= 50 )
           {
            
            gemVida.SetActive(true);
             BasuraUnoN2.pointbasura--;
            masVida=true;
           }  


       }

     }

}
