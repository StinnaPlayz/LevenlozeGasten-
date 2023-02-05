using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantScripting : MonoBehaviour
{
    public BoxCollider2D myBoxcollider;
    public int scoreToAdd = 100;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.Instance;
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
            gameManager.UpdateScore(scoreToAdd);
            Destroy(gameObject);
        }
    }
}
