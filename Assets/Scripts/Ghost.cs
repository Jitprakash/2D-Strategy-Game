using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public GameObject objectToSpawn;
    public GameObject buildEffect;
    public GameObject buildSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         Vector3 mousePosition =Camera.main.ScreenToWorldPoint(Input.mousePosition) ;//the mouse position is in pixel value we have toconvert it into world poition
            mousePosition.z=0;
            transform.position=mousePosition;

        //! Placing down the object on left click

        if (Input.GetMouseButtonDown(0))// this function takes '0' as an argumet for left click & '1' as an argument for right click 
        {
            Instantiate(buildSound);
            Instantiate(buildEffect,transform.position,Quaternion.identity);
            //* ShopButton.instance.ResourceCost();
            Instantiate(objectToSpawn,transform.position,Quaternion.identity);
            Destroy(gameObject);
        }
        
        // // if(Input.GetMouseButtonDown(1)){
        // //     Destroy(gameObject);
        // // }
        // my code on work
    }
}
