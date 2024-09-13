using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarColision : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other){
        Debug.Log("Entre en contacto con algo!");
    }
}
