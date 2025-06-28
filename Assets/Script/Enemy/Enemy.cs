using UnityEngine;

public class Enemy : MonoBehaviour
{
    [HideInInspector]public float HP;
    public float MaxHP = 150;
    [SerializeField] protected Transform PlayerPosition; 
    public virtual void GetDamage(float Damage)
    {
        HP -= Damage;
     
        if(HP <= 0){
            Death();       
        }
    }

    protected virtual void Death() { 
        
    }
}
