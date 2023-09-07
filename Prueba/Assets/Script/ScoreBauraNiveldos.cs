using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class ScoreBauraNiveldos : MonoBehaviour
{
    public Slider scorebasura;
    public Slider scorebasurados;
    public Slider scorebasuratres;
    public Slider calidadAire;
    public Image misioncum;
    public bool misioncump;
    public Image insignia;
    public TextMeshProUGUI pointCraf;
     public TextMeshProUGUI pointCrafdos;
     public TextMeshProUGUI pointCraftres;

    public List<Image> check;
    
  
    public TextMeshProUGUI scorebasuratotal;
    public static float scorebasuratotalinfo;


    public static float scorearbol;

    // Start is called before the first frame update
    void Start()
    {
           
           check[0].enabled = false;
           check[1].enabled = false;
           check[2].enabled = false;
           check[3].enabled = false;
           check[4].enabled = false;
           check[5].enabled = false;
           check[6].enabled = false;
           misioncum.enabled = false;
           calidadAire.value =0;
          
    
           insignia.enabled =false;
            



    }

    // Update is called once per frame
    void Update()
    {
              

        scorebasura.value = Crafting.pointbasura + BasuraUnoN2.pointbasura + CraftingTres.pointbasuratres +CraftingDos.pointbasurados;
        scorebasurados.value = BasuraDosN2.pointbasura ;
        scorebasuratres.value = BasuraTresN2.pointbasura ;
        pointCraf.text= ( Crafting.pointbasuracraf + "/5"); 
        pointCrafdos.text= ( CraftingDos.pointbasuracrafdos + "/5"); 
        pointCraftres.text= ( CraftingTres.pointbasuracraftres + "/5"); 
         


        scorebasuratotal.text = ( "Residuos: " + scorebasuratotalinfo);






        if (GreenHouses.pointGreen >= 1 ) //mision uno panel solar
        {
            
             check[0].enabled = true;
            

            
            
                       
             


        }
       

         if (scorebasuratotalinfo >= 29 ) //mision de limpieza lago
        {
            
            check[1].enabled = true;
           
             
          

        }
       
           if (Charcos.pointcharco == 4) //mision de descontamiancion agua
        {
            check[2].enabled = true;
             
           
        }
            if (TurbinaEolica.pointturb >= 1) //mision de descontamiancion agua
        {
            check[3].enabled = true;
              
              calidadAire.value = 0.1f * Time.deltaTime;
           

        }

           if (ContadorEnergia.pointcaja >= 1) //mision caja de energia
        {
            check[4].enabled = true;
             
        

        }
      

           if (scorebasuratotalinfo >= 40 ) //mision animales
        {
           
            check[5].enabled = true;
              
        

        }
      
           if (scorebasuratotalinfo >= 80 ) //mision basura total
        {
           
            check[6].enabled = true;
              
        

        }
     



        if (scorebasuratotalinfo >= 80 && GreenHouses.pointGreen >= 1 && Charcos.pointcharco == 4 && TurbinaEolica.pointturb >= 1 && ContadorEnergia.pointcaja >= 1) // total misones
        {
            insignia.enabled =true;
             

        }
        else

        {
            insignia.enabled =false;
        }

    }

}


