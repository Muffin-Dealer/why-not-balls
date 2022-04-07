using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Pleyer : MonoBehaviour
{    
    public float movementSpeed = 10f;
    Rigidbody2D rb;
    public Transform camPos;
    float movement = 0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
        if (rb.position.y < camPos.position.y - 5)
        {
            Debug.Log("you dead");
            rb.gameObject.SetActive(false);
            
        }
    }
    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }
}
