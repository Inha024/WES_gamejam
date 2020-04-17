using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathStates : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public GameObject player;
    public AlivePlayerMovement alive;
    public DeadPlayer dead;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    public void PlayerDied()
    {
        player.GetComponent<AlivePlayerMovement>().enabled = false;
        player.GetComponent<DeadPlayer>().enabled = true;
        rb2d.isKinematic = true;
        rb2d.velocity = Vector3.zero;
    }
    public void PlayerRespawn()
    {
        player.GetComponent<AlivePlayerMovement>().enabled = true;
        player.GetComponent<DeadPlayer>().enabled = false;
        rb2d.velocity = Vector3.zero;
        rb2d.isKinematic = false;
    }
    public void GameOver()
    {

    }
}
