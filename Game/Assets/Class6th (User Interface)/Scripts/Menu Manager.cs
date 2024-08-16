using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] Text[] buttonTexts;
    [SerializeField] string[] buttonTextNames;

    // Start is called before the first frame update
    void Start()
    {
        // [  ] = "New Game"
        for (int i = 0; i < buttonTexts.Length; i++)
        {
            buttonTexts[i].text = buttonTextNames[i];
        }
    }
    
    public void NewGame()
    {
        Debug.Log("New Game");
    }

    public void Continue()
    {
        Debug.Log("Continue");
    }

    public void Exit()
    {
        Debug.Log("Exit");
    }
}
