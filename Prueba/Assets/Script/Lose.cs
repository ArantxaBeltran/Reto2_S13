using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class Lose : MonoBehaviour
{
    public GameObject botonreiniciar;
    public GameObject botonsalir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        if (LivePlayer.playerSalud <= 0 )
        {

            Time.timeScale = 0f;
            EventSystem.current.SetSelectedGameObject(null); 
           EventSystem.current.SetSelectedGameObject(botonreiniciar);       

        }




    }
}
