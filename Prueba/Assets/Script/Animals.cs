using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals : MonoBehaviour
{
    public List<GameObject> animals;
    // Start is called before the first frame update
    void Start()
    {
         DeactivateAllAnimals();
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreBasura.scorebasuratotalinfo == 10)
        {
            animals[0].SetActive (true);
            animals[1].SetActive (true);
            animals[2].SetActive (true);
            animals[3].SetActive (true);
            animals[4].SetActive (true);

        }
         if (ScoreBasura.scorebasuratotalinfo > 10 && ScoreBasura.scorebasuratotalinfo < 20)
        {
            animals[5].SetActive (true);
            animals[6].SetActive (true);
            animals[7].SetActive (true);
            animals[8].SetActive (true);
            animals[9].SetActive (true);

        }

         if (ScoreBasura.scorebasuratotalinfo > 20 && ScoreBasura.scorebasuratotalinfo < 30)
        {
            animals[10].SetActive (true);
            animals[11].SetActive (true);
            animals[12].SetActive (true);
            animals[13].SetActive (true);
            animals[14].SetActive (true);

        }
        if (ScoreBasura.scorebasuratotalinfo > 40 && ScoreBasura.scorebasuratotalinfo <= 50)
        {
            animals[15].SetActive (true);
            animals[16].SetActive (true);
            animals[17].SetActive (true);
            animals[18].SetActive (true);
            animals[19].SetActive (true);

        }
    }

     private void DeactivateAllAnimals()
    {
        foreach (GameObject animal in animals)
        {
            animal.SetActive(false);
        }
    }
}
