using UnityEngine;

public class BallPlayer : MonoBehaviour
{
    public float moveForce = 10f;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 force = new Vector3(h, 0, v);
        rb.AddForce(force * moveForce);
    }
}

