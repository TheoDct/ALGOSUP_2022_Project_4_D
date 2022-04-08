using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{

    public NavMeshAgent agent;
    public Transform Target;
    public float timeCheck = 2f;
    public bool BreakTime = false;

    private float lastCheck = 0f;
    private AI_Manager manager;

    // Start is called before the first frame update
    void Start()
    {
        if(Target!=null)agent.destination = Target.position;
        lastCheck = Time.time;
        manager = GameObject.Find("IA_MANAGER").GetComponent<AI_Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > lastCheck + Random.Range(2,10) && Target != null)
        {
            agent.destination = Target.position;
            lastCheck = Time.time;
        }
    }
}
