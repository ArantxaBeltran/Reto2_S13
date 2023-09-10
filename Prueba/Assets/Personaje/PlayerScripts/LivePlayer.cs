using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;

public class LivePlayer : MonoBehaviour
{  
    public Slider sliderSalud;
    public static float playerSalud = 100;
    public GameObject loselive;
    public Animator animator;
    public string cliplose;
      

    // Start is called before the first frame update
    void Start()
    {
        loselive.SetActive(false);
        animator= GetComponent<Animator>();
        Time.timeScale = 1f;
        
    }

    // Update is called once per frame
    void Update()
    {
        sliderSalud.value = playerSalud;

         if (LivePlayer.playerSalud <= 0 )
        {
            animator.Play(cliplose);
            loselive.SetActive(true);
       

        }
        
        else 
         {
             loselive.SetActive(false);
            
        }
    }

   
}
