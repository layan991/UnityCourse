using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float speed;
    public int score;
    public int targetScore;
    public GameObject spawner;

    private Rigidbody2D rb;
    private Vector3 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var dValue = Keyboard.current.dKey.value;
        var aValue = Keyboard.current.aKey.value;
        var wValue = Keyboard.current.wKey.value;
        var sValue = Keyboard.current.sKey.value;

        direction = dValue * Vector3.right + aValue * Vector3.left
                                           + wValue * Vector3.up + sValue * Vector3.down;
    }

    void FixedUpdate()
    {
        rb.MovePosition(transform.position + direction * speed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            score += other.GetComponent<Coin>().value;
            Destroy(other.gameObject);
            spawner.GetComponent<CoinSpawner>().CoinCollected();

            if (score >= targetScore)
            {
                Debug.Log("you won");
            }
        }
    }
}