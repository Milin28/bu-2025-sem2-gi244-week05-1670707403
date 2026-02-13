using UnityEngine;

public class Food : MonoBehaviour
{
    public int attackPoint = 5;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hit" + other.gameObject.name);
        
        if (other.gameObject.TryGetComponent<HealthV1>(out HealthV1 health))
        {
            health.TakeDamage(attackPoint);
        }
        Destroy(gameObject);
    }
}