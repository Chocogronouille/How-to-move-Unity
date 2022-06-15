using UnityEngine;

public class MoveWithRigidBodyVelocity : MonoBehaviour
{
    [SerializeField] private float speed = 2;

    [SerializeField] private Rigidbody rb;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right"))
        {
            rb.velocity = new Vector3(-speed, 0, 0);
        }
    }
}
