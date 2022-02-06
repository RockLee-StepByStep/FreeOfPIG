using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    AudioSource DeathSound;
    Animator DeathAnim;
    PlayerMove playerContrl;
    float DeathTime = 3;
    bool DeathAble = false;

    // Start is called before the first frame update
    void Start()
    {
        DeathSound = GetComponent<AudioSource>();
        playerContrl = GetComponent<PlayerMove>();
        DeathAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        TimeToDeath();
    }

 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            DeathSound.Play();
            playerContrl.enabled = false;
            DeathAble = true;
            DeathAnim.SetTrigger("death");
            Debug.Log(69);
        }
    }

    void TimeToDeath()
    {
        if (DeathAble)
            DeathTime -= Time.deltaTime;
        if (DeathTime < 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
