using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class HelloWorld : MonoBehaviour
{

    [SerializeField] GameObject text;
    public string textString = "Heloooo!";
    private float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        text.GetComponent<TextMeshPro>().text = textString;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.Translate(new Vector3(0, 0.5f, 1) * Time.deltaTime * speed);
    }
}
