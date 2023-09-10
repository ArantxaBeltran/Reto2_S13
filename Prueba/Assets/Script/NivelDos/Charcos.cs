using System.Collections;
using UnityEngine.InputSystem;
using System.Collections.Generic;
using UnityEngine;

public class Charcos : MonoBehaviour
{

   
    public float dañocharco = 1f;
    public KeyCode interactKey = KeyCode.A;
    public GameObject arbusto;
    public static float pointcharco;
    public float pointagua;
    public bool charcopoint = false;
    public Material materialagua;
    public GameObject info;
    private Renderer objectRenderer;



    
    // Start is called before the first frame update
    void Start()
    {
      
      arbusto.SetActive(true);
      objectRenderer = GetComponent<Renderer>();
      info.SetActive(false);
      
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"  )
        

        {
            
            
         LivePlayer.playerSalud -=10f; 
         arbusto.SetActive(false); 

                
                
            
            
        }
    }
        private void OnTriggerExit(Collider other)
    {

        if (charcopoint == true)
        {
             pointcharco++;
             Destroy(info);
             AguaN2.pointAgua --;
             
        }
                
    }



         private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && Keyboard.current.aKey.wasPressedThisFrame && AguaN2.pointAgua == 1 || other.gameObject.tag == "Player" && Gamepad.current.buttonSouth.wasPressedThisFrame && AguaN2.pointAgua == 1)
        

        {
                
        
        
         objectRenderer.material = materialagua; 
         charcopoint = true;
          info.SetActive(true);



            
            
        }
    }


   
            


}
