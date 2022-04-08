using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Manager : MonoBehaviour
{

    public int Number_IA = 0;
    public int Hour;
    public bool Createcheck = false;
    public bool ChangeCheck = false;
    public AI[] Ai_s;
    public GameObject AI_PREFAB;
    public Transform[] BreakArea = new Transform[10];
    public Transform[] AmphiArea = new Transform[156];

    private bool brea = false;
    private float lastTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("CreateAITable",5f);
        Invoke("SetHour",8f);
        lastTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (ChangeCheck)
        {
            SetHour();
        }
        if (brea && Time.time > lastTime + 5f)
        {
            for (int i = 0; i < Ai_s.Length; i++)
            {
                Ai_s[i].Target = BreakArea[(int)Random.Range(0, BreakArea.Length)];
            }
        }
    }

    public void CreateAITable()
    {
        Ai_s = new AI[Number_IA];
        for (int i = 0; i < Ai_s.Length; i++)
        {
            Ai_s[i] = Instantiate(AI_PREFAB, new Vector3(Random.Range(-40, -20), 0.9f, Random.Range(9, 30)),Quaternion.identity).GetComponent<AI>();
        }
    }

    public void SetHour()
    {
        if(Hour == 9)
        {
            brea = false;
            for(int i = 0; i < Ai_s.Length; i++)
            {
                Ai_s[i].Target = AmphiArea[i];
            }
        }else if(Hour == 12)
        {
            brea = true;
        }
    }

}
