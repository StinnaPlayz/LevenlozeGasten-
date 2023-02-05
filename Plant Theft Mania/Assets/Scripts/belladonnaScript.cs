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
    public Animator animator;
    public Vector3 resetPosition = new Vector3(0,0,0);

    private PlayerController playerController;
    private SpriteRenderer spriteRenderer;

    private bool gameOver = false;
    private float redLightDuration = 2f;
    private float greenLightDuration = 2f;
    private bool gameStarted = false;


    // Start is called before the first frame update
    void Start()
    {
        playerController = player.gameObject.GetComponent<PlayerController>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private IEnumerator StartGame()
    {
        
        promptText.text = "Get Ready...";
        
        while (!gameOver)
        {

            yield return new WaitForSeconds(redLightDuration);
            playerController.isFrozen = false;
            promptText.text = "Green Light!";
            animator.SetBool("Paused", false);
            spriteRenderer.flipX = false;
            canMove = true;
            greenLightDuration = Random.Range(minDuration, maxDuration);

            yield return new WaitForSeconds(greenLightDuration);
            playerController.isFrozen = false;
            promptText.text = "Red Light!";
            yield return new WaitForSeconds(turnTime);
            animator.SetBool("Paused", true);
            spriteRenderer.flipX = true;
            canMove = false;
            redLightDuration = Random.Range(minDuration, maxDuration);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!canMove && (playerController.horizontalMove != 0 || !playerController.controller.m_Grounded))
        {
            //put player back
            player.transform.position = resetPosition; 
        }
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
