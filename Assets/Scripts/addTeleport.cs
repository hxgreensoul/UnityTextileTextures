using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addTeleport : MonoBehaviour
{
    
    public Transform teleportTarget; // the variable for the teleport position
    public GameObject thePlayer; // the variable for the teleporting player

    void onTriggerEnter(Collider other) // setting the trigger for teleportation 
    {
        thePlayer.transform.position = teleportTarget.transform.position;// the trigger makes one position equal to another
        //{ Debug.Log("ENTERED WARP ZONE"); }
        print("Player has entered teleport pad");
        Debug.Log("Triggered!");
    }
    
}