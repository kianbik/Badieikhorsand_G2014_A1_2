using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    GameObject target;
    public float speed = .01f;


    void Start()
    {
        target = GameObject.Find("Player");
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }
  
}
