using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantScripting : MonoBehaviour
{
    public BoxCollider2D myBoxcollider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }

    }
}
