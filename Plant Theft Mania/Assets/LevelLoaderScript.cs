using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoaderScript : MonoBehaviour
{
    public GameObject objectToCheck;
    public Animator transition;
    public float transitionTime = 1f;

    // Update is called once per frame
    void Update()
    {
        if(objectToCheck.transform.position.x > 46)
        {
            LoadNextLevel();    
        }
    }

    public void LoadNextLevel()
    {
        if(SceneManager.GetActiveScene().buildIndex == 1) { 
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        }
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex - 1));
        }
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}
