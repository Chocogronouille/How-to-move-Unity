using UnityEngine;

public class MoveWithRigidbodyMovePosition : MonoBehaviour
{
    [SerializeField] private float speed = 2;
    [SerializeField] private Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(transform.position + new Vector3(-speed * Time.deltaTime, 0,0));
    }
}
