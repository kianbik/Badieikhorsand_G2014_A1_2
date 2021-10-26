//Kian Badieikhorsand
//Student Number: 101282433
// Midterm 2021 Game2014


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public BulletType type;

    [Header("Bullet Movement")]
    [Range(0.0f, 0.5f)]
    public float speed;
    public Bounds bulletBounds;
    

    private BulletManager bulletManager;
    private Vector3 bulletVelocity;

    // Start is called before the first frame update
    void Start()
    {
        bulletManager = GameObject.FindObjectOfType<BulletManager>();

       
                bulletVelocity = new Vector3(0.0f, -speed, 0.0f);
          
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        CheckBounds();
    }

    private void Move()
    {
        transform.position += bulletVelocity;
    }

    private void CheckBounds()
    {
        // checks bottom bounds
        if (transform.position.y > bulletBounds.max)
        {
           bulletManager.ReturnBullet(this.gameObject, type);
        }

        // check top bounds
        if (transform.position.y < bulletBounds.min)
        {
            bulletManager.ReturnBullet(this.gameObject, type);
        }
        if (transform.position.x < bulletBounds.min)
        {
            bulletManager.ReturnBullet(this.gameObject, type);
        }
        if (transform.position.x > bulletBounds.max)
        {
            bulletManager.ReturnBullet(this.gameObject, type);
        }
    }
}