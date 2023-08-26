using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderArboles : MonoBehaviour
{
    public GameObject colliderArboles;
   
    // Start is called before the first frame update
    void Start()
    {
         colliderArboles.SetActive(true);
       
        

    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreBasura.scorebasuratotalinfo == 30)
        {
            colliderArboles.SetActive(false);
           
          

        }
        
    }

    
}
