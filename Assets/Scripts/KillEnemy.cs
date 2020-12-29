using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {

            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
