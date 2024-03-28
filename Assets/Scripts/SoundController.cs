using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    AudioSource source;
    Collider2D soundTrigger;

    void OnTrigerEnter2D(Collider2D collider)
    {
        source.Play();
    }

    void Awake()
    {
        source = GetComponent<AudioSource>();
        soundTrigger = GetComponent<Collider2D>();
    }
   

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
