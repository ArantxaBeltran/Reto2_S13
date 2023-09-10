using System.Collections;
using System.Collections.Generic;

using UnityEngine.EventSystems;

using UnityEngine;

public class UIBottons : MonoBehaviour
{

    public GameObject firstCanvas;
    public GameObject fogataOptions;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        private void OnTriggerEnter(Collider other)
        {
            OpcionesCanvas();
        }

    public void OpcionesCanvas()
    {
        EventSystem.current.SetSelectedGameObject(null); 
        EventSystem.current.SetSelectedGameObject(firstCanvas);   
    }

    private void OnTriggerExit(Collider other)
        {
            EventSystem.current.SetSelectedGameObject(null); 
        }
}
