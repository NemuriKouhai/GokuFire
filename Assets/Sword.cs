using UnityEngine;

public class Sword : MonoBehaviour
{
    //maji de interface wasurechattaaaa
    [SerializeField]string TargetTag = "Player";
    [SerializeField]bool attackedOnce = false;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable()
    {
        attackedOnce = false;

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(TargetTag) && attackedOnce==false){
            other.GetComponent<PlayerHealth>().GetDamage(40);
            attackedOnce = true;
        }
    }

}
