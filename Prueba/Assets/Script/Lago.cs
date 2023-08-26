using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lago : MonoBehaviour
{
    public Animator animator;
    public  static int aguapotable;
    public GameObject colliderlago;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
         aguapotable = 0;
         colliderlago.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreBasura.scorebasuratotalinfo >= 16 )
        {
            animator.SetBool("EtapaUno", true); 
            colliderlago.SetActive(false);
        }
        if (ScoreBasura.scorebasuratotalinfo < 16 )
        {
            animator.SetBool("EtapaUno", false);
        }
        if (ScoreBasura.scorebasuratotalinfo >= 30 )
        {
            animator.SetBool("Etapados", true);
            aguapotable = 1;
        }
         if (ScoreBasura.scorebasuratotalinfo < 30 )
        {
            animator.SetBool("Etapados", false);
             aguapotable = 0;
        }
    }
}
