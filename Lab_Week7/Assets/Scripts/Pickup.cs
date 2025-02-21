using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerBehavior controller = other.GetComponent<PlayerBehavior>();

        if(controller != null)
        {
            Destroy(gameObject);
        }
    }
}
