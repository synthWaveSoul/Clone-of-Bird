using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;

    public float heightOffset;

    public logicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();

        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate){
            timer += Time.deltaTime;
        }
        else{
            spawnPipe();
            timer = 0;
        }

        if (logic.scoreText.text == "2"){
            spawnRate = 1;
        }
        
    }

    void spawnPipe(){
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
