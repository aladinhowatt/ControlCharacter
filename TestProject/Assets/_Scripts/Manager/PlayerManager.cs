using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerManager : MonoBehaviour
{
    NavMeshAgent agent;
    Animator animator;
  
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        InputManager.onClickSurface += OnClickSurface;
    }

    private void OnClickSurface(Vector3 point)
    {
        MovePlayerTo(point);
       
    }

    private void MovePlayerTo(Vector3 point)
    {
        animator.SetBool("Moving", true);
        agent.SetDestination(point);
    }

    // Update is called once per frame
    void Update()
    {
        if (!agent.pathPending)
        {
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
                {
                    animator.SetBool("Moving", false);
                }
            }
        }
    }
}
