
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Teleporting : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject player;
    private void OnTriggerEnter(Collider collider)
    {
        player.transform.position = teleportTarget.transform.position;
        Debug.Log("Triggered!");
    }
}