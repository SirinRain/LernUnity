using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MoveSpeed = 1f;
    public float impulse;
    float applesCount;
    public Rigidbody2D rigidbody;
    public float minimalHeight;
    public bool isCheatMode;
    public SpriteRenderer[] SpriteRenderer;

    private void Start()
    {
       
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * Time.deltaTime * MoveSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * Time.deltaTime * MoveSpeed);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(Vector2.up * impulse, ForceMode2D.Impulse);
        }

        if (transform.position.y < minimalHeight && isCheatMode)
        {
            transform.position = new Vector2(0, 0);
            rigidbody.velocity = new Vector2(0, 0);
        }
        else if (transform.position.y < minimalHeight)
        { 
            Destroy(gameObject);
            
        }
        




    }
}
