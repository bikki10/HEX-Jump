using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float force;
    public LogicScript logic;
    public bool playerIsAlive = true;
    private float fallthresHold = -15;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        Time.timeScale = 0;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            logic.DisplayText();
            Time.timeScale = 1;
            rb.velocity = Vector2.up * force;

        }
        onFall();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        logic.gameOver();
        playerIsAlive = false;
        Time.timeScale = 0;
        Debug.Log("collision");

    }

    public void onFall()
    {
        if (rb.position.y < fallthresHold && playerIsAlive)
        {
            playerIsAlive = false;
            logic.gameOver();
            Debug.Log(transform.position.y);
            Time.timeScale = 0;
        }
    }
}
