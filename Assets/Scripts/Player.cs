using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MoveSpeed = 1f;
    public Rigidbody2D rigidbody2D;
    public float impulse;
    int applesCount;

    private void Start()
    {
        Debug.Log(applesCount);
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
            rigidbody2D.AddForce(Vector2.up * impulse, ForceMode2D.Impulse);
        }
    }
}
