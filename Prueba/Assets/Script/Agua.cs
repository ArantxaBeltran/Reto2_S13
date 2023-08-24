using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Agua : MonoBehaviour
{
     public  static float pointAgua;
     public KeyCode interactKey = KeyCode.A;
     public bool aguaRecolectada;
     public TextMeshProUGUI scoreAgua;

    

      void Start()
    {
       aguaRecolectada=false;   
    }


        private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" )
        

        {
            if (Input.GetKey(interactKey ) && aguaRecolectada == false && Lago.aguapotable >= 1)
            {
                pointAgua +=1;
                Debug.Log("Player detectado");
                scoreAgua.text = ( "" + pointAgua);
                aguaRecolectada = true;
                
                
            }
            
        }
    }
        private void OnTriggerExit(Collider other)
    {
        
                aguaRecolectada = false;
                
                
     

}
}
