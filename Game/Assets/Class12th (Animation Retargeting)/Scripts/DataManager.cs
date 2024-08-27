using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    [SerializeField] int score;

    // Start is called before the first frame update
    void Awake()
    {
        Load();
    }

    public void Reset()
    {
        score = 0;
    }

    public void IncreaseScore()
    {
        score += Random.Range(5, 11);

        PlayerPrefs.SetInt("Score", score);
    }

    public void Load()
    {
        score = PlayerPrefs.GetInt("Score");
    }

    public void Save()
    {
        PlayerPrefs.Save();
    }
}
