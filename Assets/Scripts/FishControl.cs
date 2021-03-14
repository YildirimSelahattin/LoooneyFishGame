using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishControl : MonoBehaviour
{
    public bool isDead;

    public float velocity = 1f;
    public Rigidbody2D rb2D;

    public GameManager managerGame;

    public GameObject DeathScreen;

    void Start()
    {
        Time.timeScale = 1;
    }

    
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            rb2D.velocity = Vector2.up * velocity;
            rb2D.constraints = RigidbodyConstraints2D.FreezeRotation;
            rb2D.constraints = RigidbodyConstraints2D.FreezePositionX;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "DeadLine")
        {
            isDead = true;
            Time.timeScale = 0;

            DeathScreen.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Coin")
        {
            managerGame.UpdateScore();

            Destroy(collision.gameObject);
            
        }
    }
}
