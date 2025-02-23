using UnityEngine;

public class Move: MonoBehaviour
{
   public float speed;

    void Start()
    {
        Destroy(gameObject,5);
    }
    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
