using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class FireEnemy : Enemy
{

    [SerializeField] NavMeshAgent agent;
    [SerializeField] float AttackRange = 4f;

    [SerializeField] float timeBeforeFire;
    [SerializeField] float FireDelay;
    [SerializeField] float FireForce = 1.5f;
    [SerializeField] GameObject FireBallPrefab;
    private void Start()
    {
        HP = MaxHP;
        PlayerPosition = GameObject.FindGameObjectWithTag("Player").transform;
        agent.stoppingDistance = AttackRange;
    }
    private void FixedUpdate()
    {
        agent.SetDestination(PlayerPosition.position);
        if (Vector3.Distance(transform.position, PlayerPosition.position) <= AttackRange)
        {
            if (timeBeforeFire <= 0)
            {
                Vector3 disance = PlayerPosition.position - transform.position;
                disance = Vector3.Scale(disance, new Vector3(1, 0, 1));
                transform.forward = disance.normalized;
                GameObject fireBall = Instantiate(FireBallPrefab, transform.position, transform.rotation);

                fireBall.GetComponent<Rigidbody>().AddForce(transform.forward.normalized * FireForce, ForceMode.Impulse);

                timeBeforeFire = FireDelay;
            }

        }
        timeBeforeFire -= Time.fixedDeltaTime;
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
