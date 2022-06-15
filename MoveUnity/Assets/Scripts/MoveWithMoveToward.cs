
using UnityEngine;

public class MoveWithMoveToward : MonoBehaviour
{
    [SerializeField] private float speed = 2;
    [SerializeField] private Transform target;
    
    // Update is called once per frame
    void Update()
    {
        /*
         transform.position =
            Vector3.MoveTowards(transform.position, transform.position + Vector3.right, -speed * Time.deltaTime);
        
        */
        transform.position =
            Vector3.MoveTowards(transform.position, target.position + Vector3.right, speed * Time.deltaTime);
    }
}
