using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; 
    public float smoothSpeed = 0.125f; 
    public Vector3 offset; 

    void LateUpdate()
    {
        // Hedefin mevcut pozisyonuna offset'i ekleyerek istenen pozisyonu hesapla
        Vector3 desiredPosition = target.position + offset;

        // Yumuþak bir geçiþle istenen pozisyona doðru ilerle
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        // Kameranýn pozisyonunu güncelle
        transform.position = smoothedPosition;

    }
}
