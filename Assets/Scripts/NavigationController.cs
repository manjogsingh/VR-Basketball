using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavigationController : MonoBehaviour
{

    public Transform ball;
    public Transform player;
    NavMeshAgent agent;

    // Use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 diff = ball.position - player.position;
        if (Mathf.Abs(diff.x) > 2 || Mathf.Abs(diff.z) > 2)
        {
            agent.destination = ball.position;
            if (transform.position.x - ball.position.x <= 1 && transform.position.z - ball.position.z <= 1)
            {
                ball.SetParent(transform);
				ball.transform.localScale=new Vector3(0.3f,0.3f,0.3f);
                agent.SetDestination(player.position);
            }
			if(transform.position.x==player.position.x&&transform.position.z==player.position.z)
			{
				ball.SetParent(null);
				ball.transform.localScale=new Vector3(0.3f,0.3f,0.3f);
			}
			else
			{
				ball.SetParent(null);
				ball.transform.localScale=new Vector3(0.3f,0.3f,0.3f);
			}
        }

        //agent.nextPosition
        //agent.destination=player.transform.position;
    }
}
