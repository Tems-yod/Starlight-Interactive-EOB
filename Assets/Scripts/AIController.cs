using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public LayerMask whatIsGround, whatIsPlayer;

    private int teleportTimer = 1000;


    //Patrolling
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    

    //Attacking
    public float timeBetweenAttacks;
    bool alreadyAttacked;

    public float percentPlayerKilled = 0f;

    //States
    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;

    AudioSource EyeSound;

    private void Awake()
    {
        player = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>();

        EyeSound = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    private void Update()
    {
        //Check for sight and attack range
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

        if (!playerInSightRange && !playerInAttackRange)  Patroling();
        if (playerInSightRange && !playerInAttackRange)  ChasePlayer();
        if (playerInSightRange && playerInAttackRange)  AttackPlayer();
    }

    private void Patroling()
    {
        if (!walkPointSet) SearchWalkPoint();

        if(walkPointSet)
            agent.SetDestination(walkPoint);

        Vector3 distanceToWalkPoint = transform.position - walkPoint;

        //Walkpoint reached
        if (distanceToWalkPoint.magnitude < 1f)
            walkPointSet = false;

        teleportTimer--;

        if(teleportTimer<=0)
        {
            Debug.Log("Teleporting...");
            teleportTimer = 1000;
        }
    }

    private void SearchWalkPoint()
    {
        //random point in range
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);
        if (Physics.Raycast(walkPoint, -transform.up, whatIsGround))
            walkPointSet = true;
    }

    private void ChasePlayer()
    {
        
        if(percentPlayerKilled>0)
            {
                percentPlayerKilled -= 5;
            }
        agent.SetDestination(player.position);
    }

    private void AttackPlayer()
    {
        EyeSound.Play(0);
        agent.SetDestination(transform.position);

        transform.LookAt(player);

        

        if(!alreadyAttacked)
        {
            percentPlayerKilled+=1;
            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }
    }

    private void ResetAttack()
    {
        alreadyAttacked = false;
    }


    private void DestroyEnemy()
    {
        // potentially use this to remove a lost eye and respawn it elsewhere

        Destroy(gameObject);
    }
}
