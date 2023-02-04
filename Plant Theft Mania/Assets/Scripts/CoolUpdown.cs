using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolUpdown : MonoBehaviour
{
    public float floatStrength = 0.1f;
    public float floatFrequency = 6f;

    Vector3 _originalPosition;

    // Start is called before the first frame update
    void Start()
    {
        _originalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, _originalPosition.y + (Mathf.Sin(Time.time * floatFrequency) * floatStrength), transform.position.z);
    }
}
