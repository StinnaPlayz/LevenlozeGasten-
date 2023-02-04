using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantScripting : MonoBehaviour
{
    public BoxCollider2D myBoxcollider;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
       // if(collision.gameObject.tag == "Player")
       // {
       //     Destroy(gameObject);
        //}

    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            gameManager.UpdateScore(100);
            Destroy(gameObject);
        }
    }
}
