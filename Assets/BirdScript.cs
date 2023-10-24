using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // reference to get access to velocity
    public Rigidbody2D myRigidbody;

    public float flapStrength;

    public logicScript logic;

    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive) {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }   
    }

    private void OnCollisionEnter2D(Collision2D collision){
        logic.gameOver();
        birdIsAlive = false;
    }
}
