using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{

    private NavMeshAgent EnemyIA;

    // Start is called before the first frame update
    void Start()
    {
        //EnemyBody = GetComponent<Rigidbody>();
        EnemyIA = GetComponent<NavMeshAgent>();
    }


    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            EnemyIA.SetDestination(other.transform.position);
        }
    }
}
