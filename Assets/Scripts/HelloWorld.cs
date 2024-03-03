using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class HelloWorld : MonoBehaviour
{

    
  
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.Translate(new Vector3(0, 0, 5) * Time.deltaTime * speed);
    }
}
