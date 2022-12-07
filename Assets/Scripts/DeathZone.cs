using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        var p = collider.gameObject.GetComponent<PlayerController>();
        if (p != null)
        {
            //var ev = Schedule<PlayerEnteredDeathZone>();
            //ev.deathzone = this;
        }
    }
}
