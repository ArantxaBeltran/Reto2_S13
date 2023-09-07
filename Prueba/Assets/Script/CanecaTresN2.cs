using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanecaTresN2 : MonoBehaviour
{ 
    public KeyCode interactKey = KeyCode.T;
    public GameObject  gemVida;
    public bool masVida = false;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

     private void OnTriggerStay(Collider other)
    { 


        if (other.CompareTag("Player") && ScoreBauraNiveldos.scorebasuratotalinfo > 0 )
        {
            

            if (Input.GetKey(interactKey) && BasuraTresN2.pointbasura == 5)
           {
            
            BasuraUnoN2.pointbasura--;
           }  
              if (Input.GetKey(interactKey) && BasuraTresN2.pointbasura > 0 && masVida ==false && LivePlayer.playerSalud <= 50)
           {
            
            gemVida.SetActive(true);
            masVida=true;
           } 


       }

     }

}
