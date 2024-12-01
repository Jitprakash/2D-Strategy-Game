using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resourse : MonoBehaviour
{
    public string resourseType;
    public int resourseAmount;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (resourseAmount<=0)
        {
            Destroy(gameObject);
        }
        
    }
}
