﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float lookRadius = 9f;
    Transform target;
    NavMeshAgent agent;
	
	public static bool isWalking = false;
    
    // Start is called before the first frame update
    void Start()
    {
    	target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();   
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
	
	if (distance <= lookRadius)
	{
		agent.SetDestination(target.position);

		isWalking = true;
		//Debug.Log(isWalking);

		if (distance <= agent.stoppingDistance) {
			FaceTarget();
		}
	}
  }

	void FaceTarget () {

		Vector3 direction = (target.position - target.position).normalized;
		Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
		transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);

	}

    void OnDrawGizomsSelect () {
	Gizmos.color = Color.red;
	Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
