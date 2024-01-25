using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    [SerializeField] GameObject player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            player.GetComponent<PlayerController>().KillPlayer();

            // DEBUG
            Debug.Log($"You are dead");
        }
    }
}
