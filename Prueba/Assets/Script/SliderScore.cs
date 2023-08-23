using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class SliderScore : MonoBehaviour
{
    public Slider scorebasura;
    public  static float scorebasurapoint;


   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scorebasurapoint = Basura.pointbasura;
        

        scorebasura.value= scorebasurapoint;
       

    }
}
