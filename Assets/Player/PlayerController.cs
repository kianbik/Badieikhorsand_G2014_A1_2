//Kian Badieikhorsand
//Student Number: 101282433
// Midterm 2021 Game2014



using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{



    float angle;
    float speed = 0.0f;
    private Vector3 m_touchesEnded;
    GameObject player;




    Vector2 movement;
    public float moveSpeed = 0.1f;

    // Private variables
    private Rigidbody2D m_rigidBody;


    // Start is called before the first frame update
    void Start()
    {
        m_touchesEnded = new Vector3();
        m_rigidBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        _Move();

    }


    private void _Move()
    {
        foreach (var touch in Input.touches)
        {
            var worldTouch = Camera.main.ScreenToWorldPoint(touch.position);
            var pos = transform.position;


             movement.x = worldTouch.x - m_rigidBody.position.x ;

            movement.y = worldTouch.y - m_rigidBody.position.y;

            movement = movement.normalized;

            m_touchesEnded = worldTouch;

        }

        m_rigidBody.MovePosition(m_rigidBody.position + movement * moveSpeed * Time.fixedDeltaTime);

    }
}