using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    
    public GameObject Button;
    public GameObject Myplace;
    // Start is called before the first frame update
 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            foreach (var myPlace in GameObject.FindGameObjectsWithTag("Myplace"))
            {
             Instantiate(Button, myPlace.transform.position, transform.rotation);

            }
        }

    }
}
