using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class PlayerMove : MonoBehaviour
{
    private NavMeshAgent agent;
    [SerializeField] public float speedMove;

    public FixedJoystick joysstick;
    public float MoveHor;
    public float MoveVert;
    float horizontal;
    float vertical;

    // Start is called before the first frame update
    void Start()
    {   //устанавливаем стартовую позицию
        var startPosition = new Vector2(-7, 0);
        transform.position = startPosition;
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = joysstick.Horizontal;
        vertical = joysstick.Vertical;
        MoveHor = horizontal * speedMove;
        MoveVert = vertical * speedMove;
        MoveHor *= Time.deltaTime;
        MoveVert *= Time.deltaTime;

        transform.Translate(new Vector2(MoveHor, MoveVert));
    }
}
