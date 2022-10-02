using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [HideInInspector]
    public float speed;

    private Rigidbody2D MyBody;



    // Start is called before the first frame update
    void Awake()
    {
        MyBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MyBody.velocity = new Vector2(speed, MyBody.velocity.y);
    }
}
