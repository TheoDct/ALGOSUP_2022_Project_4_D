using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccessLevel : MonoBehaviour
{
    public enum Level
    {
        Students = 0,
        Staff = 1,
        Admin = 2
    }
    public Level AccessLevelGranted;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}