using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEffect : MonoBehaviour
{
    public float swaySpeed = 1.0f; // Hareket hýzý
    public float swayAmount = 1.0f; // Hareket miktarý
    private float initialYPosition; // Kameranýn baþlangýç yüksekliði

    void Start()
    {
        initialYPosition = transform.position.y; // Kameranýn baþlangýç yüksekliðini kaydet
    }

    void Update()
    {
        // Y eksenindeki salýným hareketi için bir deðer hesaplayýn
        float swayOffset = Mathf.Sin(Time.time * swaySpeed) * -swayAmount;
        
        // Kameranýn yeni pozisyonunu hesaplayýn ve uygulayýn
        Vector3 newPosition = transform.position;
        newPosition.y = initialYPosition + swayOffset;
        transform.position = newPosition;
    }
    
}
