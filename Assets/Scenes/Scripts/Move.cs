using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Move : MonoBehaviour
{
    float timeIn = 4f;
    public Transform goal;
    UnityEngine.AI.NavMeshAgent agent;
    Rigidbody rBody;
    bool startmove = false;



    public void Awake()
    {
        
        rBody = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
        rBody.isKinematic = true;

    }
    public void OnCollisionEnter(Collision collision)
    {
       startmove = true;
    }

    IEnumerator MoveMove()
    {
        Time.timeScale = 1;
        Debug.Log("Отсчет пошел");
        yield return new WaitForSecondsRealtime(timeIn);

        agent.destination = goal.position;


    }
    public void FixedUpdate()
    {

        if (startmove)
        {
            StartCoroutine(MoveMove());

        }
    }
}
