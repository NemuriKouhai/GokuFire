using UnityEngine;
using UnityEngine.AI;

public class SwordEnemy : Enemy
{

    [SerializeField] NavMeshAgent agent;
    [SerializeField] float AttackRange = 1f;

    private void Start()
    {
        HP = MaxHP;
        PlayerPosition = GameObject.FindGameObjectWithTag("Player").transform;
        agent.stoppingDistance = AttackRange;
    }
    private void Update()
    {
        
        if(Vector3.Distance(transform.position, PlayerPosition.position)>AttackRange)agent.SetDestination(PlayerPosition.position);
        else
        {
            
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
