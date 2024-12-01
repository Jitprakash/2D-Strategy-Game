using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public Ghost worker;
    public Ghost tree;
    public Ghost crystal;
    public Ghost village;
    public Ghost trap;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //! Creating a ghost Object whenever the function is called (we have to assign this to a button activity in unity)
    public void onShopClick(string whatItem)
    {
        if (whatItem=="worker")
        {
            Instantiate(worker);
        }
        if (whatItem=="village")
        {
            Instantiate(village);
        }
        if (whatItem=="crystal")
        {
            Instantiate(crystal);
        }
        if (whatItem=="tree")
        {
            Instantiate(tree);
        }
        if (whatItem=="trap")
        {
            Instantiate(trap);
        }
    }
}
