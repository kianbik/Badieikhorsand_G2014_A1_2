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
    [Header("Player Attack")]
    public Transform bulletSpawn;
    public int frameDelay;
    private BulletManager bulletManager;

    float angle;
    float speed = 0.0f;
    private Vector3 m_touchesEnded;
    GameObject player;
    public int health;



   public Vector2 movement;
    public float moveSpeed = 0.1f;

    // Private variables
    private Rigidbody2D m_rigidBody;


    // Start is called before the first frame update
    void Start()
    {
        m_touchesEnded = new Vector3();
        m_rigidBody = GetComponent<Rigidbody2D>();
        bulletManager = GameObject.FindObjectOfType<BulletManager>();

    }

    // Update is called once per frame
    void FixedUpdate()
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
            if ((Time.frameCount % frameDelay == 0))
            {
                bulletManager.GetBullet(bulletSpawn.position, BulletType.PLAYER);
            }

        }

        m_rigidBody.MovePosition(m_rigidBody.position + movement * moveSpeed * Time.fixedDeltaTime);

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Health")
        {
            PlayerInfo1.healthValue += 1;

        Destroy(collision.gameObject);
        }
        

    }
}