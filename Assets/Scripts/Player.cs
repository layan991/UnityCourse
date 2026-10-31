using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float speed;

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
}