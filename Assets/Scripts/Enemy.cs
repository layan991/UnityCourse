using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform target;
    public float speed;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        rb.MovePosition(transform.position + direction * speed * Time.fixedDeltaTime);
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("you lose");
        }
    }
}