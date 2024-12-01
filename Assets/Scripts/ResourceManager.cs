using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System; //? a namespace for TextMashPro 
using UnityEngine.SceneManagement;
//! to count,store & display the number of resources collected
public class ResourceManager : MonoBehaviour
{
    public int wood;
    public int blood;
    public int crystal;
    public TMP_Text woodDisplay;
    public TMP_Text bloodDisplay;
    public TMP_Text crystalDisplay;
    
    // ! For managing Sacrifised workers
    public int numberOfSacrifisedWorkers;
    public TMP_Text sacrificedWorkersDisplay;
    public int GoalOfSacrifisedWorkers;
    public static ResourceManager instance;
    //! Creating a Instance of this class to be accesed outside
    private void Awake() // it is called even before Start() & automatically only once at the start of the script
    {
        instance=this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void AddResource(string resourceType, int amount) //! to count how much resourse we collected
    {
        if (resourceType == "wood")
        {
            wood += amount;
            woodDisplay.text=wood.ToString();
        }
        if (resourceType == "crystal")
        {
            crystal += amount;
            crystalDisplay.text=crystal.ToString();
        }
        if (resourceType == "blood")
        {
            blood += amount;
            bloodDisplay.text=blood.ToString();
        }
    }
    public void AddWorkerSacrifised()
    {
        numberOfSacrifisedWorkers++;
        sacrificedWorkersDisplay.text=numberOfSacrifisedWorkers +" /" + GoalOfSacrifisedWorkers;
        if(numberOfSacrifisedWorkers >= GoalOfSacrifisedWorkers)
        {
            //! to stop the game or do something when the goal is reached
            SceneManager.LoadScene(2);
        }
    }
}
