using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exlosionBomb : MonoBehaviour
{
    AudioSource playAudio;
    Animator animBomb;
    // Start is called before the first frame update
    void Start()
    {
        playAudio = GetComponent<AudioSource>();
        animBomb = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            playAudio.Play();
            Debug.Log(1);
            animBomb.SetBool("active", true);
            Destroy(this.gameObject,2);
        }
    }
}
