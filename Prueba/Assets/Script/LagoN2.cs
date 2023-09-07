using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LagoN2 : MonoBehaviour
{
    public Animator animator;
    public  static int aguapotable;
    public TextMeshProUGUI zonacontAgua;

    
    


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
         aguapotable = 0;
         zonacontAgua.enabled = true;
         
        
    }

    // Update is called once per frame
    void Update()
    {
         if (ScoreBasura.scorebasuratotalinfo < 16 )
        {
            animator.SetBool("EtapaUno", false);
        }
        if (ScoreBasura.scorebasuratotalinfo >= 16 )
        {
            animator.SetBool("EtapaUno", true);     
            
        }
         if (ScoreBasura.scorebasuratotalinfo < 30 )
        {
            animator.SetBool("Etapados", false);
             aguapotable = 0;

        }
       
        if (ScoreBasura.scorebasuratotalinfo >= 30 )
        {
            animator.SetBool("Etapados", true);
            aguapotable = 1;
            zonacontAgua.enabled = false;
        }
        
    }
}
