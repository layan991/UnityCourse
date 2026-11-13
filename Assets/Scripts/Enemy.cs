using System.Collections;
using UnityEditor;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string playerTag = "Player";
    
    public float speed;
    public float speedIncrease;
    public float secondsBetweenIncreases;
    public float maxSpeed;

    private Transform target;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag(playerTag).transform;
        StartCoroutine(SpeedUpOverTime(secondsBetweenIncreases, speedIncrease));
    }

    IEnumerator SpeedUpOverTime(float seconds, float amount)
    {
        while (speed < maxSpeed)
        {
            yield return new WaitForSeconds(seconds);
            speed += amount;
        }
    }

    void FixedUpdate()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        rb.MovePosition(transform.position + direction * speed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(playerTag))
        {
            Debug.Log("you lose");
            EditorApplication.isPlaying = false;
        }
    }
}