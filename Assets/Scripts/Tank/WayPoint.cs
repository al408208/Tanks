using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WayPoint : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    [HideInInspector] public Transform waypoints;
    public GameManager gm;

    void Start ()
    {
        navMeshAgent.SetDestination (waypoints.position);
    }

    void Update ()
    {

        if(gm.start==true){
            gameObject.GetComponent<NavMeshAgent>().isStopped = false;
            navMeshAgent.SetDestination (waypoints.position);
            gm.disparo=false;
        }else{
            gameObject.GetComponent<NavMeshAgent>().isStopped = true;
        }

       
       
        
        
    }
}
