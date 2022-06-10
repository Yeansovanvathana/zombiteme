using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private float dirX, dirY;
    public float moveSpeed = 5f;

    public bool ClimbingAllowed { get; set; }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed;
        if (ClimbingAllowed)
        {
            dirY = Input.GetAxis("Vertical") * moveSpeed;         
        }
    }
    private void FixedUpdate()
    {
        if (ClimbingAllowed)
        {
            rb.isKinematic = true;
            rb.velocity = new Vector2(dirX, dirY);
        }
        else
        {
            rb.isKinematic = false;
            rb.velocity = new Vector2(dirX, rb.velocity.y);
        }
    }
}
