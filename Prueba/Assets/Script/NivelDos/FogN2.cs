using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Rendering;

public class FogN2 : MonoBehaviour
{

    public float dañoneblina = 10f;
    public bool damage = false;
    public TextMeshProUGUI zonacontArboles;
    
    // Start is called before the first frame update
    void Start()
    {
    
         RenderSettings.fog = false;
         zonacontArboles.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Charcos.pointcharco == 4)
        {
          gameObject.SetActive(false);
          RenderSettings.fog = false;  
          zonacontArboles.enabled = false;



        }
        
    }

        private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" )
        

        {
            
            
         StartCoroutine( menosVida()); 
         RenderSettings.fog = true;  
                
                
            
            
        }
    }
        private void OnTriggerExit(Collider other)
    {
        
        RenderSettings.fog = false;  
        damage=false;

         StopCoroutine( menosVida()); 
                
    }

    IEnumerator menosVida()
    {

        if (damage == false)
        {
             yield return new WaitForSeconds(1f );
            LivePlayer.playerSalud -= dañoneblina;  
            yield return new WaitForSeconds(1f );
            damage=true;



        }
               
       

                

        }


   
            


            


        
    }

