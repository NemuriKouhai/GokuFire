using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class SwordEnemy : Enemy
{

    [SerializeField] NavMeshAgent agent;
    [SerializeField] float AttackRange = 1f;

    [SerializeField]float DontMoveTimeWhileAttacking = 5f;
    [SerializeField]bool Chasing = true;
    [SerializeField]Animator animator;

    float timeBeforeAttacking = 0;
    float AttackDelay = 2f;

    
    private void Start()
    {
        HP = MaxHP;
        PlayerPosition = GameObject.FindGameObjectWithTag("Player").transform;
        agent.stoppingDistance = AttackRange;
    }
    private void FixedUpdate()
    {
        timeBeforeAttacking-=Time.fixedDeltaTime;
        if(timeBeforeAttacking>0){
            Chasing=false;
            
        }else{
            Chasing = true;
        }
        
        if(Vector3.Distance(transform.position, PlayerPosition.position)>AttackRange && Chasing==true)agent.SetDestination(PlayerPosition.position);
        else if(timeBeforeAttacking<=0)
        {
            animator.SetTrigger("attack");
            timeBeforeAttacking = AttackDelay;
        }
    }
    public override void GetDamage(float Damage)
    {
        base.GetDamage(Damage);
    }

    protected override void Death()
    {
        base.Death();
    }



}
