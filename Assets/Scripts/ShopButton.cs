using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopButton : MonoBehaviour
{   //! making so you have to pay the prise of each item while buying at shop

    public int bloodCost;
    public int woodCost;
    public int crystalCost;
    Button button;
    public static ShopButton instance;
    private void Awake() // it is called even before Start() & automatically only once at the start of the script
    {
        instance=this;
    }

    // Start is called before the first frame update
    void Start()
    {
        button=GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ResourceManager.instance.blood<bloodCost || ResourceManager.instance.wood<woodCost || ResourceManager.instance.crystal<crystalCost)
        {
            button.interactable=false;
        } else
        {
            button.interactable =true;
        }
    }
    public void ResourceCost()
    {
        ResourceManager.instance.AddResource("blood",-bloodCost);
        ResourceManager.instance.AddResource("wood",-woodCost);
        ResourceManager.instance.AddResource("crystal",-crystalCost);
        
    }
}
