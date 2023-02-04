using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class belladonnaScript : MonoBehaviour
{
    public TextMeshProUGUI promptText;
    public float minDuration = 2f;
    public float maxDuration = 5f;
    public float turnTime = 0.5f;
    public bool canMove = true;
    public GameObject player;

    private PlayerController playerController;

    private bool gameOver = false;
    private float redLightDuration = 2f;
    private float greenLightDuration = 2f;
    private bool gameStarted = false;


    // Start is called before the first frame update
    void Start()
    {
        playerController = player.gameObject.GetComponent<PlayerController>();
    }

    private IEnumerator StartGame()
    {
        promptText.text = "Get Ready...";
        yield return new WaitForSeconds(3);
        playerController.isFrozen = false;


        while (!gameOver)
        {
            
            yield return new WaitForSeconds(redLightDuration);
            promptText.text = "Green Light!";
            canMove = true;
            greenLightDuration = Random.Range(minDuration, maxDuration);

            yield return new WaitForSeconds(greenLightDuration);
            promptText.text = "Red Light!";
            yield return new WaitForSeconds(turnTime);
            canMove = false;
            redLightDuration = Random.Range(minDuration, maxDuration);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
            
        {
            if (!gameStarted)
            {
                playerController.isFrozen = true;
                gameStarted = true;
                StartCoroutine(StartGame());
            }
        }
    }
}
