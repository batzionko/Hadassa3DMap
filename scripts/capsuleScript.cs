using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class capsuleScript : MonoBehaviour
{
    public Transform target;
    public Transform fromPosition;
  private LineRenderer linerederer;
  

    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        linerederer = GetComponent<LineRenderer>();
     
    }
    // Update is called once per frame
    void Update()
    {
        linerederer.enabled = true;
        if (agent.hasPath)
        {
          
            linerederer.positionCount = agent.path.corners.Length;

            var points = new Vector3[agent.path.corners.Length];
            for (int i = 0; i < agent.path.corners.Length; i++)
            {
                
                   points[i] = new Vector3(agent.path.corners[i].x, agent.path.corners[i].y, agent.path.corners[i].z);
            }
          
            linerederer.SetPositions(points);
            agent.Warp(fromPosition.position);
            //linerederer.enabled=true;
        }
       /* else
        {
            linerederer.enabled = false;
            linerederer.positionCount=0;
        }*/
        agent.SetDestination(target.position);
    }

}
