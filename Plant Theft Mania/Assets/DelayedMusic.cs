using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedMusic : MonoSingleton<DelayedMusic>
{
    // Start is called before the first frame update
    public void BeginMusic()
    {
        AudioSource backgroundMusic = gameObject.GetComponent<AudioSource>();
        backgroundMusic.Play();    
    }
}
