using UnityEngine;

public class ExplosionButton : MonoBehaviour
{
    public float explosionForce = 500;
    public float explosionRadius = 5;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Collider[] objects = Physics.OverlapSphere(transform.position, explosionRadius);

            foreach (Collider obj in objects)
            {
                Rigidbody rb = obj.GetComponent<Rigidbody>();

                if (rb != null)
                {
                    rb.AddExplosionForce(explosionForce, transform.position, explosionRadius);
                }
            }
        }
    }
}
