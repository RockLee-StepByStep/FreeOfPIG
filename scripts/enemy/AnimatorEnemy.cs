using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorEnemy : MonoBehaviour
{

    public Animator animEnemy;
    public AgentScript enemy;
    // Start is called before the first frame update
    void Start()
    {
        animEnemy = GetComponent<Animator>();
        enemy = GetComponent<AgentScript>();
    }

    // Update is called once per frame
    void Update()
    {
        animEnemy.SetBool("active", true);
        animEnemy.SetFloat("Horizontal", enemy.direction.x);
        animEnemy.SetFloat("Vertical", enemy.direction.y);
        
    }
}
