using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsMov : MonoBehaviour
{
    public float direction;
    public float speed;
    public Rigidbody2D rigidBody2D;
    [Range(0, 60)]
    public float timeToDestroy;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, timeToDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        rigidBody2D.velocity = new Vector2(0, direction * speed * Time.fixedDeltaTime);

    }
    void OnTriggerEnter2D(Collider2D Col)
    {

        if (Col.gameObject.tag == "Player")
        {
            Destroy(gameObject);

        }

    }
}