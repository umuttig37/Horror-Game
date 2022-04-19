using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public Transform[] waypoints;
    public int speed;

    [SerializeField] private float distance;

    private int waypointIndex;
    private float dist;
  
    void Start()
    {
        waypointIndex = 0;
        transform.LookAt(waypoints[waypointIndex].position);
        
    }
   
   
    void Update()
    {
        dist = Vector3.Distance(transform.position, waypoints[waypointIndex].position);
        if(dist < distance)
        {
            IncreaseIndex();
        }

        Patroll();
    }

    void Patroll()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        Vector3 debugVector = new Vector3(waypoints[waypointIndex].position.x, transform.position.y, waypoints[waypointIndex].position.z);
        transform.LookAt(debugVector);
        
    }

    void IncreaseIndex()
    {
        waypointIndex++;
        if(waypointIndex >= waypoints.Length)
        {
            waypointIndex = 0;
        }
        transform.LookAt(waypoints[waypointIndex].position);
    }
}
