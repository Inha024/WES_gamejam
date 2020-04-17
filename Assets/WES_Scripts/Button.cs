using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    float curDist = 5;
    GameObject[] Items;
    GameObject Spikes;

    // Use this for initialization
    void Start()
    {
        Items = GameObject.FindGameObjectsWithTag("Item");
        curDist = 5;

        foreach (GameObject item in Items)
        {
            float dist = Vector3.Distance(transform.position, item.transform.position);
            if (dist > curDist)
            {
                curDist = dist;
                Spikes = item;
            }
        }
    }
        void OnTriggerEnter2D(Collider2D collision)
        {
           if (collision.gameObject.tag == "Player")
           {

            Destroy(Spikes);
           }
        }

}

