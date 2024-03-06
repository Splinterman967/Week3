using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEffect : MonoBehaviour
{
    public float swaySpeed = 1.0f; // Hareket h�z�
    public float swayAmount = 1.0f; // Hareket miktar�
    private float initialYPosition; // Kameran�n ba�lang�� y�ksekli�i

    void Start()
    {
        initialYPosition = transform.position.y; // Kameran�n ba�lang�� y�ksekli�ini kaydet
    }

    void Update()
    {
        // Y eksenindeki sal�n�m hareketi i�in bir de�er hesaplay�n
        float swayOffset = Mathf.Sin(Time.time * swaySpeed) * -swayAmount;
        
        // Kameran�n yeni pozisyonunu hesaplay�n ve uygulay�n
        Vector3 newPosition = transform.position;
        newPosition.y = initialYPosition + swayOffset;
        transform.position = newPosition;
    }
    
}
