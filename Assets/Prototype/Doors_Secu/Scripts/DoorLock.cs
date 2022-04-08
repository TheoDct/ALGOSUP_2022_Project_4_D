using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLock : MonoBehaviour
{
    public GameObject door;
    public GameObject doorHandle;
    public GameObject doorHandle2;

    public GameObject securitySystem;

    private Vector3 initialPosition;
    public bool doorLocked = true;

    private void Locking()
    {
        if(securitySystem.GetComponent<securityAccess>().cardValid == true)
        {
            doorLocked = false;
        }
        else
        {
            doorLocked = true;
        }
    }
    private void doorLock()
    {
        // apply a rigid body on the door
        var doorRB = door.GetComponent<Rigidbody>();

        // getting current position of the door
        var currentPos = door.transform.position;
        
        // compare the distance between the initial position and the current position of the door
        float betweenThem = Vector3.Distance(initialPosition, currentPos);

        // checking if the handle is grabbed or not
        var isGrabbed = doorHandle.GetComponent<OVRGrabbable>().isGrabbed;
        var isGrabbed2 = doorHandle2.GetComponent<OVRGrabbable>().isGrabbed;

        if(doorLocked == false) // Door is unlocked
        {
            if(betweenThem <= 0.01f) // door is close to it initial position
            {
                if(!isGrabbed && !isGrabbed2) // both are currently not grabbed
                {
                    doorRB.constraints = RigidbodyConstraints.FreezePosition;
                    doorRB.isKinematic = true;
                    
                    if(Time.time > securitySystem.GetComponent<securityAccess>().lastDelock + 3f) // insert the timer condition to set the card not valid
                    {
                        doorLocked = true;
                        securitySystem.GetComponent<securityAccess>().cardValid = false;
                    }
                }
                else // one of them is currently grabbing the handle
                {
                    doorRB.constraints = RigidbodyConstraints.None;
                    doorRB.isKinematic = false;
                }
            }
            else // When the door is not close to it initial position            
            {
                doorRB.constraints = RigidbodyConstraints.None;
                doorRB.isKinematic = false;
            }
        }
        else // door is locked
        {
            doorRB.constraints = RigidbodyConstraints.FreezePosition;
            doorRB.isKinematic = true;

            if(securitySystem.GetComponent<securityAccess>().cardValid == true) // card is valid
            {
                doorLocked = false;
                doorRB.constraints = RigidbodyConstraints.None;
                doorRB.isKinematic = false;
            }
            else // This is not a card
            {
                securitySystem.GetComponent<securityAccess>().cardValid = false;
            }
        }   
    }
    void Start()
    {
        initialPosition = door.transform.position;
    }
    void Update()
    {
        Locking();
        doorLock();
    }
}