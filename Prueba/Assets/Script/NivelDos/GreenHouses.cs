using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenHouses : MonoBehaviour
{
    public Light luzCanecas;
    public Light luzInvernadero;
    public Light luzBombaAgua;
    public GameObject collidersGreenHouse;
    public static float pointGreen;
    // Start is called before the first frame update
    void Start()
    {
            luzCanecas.enabled = false;
        luzInvernadero.enabled = false;
        luzBombaAgua.enabled = false;

        collidersGreenHouse.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
             if (pointGreen == 1)
        {
            

          
          luzCanecas.enabled = true;
          luzInvernadero.enabled = true;
          luzBombaAgua.enabled = true;
          collidersGreenHouse.SetActive(false);


       }
    }
}
