using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasuraUnoN2 : MonoBehaviour
{
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
            if (Input.GetKey(interactKey )&& basurarecolectada ==false  && pointbasura <=5)
            {
                pointbasura +=1;
                ScoreBauraNiveldos.scorebasuratotalinfo +=1;
                Debug.Log("Player detectado" + pointbasura);
                basurarecolectada = true;
                Destroy(gameObject);
                
            }
            
        }
    }
}