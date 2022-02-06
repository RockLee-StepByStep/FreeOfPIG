using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    public PlayerMove player;
    public Animator animPL;
    // Start is called before the first frame update
    void Start()
    {
        animPL = GetComponent<Animator>();
        player = GetComponent<PlayerMove>();

    }

    // Update is called once per frame
    void Update()
    {
        animPL.SetFloat("Horizontal", player.MoveHor);
        animPL.SetFloat("Vertical", player.MoveVert);
        animPL.SetFloat("speed", player.transform.position.sqrMagnitude);
    }
}
