using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingTres : MonoBehaviour
{
     public  static float pointbasuracraftres;
     public  static float pointbasuratres;
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
            if (Input.GetKey(interactKey )&& basurarecolectada ==false  && pointbasuracraftres <5)
            {
                pointbasuracraftres +=1;
                ScoreBauraNiveldos.scorebasuratotalinfo +=1;
                basurarecolectada = true;
                Destroy(gameObject);
                
            }
              else if (Input.GetKey(interactKey )&& basurarecolectada ==false  && pointbasuracraftres >=5)
            {
                pointbasuratres +=1;
                ScoreBauraNiveldos.scorebasuratotalinfo +=1;
                basurarecolectada = true;
                Destroy(gameObject);
                
            }
            
        }
    }
}
