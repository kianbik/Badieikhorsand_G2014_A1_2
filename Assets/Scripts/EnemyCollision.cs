using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
        PlayerInfo.scoreValue += 100;
            
        }
            Destroy(gameObject);
            Debug.Log("shahdsasd");
        
    }
}
