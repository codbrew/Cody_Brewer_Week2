using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMotor : MonoBehaviour
{
    // Start is called before the first frame update

    public NavMeshAgent agent;
    public Transform destination;
    public float speed = 25f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(destination.position);


    }
}
