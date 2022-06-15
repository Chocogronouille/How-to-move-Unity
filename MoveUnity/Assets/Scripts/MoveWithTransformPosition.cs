using UnityEngine;

public class MoveWithTransformPosition : MonoBehaviour
{
    public float speed = 2;

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(-speed * Time.deltaTime, 0, 0);
    }
}