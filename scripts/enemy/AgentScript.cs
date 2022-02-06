using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentScript : MonoBehaviour
{

    [SerializeField] Transform target;
    private NavMeshAgent agent;
    public Vector2 direction;
    float timeLeft = 6f;
    bool debuf = false;


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;

        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        direction = (target.transform.position  - transform.position).normalized;
        agent.SetDestination(target.position);

        TimeDebuf();
    }


  

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bomb")
        {
            debuf = true;     
            agent.speed = 0.1f;
             Debug.Log(777);
        }
    }

    void TimeDebuf()
    {
        if(debuf)
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            agent.speed = 2;
            timeLeft = 6f;
            debuf = false;
        }
    }
}
