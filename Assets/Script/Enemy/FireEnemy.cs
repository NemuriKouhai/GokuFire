using UnityEngine;

public class FireEnemy : Enemy
{
    [SerializeField] Transform playerTransform;



    public override void GetDamage(float Damage)
    {
        base.GetDamage(Damage);
    }

    protected override void Death()
    {
        base.Death();
    }
}
