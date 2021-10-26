using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerInfo1 : MonoBehaviour
{
   
    public Text health;
    public static int healthValue;

    // Start is called before the first frame update
    void Start()
    {
        healthValue = 3;
       
        health = GetComponent<Text>() as Text;

    }

    // Update is called once per frame
    void Update()
    {
       
        health.text ="Health: " + healthValue.ToString("00");
    }
}
