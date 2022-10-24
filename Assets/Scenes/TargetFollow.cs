using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TargetFollow : MonoBehaviour
{
    public Transform Target;
    private NavMeshAgent agent;
    void Start()
    {
         agent = GetComponent<NavMeshAgent>();
        
    }

    private void Update()
    {
        agent.destination = Target.position;
    }
}
