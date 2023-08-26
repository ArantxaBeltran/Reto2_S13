using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CambiodeEscena : MonoBehaviour
{
    public string sceneName;
    public string sceneNameInicio;
    public GameObject escscreen;
    public KeyCode interactKey;
    public bool jugando;



       void Start()
    {
         escscreen.SetActive(false);
         jugando = true;

    }

    void Update()
    {
      Esc();
    }


    

   public void  Play()
   {
            
        SceneManager.LoadScene(sceneName);
       
   }

    public void  Salir()
   {       
    
        Application.Quit();
   }

      public void Restart ()
   {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  
        Time.timeScale = 1f;
        ScoreBasura.scorebasuratotalinfo = 0;
        Basura.pointbasura = 0;
        BasuraDos.pointbasura = 0;
        BasuraTres.pointbasura = 0;
        Abono.pointAbono=0;
        Agua.pointAgua=0;


   }

   public void Inicio()
   {
      SceneManager.LoadScene(sceneNameInicio);
   }

   public void Esc()
   {
     if  (Input.GetKey(interactKey))
     {
          escscreen.SetActive(true);
           Time.timeScale = 0f;
           jugando = false;
     }

     else if (jugando == true)

      {
           Time.timeScale = 1f;
      }

     


   }
    public void salirboton()
    {
        escscreen.SetActive(false);
        jugando = true;

    }


       

    
}
