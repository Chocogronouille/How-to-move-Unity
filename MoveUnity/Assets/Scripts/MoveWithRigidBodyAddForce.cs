using UnityEngine;

public class MoveWithRigidBodyAddForce : MonoBehaviour
{
    [SerializeField] private float speed = 2;
    [SerializeField] private Rigidbody rb;
    

    // Update is called once per frame
    void Update()
    {
        //rb.AddForce(-speed,0,0,ForceMode.Acceleration);
        rb.AddForce(-speed,0,0,ForceMode.VelocityChange);

    }
}
