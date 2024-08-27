using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] GameObject selectObject;
    [SerializeField] DataManager dataManager;

    public void OnClick()
    {
        dataManager.Reset();
    }
}
