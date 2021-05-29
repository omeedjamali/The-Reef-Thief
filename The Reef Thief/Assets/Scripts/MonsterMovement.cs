using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour
{
    public static int movespeed = 2;

    void Start()
    {
        
    }

    void Update()
    {
       transform.Translate(Vector3.left * movespeed * Time.deltaTime);
    }
}
