using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public float speex;
    public float speedz;

    // Start is called before the first frame update
    void Start()
    {
       // transform.Rotate(new Vector3(0, -119));
        //  transform.rotation = new Quaternion(0f, -119f,0,0);
        // Quaternion rotateShip = new Quaternion(0, -119.3f, 0, 0);
    }

    void Update()
    {
        MoveShip();
       
    }

    void MoveShip()
    {
        
        transform.Translate(new Vector3(speex, 0, speedz) * Time.deltaTime * speed);
       
    }
}
