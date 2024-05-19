using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelfOnContact : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col) {
        Debug.Log("Destroy" + col.tag);
        Destroy(gameObject);
    }
}
