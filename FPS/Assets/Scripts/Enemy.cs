using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public  class Enemy : MonoBehaviour
{
    public float lookRadius = 10f;
    Transform target;
    public NavMeshAgent agent;

    void Start()
    {
        target = PlayerManager.instance.player.transform;
       
    }

    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        if(distance <= lookRadius)
        {
            agent.SetDestination(target.position);

            if(distance <= agent.stoppingDistance)
            {
                //attack target 

                //face target
            }
        }
    }

    void FaceTarget()
    {

    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);

    }
}
