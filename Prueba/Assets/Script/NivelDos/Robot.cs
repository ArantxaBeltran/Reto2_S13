using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    public Transform player;
    public bool attack;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        attack=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


      private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && attack == false)
        

        {
            transform.position = Vector3.MoveTowards(transform.position,new Vector3 (player.position.x,transform.position.y,player.position.z),speed * Time.deltaTime);

            
        }
    }


    private void OnCollisionEnter (Collision other)

    { 
        if (other.gameObject.tag == "Player")
        {
             attack=true;
             LivePlayer.playerSalud -=1f;
        }



       

    }


}
