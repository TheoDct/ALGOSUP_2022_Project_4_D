using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightonoff : MonoBehaviour
{
    
    public GameObject Switch;
    public GameObject manag;
    public Animator Anim;

    private AI_Manager mana;
    private float CoolDown;
    

    private void Start()
    {
        mana = manag.GetComponent<AI_Manager>();
        CoolDown = Time.time;
    }
    private void Update()
    {
       
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && Time.time > CoolDown + 1f)
        {
            CoolDown = Time.time;
            Anim.SetBool("Check", !Anim.GetBool("Check"));
            if (mana.Hour == 12)
            {
                mana.Hour = 9;
                mana.SetHour();
            }
            else
            {
                mana.Hour = 12;
                mana.SetHour();
            }
        }
    }


} 
