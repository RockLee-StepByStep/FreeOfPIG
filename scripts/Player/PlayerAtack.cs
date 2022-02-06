using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAtack : MonoBehaviour
{
    
    public GameObject bombActive;

     ScoreBoard score;

    public FixedJoystick pushJoysctic;


    // Start is called before the first frame update
    void Start()
    {
        score = FindObjectOfType<ScoreBoard>();
    }

    // Update is called once per frame
    void Update()
    {
        if (score.score != 0)
        {
                    if (pushJoysctic.Vertical>0.1 )
                {
                    Instantiate(bombActive, transform.position, transform.rotation);
                    score.DellBombScore(1);
                }
                //Method Attack
        

         }
    }
}
