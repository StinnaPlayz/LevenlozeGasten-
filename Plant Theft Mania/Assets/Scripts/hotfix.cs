using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hotfix : MonoBehaviour
{
    public GameObject injector;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(0.5f);

        Debug.Log("dit werkt");

        if(GameManager.Instance == null)
        {
            PersistentObjects.Initialize(injector);
        }
    }
}
