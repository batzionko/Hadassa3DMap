using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class capsuleScript : MonoBehaviour
{
  //  public Button slowBotton;
   // public Button fastBotton;
    public Transform target;
    private LineRenderer linerederer;
    //public Transform from;
  

    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        
        agent = GetComponent<NavMeshAgent>();
        linerederer = GetComponent<LineRenderer>();
       // slowBotton = GetComponent<Button>();

        //agent.SetDestination(target.position);
    }

    // Update is called once per frame
    void Update()
    {
        if(agent.hasPath)
        {
            linerederer.positionCount = agent.path.corners.Length;
            linerederer.SetPositions(agent.path.corners);
            //agent.SetDestination(target.position);
            linerederer.enabled=true;


        }
        else
        {
            linerederer.enabled = false;
            linerederer.positionCount=0;
        }
    agent.SetDestination(target.position);
             
    }
  
}
