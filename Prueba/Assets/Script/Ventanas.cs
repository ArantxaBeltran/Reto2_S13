using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ventanas : MonoBehaviour
{
    public GameObject misiones;
    public GameObject instruc;
    // Start is called before the first frame update
    void Start()
    {
        misiones.SetActive(false);
        instruc.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Misionesboton()
    {

        misiones.SetActive(true);
        
    }

     public void Instrucboton()
    {

        instruc.SetActive(true);
        
    }  

     public void salirboton()
    {

    misiones.SetActive(false);
    instruc.SetActive(false);
        
    } 

}
