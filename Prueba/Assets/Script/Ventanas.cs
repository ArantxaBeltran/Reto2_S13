using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;

using UnityEngine;

public class Ventanas : MonoBehaviour
{
    public GameObject misiones;
    public GameObject instruc;
    public GameObject creditos;
    public GameObject mapa;
     public GameObject botonsalirmisiones;
     public GameObject botonsalirins;
     
    
    // Start is called before the first frame update
    void Start()
    {
        misiones.SetActive(false);
        instruc.SetActive(false);
        mapa.SetActive(false);

    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Misionesboton()
    {

        misiones.SetActive(true);
         EventSystem.current.SetSelectedGameObject(null); 
        EventSystem.current.SetSelectedGameObject(botonsalirmisiones);
                
    }

     public void Instrucboton()
    {

        instruc.SetActive(true);
         EventSystem.current.SetSelectedGameObject(null); 
        EventSystem.current.SetSelectedGameObject(botonsalirins);
        
    }  

     public void salirboton()
    {

    misiones.SetActive(false);
    instruc.SetActive(false);
    creditos.SetActive(false);
    mapa.SetActive(false);
   

        
    } 
      public void Mapaboton()
    {

        mapa.SetActive(true);
         
        
    } 
 

  

}

