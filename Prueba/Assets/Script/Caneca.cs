using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caneca : MonoBehaviour
{
    public KeyCode interactKey = KeyCode.T;
   





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


        if (other.CompareTag("Player") && ScoreBasura.scorebasuratotalinfo > 0 )
        {
            

            if (Input.GetKey(interactKey) && Basura.pointbasura > 0)
           {
            
            Basura.pointbasura--;
           }  


       }

     }


}
