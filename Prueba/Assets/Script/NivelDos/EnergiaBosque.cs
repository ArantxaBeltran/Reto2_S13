using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergiaBosque : MonoBehaviour
{
    public Light directL;
    public Light linterna;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
     if (ContadorEnergia.pointcaja >=1)
     {
        directL.intensity = 0.8f;
        linterna.enabled =false;    

     
     }  

    }
}
