using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class ScoreBasura : MonoBehaviour
{
    public Slider scorebasura;
    public Slider scorebasurados;
    public Slider scorebasuratres;
    
  
    public TextMeshProUGUI scorebasuratotal;
    public static float scorebasuratotalinfo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
              

        scorebasura.value = Basura.pointbasura;
        scorebasurados.value = BasuraDos.pointbasura;
        scorebasuratres.value = BasuraTres.pointbasura;

        scorebasuratotal.text = (scorebasuratotalinfo+ " / 50");







    }
}
