using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BotonesPanelSolar : MonoBehaviour
{

    public Texture2D cursorNormal;
    public Texture2D cursorSobreBoton;
    // Start is called before the first frame update
    void Start()
    {
         Cursor.SetCursor(cursorNormal, Vector2.zero, CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BotonPlastico()
    
    {
        if (Crafting.pointbasuracraf > 0)
        {
         Crafting.pointbasuracraf--;  
         TurbinaEolica.turbEpointPlastico++; 
         ContadorEnergia.conEpointPlastico++;

         
        }
       
    }

     public void BotonVidrio()
    
    {
        if (CraftingDos.pointbasuracrafdos > 0)
        {
         CraftingDos.pointbasuracrafdos--;   
         PanelSolar.panelsolarpointVidrio ++;
         TurbinaEolica.turbEpointVidrio++; 
         ContadorEnergia.conEpointVidrio++;

        
        }

       
    }

     public void BotonCable()
    
    {
        if (CraftingTres.pointbasuracraftres > 0)
        {
         CraftingTres.pointbasuracraftres--;   
         PanelSolar.panelsolarpointCable ++;
         ContadorEnergia.conEpointCable++;
        
        }

       
    }

    public void pointEnter ()
    {
         Cursor.SetCursor(cursorSobreBoton, Vector2.zero, CursorMode.Auto);
        
    }

    public void pointExit()
    {
        Cursor.SetCursor(cursorNormal, Vector2.zero, CursorMode.Auto);
    }
}
