using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class securityAccess : MonoBehaviour
{
    public enum Level
    {
        Students = 0,
        Staff = 1,
        Admin = 2
    }
    public bool cardValid = false;
    public Level AccessLevelRequired;
    public GameObject Light;
    public Material validMat;
    public Material nonValidMat;
    public float lastDelock;

    void OnTriggerEnter(Collider collision) 
    {
        var card = collision.GetComponent<AccessLevel>();
        // Debug.Log("collision detected");
        if(card != null)
        {
            // Debug.Log("A card has been detected " + card.AccessLevelGranted);
            if((int)card.AccessLevelGranted >= (int)AccessLevelRequired)
            {
                // Debug.Log("Access granted");
                cardValid = true;
                lastDelock = Time.time;
            }
            else
            {
                // Debug.Log("Access denied : Required " + AccessLevelRequired + " but got " + card.AccessLevelGranted);
                cardValid = false;     
            }
        }
        else // Not a card
        {
            // Debug.Log("This is not a card");
            cardValid = false;
        }
    }
    void Start()
    {
        lastDelock = Time.time;
    }
    void Update()
    {
        Light.GetComponent<Renderer>().material = (cardValid==true ? validMat : nonValidMat);
        
    }
}