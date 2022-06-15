using UnityEngine;

public class MoveWithTranslate : MonoBehaviour
{
    [SerializeField] float speed = 2;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-speed * Time.deltaTime,0,0);
    }
}
