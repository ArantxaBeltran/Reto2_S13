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
        LivePlayer. playerSalud = 100;

       
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
        ScoreBauraNiveldos.scorebasuratotalinfo = 0;
        GreenHouses.pointGreen=0;
        Charcos.pointcharco=0;
        ContadorEnergia.pointcaja=0;
        TurbinaEolica.pointturb=0;
        BasuraUnoN2.pointbasura=0;
        BasuraDosN2.pointbasura=0;
        BasuraTresN2.pointbasura=0;
        Crafting.pointbasura=0;
        CraftingDos.pointbasurados=0;
        CraftingTres.pointbasuratres=0;
        Crafting.pointbasuracraf=0;
        CraftingDos.pointbasuracrafdos=0;
        CraftingTres.pointbasuracraftres=0;
        AguaN2.pointAgua=0;
        LivePlayer. playerSalud = 100;



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

    public void Jugarescena()
    {
        escscreen.SetActive(false);
        Time.timeScale = 1f;

    }


       

    
}
