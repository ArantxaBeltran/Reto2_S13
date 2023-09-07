using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LivePlayer : MonoBehaviour
{  
    public Slider sliderSalud;
    public static float playerSalud = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sliderSalud.value = playerSalud;
    }
}
