using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipsManager : MonoBehaviour
{
    public GameObject instructionScreen;
    // Start is called before the first frame update
    void Start()
    {
        showInstructionScreen();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void showInstructionScreen()
    {
        instructionScreen.SetActive(true);
        Time.timeScale=0;
    }
    public void hideInstructionScreen()
    {
        instructionScreen.SetActive(false);
        Time.timeScale=1;
    }

}
