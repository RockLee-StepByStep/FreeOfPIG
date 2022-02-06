using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombGive : MonoBehaviour
{
    ScoreBoard score;
    Animator animBomb;

    // Start is called before the first frame update
    void Start()
    {
        animBomb = GetComponent<Animator>();
        score = FindObjectOfType<ScoreBoard>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            score.AdBombScore(1);
            Debug.Log(1);
            Destroy(this.gameObject);
        }
    }
    
    
}
